﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;


namespace Records_Manager
{
    public partial class Form1 : Form
    {
        Dictionary<int, List<Record>> records = new Dictionary<int, List<Record>>();
        bool SavedChanges;
        int CurrentlySelectedDiskInListView = 0;
        bool SelectedAllDisks = false;
        const string saveFileName = "database.grecs";
        public Search lastSearch;
        
        public Form1()
        {
            InitializeComponent();
            SavedChanges = true;
            CurrentlySelectedDiskInListView = 0;
            lastSearch = null;
        }
        public void RefreshResultsDynamically()
        {
            if (lastSearch== null)
            {
                if (SelectedAllDisks == false)
                {
                    if (CurrentlySelectedDiskInListView == 0) { return; }
                    listView1.Items.Clear();
                    foreach (Record r in records[CurrentlySelectedDiskInListView])
                    {
                        ListViewItem item = new ListViewItem((new[] { r.Title, CurrentlySelectedDiskInListView.ToString(), r.Series, r.Developer, r.Publisher, string.Join(",", r.Tags) }));
                        if (r.ImageURL.Length > 3) { item.ForeColor = Color.Gold; }
                        listView1.Items.Add(item);

                    }
                }
                else
                {
                    listView1.Items.Clear();

                    foreach (var record in records)
                    {
                        foreach (Record r in record.Value)
                        {
                            ListViewItem item = new ListViewItem(new[] { r.Title, record.Key.ToString(), r.Series, r.Developer, r.Publisher, string.Join(",", r.Tags) });
                            if (r.ImageURL.Length>3) { item.ForeColor = Color.Gold; }
                            listView1.Items.Add(item);
                             
                        }
                    }
                }
            }
            else
            {
                SearchInRecords(lastSearch);
            }
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> tags = new Tags().Data;
            foreach (string s in tags)
            {
                add_tags.Items.Add(s);
                search_tags.Items.Add(s);
                change_tags.Items.Add(s);
            }
        }
        public void ChangeSavedChangesStatus(bool saved)
        {
            if (saved)
            {
                SavedChanges = true;
                Text = "Games Database Manager [saved]";
            }
            else
            {
                SavedChanges = false;
                Text = "Games Database Manager [unsaved]*";
            }
        }

        private void LoadDatabase(object sender, EventArgs e)
        {
            if (SavedChanges == false) { _ = new MessageForm("You have unsaved changes.", 2).ShowDialog(); return; }
            records.Clear();
            string fullsaveFilePath = Path.Combine(Environment.CurrentDirectory, saveFileName);
            int allLoadedRecords = 0;
            if (File.Exists(fullsaveFilePath)) // fill the database if it was found
            {
                if (SavedChanges == false) { _ = new MessageForm("You have unsaved changes.", 2).ShowDialog(); return; }
                int currentDisk = 0;
                string[] file = File.ReadAllLines(fullsaveFilePath);
                foreach (string line in file)
                {
                    if (line.Trim().Length == 0) { continue; }

                    try
                    {
                        string edited = RemoveFirstAndLastCharacter(line);
                        string[] parts = edited.Split('|');
                        currentDisk = int.Parse(parts[1]);
                        Record r = new Record(parts[0], int.Parse(parts[1]), parts[2], parts[3], parts[4], parts[5].Split(',').ToList(), parts[6]);
                        if (!records.ContainsKey(currentDisk)) { records.Add(currentDisk, new List<Record>()); }
                        records[currentDisk].Add(r);
                        allLoadedRecords++;
                    }
                    catch { _ = new MessageForm("Error parsing the database file. Might be corrupted.", 2).ShowDialog(); return; }

                }
                if (allLoadedRecords > 0)
                {
                    _ = new MessageForm($"Loaded the database, with {records.Count} disk/s and {allLoadedRecords} record/s ", 1).ShowDialog();
                   



                    list_disks.Items.Clear();

                    foreach (var disk in records)
                    {
                        list_disks.Items.Add(disk.Key);
                    }
                    SortListBoxItemsNumeric(list_disks);
                    RefreshDisksGRoupBoxName();
                }
            }
            else
            {

                _ = new MessageForm($"{fullsaveFilePath} was not found.", 2).ShowDialog();
            }
        }
        public void RefreshDisksGRoupBoxName()
        {
            int recordsCount = records.Count;
            int recordsSubCount = 0;
            foreach (var disk in records) { recordsSubCount += disk.Value.Count; }
            groupBox_disks.Text = $"Disks: {recordsCount}, Records: {recordsSubCount}";
        }
        public static void SortListBoxItemsNumeric(ListBox listBox)
        {
            // Create a list to store the items as integers
            List<int> itemsList = new List<int>();

            // Add the ListBox items to the list as integers
            foreach (var item in listBox.Items)
            {
                if (int.TryParse(item.ToString(), out int numericValue))
                {
                    itemsList.Add(numericValue);
                }
            }

            // Sort the items numerically
            itemsList.Sort();

            // Clear the ListBox
            listBox.Items.Clear();

            // Add the sorted items back to the ListBox as strings
            foreach (var numericValue in itemsList)
            {
                listBox.Items.Add(numericValue.ToString());
            }
        }
        public static string RemoveFirstAndLastCharacter(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 3)
            {
                // If the input string is null, empty, or has less than 3 characters,
                // we cannot remove the first and last characters, so we return an empty string.
                return string.Empty;
            }

            // Use substring to remove the first and last characters.
            return input.Substring(1, input.Length - 2);
        }
        public static int ConvertStringToInt(string input)
        {
            int result;
            if (int.TryParse(input, out result))
            {
                // Parsing was successful, and 'result' contains the integer value.
                return result;
            }
            else
            {
                // Parsing failed, return 0 as the default value.
                return 0;
            }
        }

        private void BrowseFolder_Click(object sender, EventArgs e)
        {
            List<string> FoundContents = new List<string>();
            bool getFolders = add_action_options.GetItemChecked(0);
            bool getFiles = add_action_options.GetItemChecked(1);
            bool excludeHidden = add_action_options.GetItemChecked(2);
            bool excludeExtensions = add_action_options.GetItemChecked(3);
            bool BrowseSubFolders = add_action_options.GetItemChecked(4);
            if (!getFiles && !getFolders) { _ = new MessageForm("'Get Files' and/or 'Get Folders' must be checked", 2).ShowDialog(); return; }
            string targetFolder = string.Empty;

            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    targetFolder = folderDialog.SelectedPath;


                    string[] folders = Directory.GetDirectories(targetFolder);
                    string[] files = Directory.GetFiles(targetFolder);
                    List<string> localContent = new List<string>();


                    if (BrowseSubFolders)
                    {
                        foreach (string folder in folders)
                        {
                            FoundContents.AddRange(BrowseDirectory(folder, getFolders, getFiles, excludeHidden, excludeExtensions));
                        }
                    }
                    else
                    {
                        localContent = BrowseDirectory(targetFolder, getFolders, getFiles, excludeHidden, excludeExtensions);
                        FoundContents.AddRange(localContent);
                    }


                }

                // Display the found contents in your add_Names control
                if (FoundContents.Count > 0)
                {
                    add_Names.Text = string.Join(Environment.NewLine, FoundContents);
                }
                else
                {

                }
            }
        }

        public List<string> BrowseDirectory(string path, bool getFolders, bool getFiles, bool ExcludeHidden, bool ExcludeExtensions)
        {
            List<string> list = new List<string>();

            if (getFiles == false && getFolders == false)
            {
                return null;
            }
            if (getFiles)
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    bool hidden = IsHidden(file);
                    if (ExcludeHidden && hidden) { continue; }
                    if (ExcludeExtensions)
                    {
                        string justName = Path.GetFileNameWithoutExtension(file);
                        list.Add(justName);
                    }
                    else
                    {
                        string justName = Path.GetFileName(file);
                        list.Add(justName);

                    }



                }
            }
            if (getFolders)
            {
                string[] folders = Directory.GetDirectories(path);
                foreach (string folder in folders)
                {
                    bool hidden = IsHidden(folder);
                    if (ExcludeHidden && hidden) { continue; }

                    string folderName = GetDirectoryName(folder);
                    list.Add(folderName);
                }
            }

            return list;
        }

        public string GetDirectoryName(string fullPath)
        {
            string[] parts = fullPath.Split('\\').ToArray();
            return parts[parts.Length - 1];
        }

        static bool IsHidden(string path)
        {
            if (File.Exists(path) || Directory.Exists(path))
            {
                FileAttributes attributes = File.GetAttributes(path);
                return (attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
            }
            else
            {
                // The file or folder doesn't exist, so it can't be hidden.
                return false;
            }
        }
        private void RefreshDatabase(object sender, EventArgs e)
        {
            list_disks.Items.Clear();
            foreach (var disk in records)
            {
                list_disks.Items.Add(disk.Key);
            }
            SortListBoxItemsNumeric(list_disks);
        }
        public bool recordExists(string name)
        {
            bool exists = false;
            foreach (var disk in records)
            {
                foreach (var record in disk.Value)
                {
                    if (record.Title == name) { exists = true; break; }
                }
            }
            return exists;
        }
        private List<string> RemoveDuplicates(List<string> inputList)
        {
            // Create a HashSet to store unique elements
            HashSet<string> uniqueElements = new HashSet<string>();

            // Iterate through the input list and add elements to the HashSet
            foreach (string item in inputList)
            {
                uniqueElements.Add(item);
            }

            // Convert the HashSet back to a List
            List<string> result = uniqueElements.ToList();

            return result;
        }
        private void AddRecords_Click(object sender, EventArgs e)
        {
            List<string> ExistingRecords = new List<string>();
            if (add_Disk.Value == 0) { _ = new MessageForm("Disk 0 is not allowed", 2).ShowDialog(); ; return; }
            List<string> listOfTitles = add_Names.Text
     .Split('\n')
     .Select(x => x.Trim())
     .Where(x => !string.IsNullOrEmpty(x))
     .ToList();
            if (listOfTitles.Count == 0) { _ = new MessageForm("At least one title must be present in the list of titles", 2).ShowDialog(); return; }

            int addedTitles = 0;
            int maxTitles = listOfTitles.Count;
            listOfTitles = RemoveDuplicates(listOfTitles);
            string dev = add_Developer.Text.Trim();
            string pub = add_Publisher.Text.Trim();
            string ser = add_Series.Text.Trim();
            int disk = (int)add_Disk.Value;
            string url = add_url.Text.Trim();
            if (listOfTitles.Count == 0) { _ = new MessageForm("No title/s are entered", 2).ShowDialog(); return; }
            if (!IsAtLeastOneCheckBoxChecked()) { _ = new MessageForm("At least one tag must be checked", 2).ShowDialog(); return; }
            List<string> checkedItems = add_tags.CheckedItems.Cast<string>().ToList();
            if (listOfTitles.Count > 0)
            {
                foreach (string name in listOfTitles)
                {
                    if (add_action_options.GetItemChecked(0) == false)
                    {
                        if (recordExists(name)) { ExistingRecords.Add(name + " -> " + disk.ToString()); continue; }
                    }

                    Record n = new Record(name, disk, ser, dev, pub, checkedItems, url);
                    if (records.ContainsKey(disk) == false) { records.Add(disk, new List<Record> { n }); addedTitles++; }
                    else
                    {
                        records[disk].Add(n); addedTitles++;
                    }
                }
            }
            add_Names.Text = string.Empty;
            add_Developer.Text = string.Empty;
            add_Publisher.Text = string.Empty;
            add_Series.Text = string.Empty;
            add_Disk.Value = 0;
            UncheckAllCheckBoxes(add_tags);

            _ = new MessageForm($"Added {addedTitles}/{maxTitles} titles.", 1).ShowDialog();

            RefreshDisksGRoupBoxName();
            if (addedTitles > 0)
            {
                ChangeSavedChangesStatus(false);
            }
            if (ExistingRecords.Count > 0)
            {
                var v = new Existing_Records();
                foreach (string record in ExistingRecords)
                {
                    v.listBox1.Items.Add(record);
                }
                v.ShowDialog();
            }
        }
        private void UncheckAllCheckBoxes(CheckedListBox checkBoxList)
        {
            for (int i = 0; i < checkBoxList.Items.Count; i++)
            {
                checkBoxList.SetItemChecked(i, false);
            }
        }
        private void list_disks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ViewDisk();
        }
        public void ViewDisk()
        {
            if (list_disks.SelectedItems.Count > 0)
            {
                lastSearch = null;
                listView1.Items.Clear();
                int selected = int.Parse(list_disks.SelectedItems[0].ToString());
                CurrentlySelectedDiskInListView = selected;
                SelectedAllDisks = false;
                foreach (Record r in records[selected])
                {
                    ListViewItem item = (new ListViewItem(new[] { r.Title, selected.ToString(), r.Series, r.Developer, r.Publisher, string.Join(",", r.Tags) }));
                    if (r.ImageURL.Length>3) { item.ForeColor = Color.Gold; }
                    listView1.Items.Add(item);

                }


            }
        }
        private void ViewDisk(object sender, EventArgs e)
        {
            ViewDisk();
        }

        private void ViewDisks(object sender, EventArgs e)
        {
            if (records.Count > 0)
            {
                lastSearch = null;
                listView1.Items.Clear();

                foreach (var record in records)
                {
                    foreach (Record r in record.Value)
                    {
                        ListViewItem item = new ListViewItem(new[] { r.Title, record.Key.ToString(), r.Series, r.Developer, r.Publisher, string.Join(",", r.Tags) });
                        if (r.ImageURL.Length>3) { item.ForeColor = Color.Gold; }
                        listView1.Items.Add(item);

                    }
                }
                SelectedAllDisks = true;
            }
        }
        public void RefreshListView()
        {
            listView1.Items.Clear();
            if (CurrentlySelectedDiskInListView == 0)
            {

                foreach (var record in records)
                {
                    foreach (Record r in record.Value)
                    {
                        ListViewItem item = new ListViewItem(new[] { r.Title, record.Value.ToString(), r.Series, r.Developer, r.Publisher, string.Join(",", r.Tags) });
                        if (r.ImageURL.Length>3) { item.ForeColor = Color.Gold; }
                        listView1.Items.Add(item);

                    }
                }
            }
            else
            {
                foreach (Record r in records[CurrentlySelectedDiskInListView])
                {
                    ListViewItem item = new ListViewItem(new[] { r.Title, CurrentlySelectedDiskInListView.ToString(), r.Series, r.Developer, r.Publisher, string.Join(",", r.Tags) });
                    if (r.ImageURL.Length>3) { item.ForeColor = Color.Gold; }
                    listView1.Items.Add(item);

                }
            }

        }
        private void DeleteRecord(object sender, EventArgs e) // delete record if it exists. then refresh the listview
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string name = item.ToString();
                    int disk = int.Parse(item.SubItems[0].ToString());
                    for (int i = 0; i < records[disk].Count; i++)
                    {
                        if (records[disk][i].Title == name)
                        {
                            records[disk].RemoveAt(i); break;
                        }
                    }

                }
                RefreshListView();
            }
        }

        private void SaveAllChanges(object sender, EventArgs e)
        {
            if (records.Count == 0) { _ = new MessageForm("Nothing to save", 2).ShowDialog(); return; }
            if (SavedChanges) { _ = new MessageForm("Nothing to save", 2).ShowDialog(); return; }
            else
            {


                ChangeSavedChangesStatus(true);
                string fullSavePath = Path.Combine(Environment.CurrentDirectory, saveFileName);
                if (File.Exists(fullSavePath)) { File.Delete(fullSavePath); }
                string data = string.Empty;
                int countRecords = 0;
                foreach (var disk in records)
                {

                    foreach (Record rec in disk.Value)
                    {
                        data += rec.ToString() + "\n";
                        countRecords++;
                    }
                }
                File.WriteAllText(fullSavePath, data);
                _ = new MessageForm($"Saved the database with {records.Count} disk/s and {countRecords} record/s.", 1).ShowDialog();

            }
        }

        private void DiscardDatabase(object sender, EventArgs e)
        {
            if (records.Count > 0)
            {
                _ = new MessageForm($"Discarded the current database.", 1).ShowDialog();

            }
            else
            {
                _ = new MessageForm($"An empty database cannot be discarded", 2).ShowDialog();
                return;
            }
            ChangeSavedChangesStatus(true);
            listView1.Items.Clear();
            change_dev.Text = string.Empty;
            change_name.Text = string.Empty;
            change_series.Text = string.Empty;
            change_pub.Text = string.Empty;
            change_url.Text = string.Empty;
            UncheckAllCheckBoxes(add_tags);
            UncheckAllCheckBoxes(change_tags);
            UncheckAllCheckBoxes(search_tags);
            records.Clear();
            list_disks.Items.Clear();
        }

        private void DeleteDisk(object sender, EventArgs e)
        {
            if (list_disks.SelectedItems.Count == 1)
            {
                int disk = int.Parse(list_disks.SelectedItems[0].ToString());
                records.Remove(disk);
                RefreshDatabase(null, null);
                ChangeSavedChangesStatus(false);
                _ = new MessageForm($"Deleted disk {disk} from the database", 2).ShowDialog();
            }
            else
            {
                _ = new MessageForm($"Must select a disk first", 2).ShowDialog();
            }
        }

        private void SearchRecords_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lastSearch = null;
                lastSearch = new Search(search_name.Text, search_byName.Checked, search_byDev.Checked, search_byPublisher.Checked, search_bySeries.Checked, search_mustnotcontain.Text, search_indisks.Text, search_tags);

                SearchInRecords(lastSearch);
            }

        }
        public List<string> GetCheckedCheckboxNames(CheckedListBox listCheckBox1)
        {

            List<string> checkedNames = new List<string>();

            for (int i = 0; i < listCheckBox1.Items.Count; i++)
            {
                if (listCheckBox1.GetItemChecked(i))
                {
                    checkedNames.Add(listCheckBox1.Items[i].ToString());
                }
            }

            return checkedNames;
        }
        bool RecordTagsArePresent(Record record, List<string> checkedTags)
        {
            bool containsAll = true;
            if (checkedTags.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (string tag in checkedTags)
                {
                    if (record.Tags.Contains(tag)) { continue; }
                    else
                    {
                        containsAll = false; break;
                    }
                }

            }
            return containsAll;

        }
        bool StringContainsNOTstring(string input, List<string> strings)
        {
            if (strings.Count == 0) { return true; }
            bool containsNOT = true;
            foreach (string stringtoNOTbePresent in strings)
            {
                if (input.Contains(stringtoNOTbePresent)) { containsNOT = false; break; }
            }
            return containsNOT;
        }

        // Other parts of your code...

        private void DisplayResults(List<Record> results)
        {


            listView1.Items.Clear();

            if (results.Count > 0)
            {
                foreach (Record result in results)
                {
                    ListViewItem temp = result.getRow();
                    listView1.Items.Add(temp);
                }
            }
        }

        private List<int> GetSelectedDisks(string diskData)
        {
            List<int> Disks = new List<int>();

            if (diskData.Trim().Length == 0) //if none are selected, return a list of all available
            {
                foreach (int number in records.Keys) { Disks.Add(number); }
                return Disks;
            }
            //-------------------------------------------------------------
            string[] textlistdisks = search_indisks.Text.Split(',');


            foreach (string disk in textlistdisks)
            {
                string raw = disk.Trim();
                if (int.TryParse(raw, out int result))
                {
                    Disks.Add(result);
                }

            }
            return Disks;
        }





        public bool StringContainsAllItems(string WhichString, List<string> listofItemsToCheck)
        {
            // Check if all items in the list are present in the WhichString
            return listofItemsToCheck.All(item => WhichString.Contains(item));
        }

        public bool StringContainsNOTAllItems(string WhichString, List<string> listofItemsToCheck)
        {
            // Check if any item in the list is not present in the WhichString
            return listofItemsToCheck.All(item => !WhichString.Contains(item));
        }
        public List<string> GetCheckedItemsFromCheckedListBox(CheckedListBox checkedListBox)
        {
            List<string> checkedItemsList = new List<string>();

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    string checkedItem = checkedListBox.Items[i].ToString();
                    checkedItemsList.Add(checkedItem);
                }
            }

            return checkedItemsList;
        }
        public bool AreAllItemsContained(List<string> sublist, List<string> fullList)
        {
            // Use LINQ to check if all items in 'sublist' are contained in 'fullList'
            return sublist.All(item => fullList.Contains(item));
        }

        private void add_action_options_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_Click(object sender, EventArgs e)
        {
            int checkedCount = change_tags.CheckedItems.Count;
            int totalCount = change_tags.Items.Count;

            change_groupBox_tags.Text = $"Tags {checkedCount}/{totalCount}";
        }

        private void checkedListBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int checkedCount = change_tags.CheckedItems.Count;
            int totalCount = change_tags.Items.Count;

            change_groupBox_tags.Text = $"Tags {checkedCount}/{totalCount}";
        }
        private void setTagsGroupBoxCount(CheckedListBox checkedListBox, GroupBox whichGroupBox)
        {
            int checkedCount = 0;
            int maxCount = checkedListBox.Items.Count;

            for (int i = 0; i < maxCount; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    checkedCount++;
                }
            }

            whichGroupBox.Text=$"Tags: {checkedCount}/{maxCount}";
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when you click on a name you should have the data entered in fields

            if (listView1.SelectedItems.Count == 1)
            {
                pictureBox_Header.Visible = false;
                // Assuming you want to retrieve subitems of the first selected item
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Create an array to store the subitem texts
                string[] SelectedRecordItemsData = new string[selectedItem.SubItems.Count];

                // Iterate through the subitems and store their text in the array
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    SelectedRecordItemsData[i] = selectedItem.SubItems[i].Text;
                }

                // Now, subitemArray contains the text of all subitems in the clicked row.
                change_name.Text = SelectedRecordItemsData[0];
                change_disk.Value = int.Parse(SelectedRecordItemsData[1]);
                change_series.Text = SelectedRecordItemsData[2];
                change_dev.Text = SelectedRecordItemsData[3];
                change_pub.Text = SelectedRecordItemsData[4];
                // now the tags
                PopulateChangeTagsCheckedListBox(SelectedRecordItemsData[5]);
                setTagsGroupBoxCount(change_tags, change_groupBox_tags);
                // now the image
                foreach (var item in records[int.Parse(SelectedRecordItemsData[1])])
                {
                    if (item.Title == SelectedRecordItemsData[0])
                    {
                        change_url.Text = item.ImageURL;

                        if (item.ImageURL.Trim() != string.Empty)
                        {
                            try
                            {
                                using (WebClient webClient = new WebClient())
                                {
                                    byte[] imageBytes = webClient.DownloadData(item.ImageURL);

                                    // Create an Image object from the downloaded bytes
                                    System.IO.MemoryStream stream = new System.IO.MemoryStream(imageBytes);
                                    Image image = Image.FromStream(stream);

                                    // Assign the image to PictureBox1's Image property
                                    pictureBox_Header.Image = image;
                                    pictureBox_Header.Visible = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                pictureBox_Header.Visible = false;
                            }
                        }
                        else
                        {
                            pictureBox_Header.Visible = false;
                        }
                    }
                }
            }
            if (listView1.SelectedItems.Count > 1)
            {
                change_name.Text = string.Empty;
                change_disk.Value = 0;
                change_series.Text = string.Empty;
                change_dev.Text = string.Empty;
                change_pub.Text = string.Empty;
            }
        }
        private void PopulateChangeTagsCheckedListBox(string inputString)
        {
            // Split the input string into individual items using the comma as a separator
            string[] items = inputString.Split(',');

            // Uncheck all checkboxes in change_tags
            for (int i = 0; i < change_tags.Items.Count; i++)
            {
                change_tags.SetItemChecked(i, false);
            }

            // Iterate through the items and check the corresponding checkboxes in change_tags
            foreach (string item in items)
            {
                int index = change_tags.FindStringExact(item); // Find the index of the item
                if (index != ListBox.NoMatches)
                {
                    // If the item is found in change_tags, check it
                    change_tags.SetItemChecked(index, true);
                }
            }
        }


        private bool IsAtLeastOneCheckBoxChecked()
        {
            foreach (object item in add_tags.CheckedItems)
            {
                // If there is at least one checked item, return true
                return true;
            }

            // If no checked items were found, return false
            return false;
        }
        public void ClearChangeFields()
        {
            change_dev.Text = string.Empty;
            change_pub.Text = string.Empty;
            change_disk.Value = 0;
            change_series.Text = string.Empty;
            change_url.Text = string.Empty;
            change_name.Text = string.Empty;
            UncheckAllCheckBoxes(change_tags);
        }
        private void changeRecord_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }
            string newName = change_name.Text.Trim();

            if (newName == string.Empty) { _ = new MessageForm($"Title cannot be empty", 2).ShowDialog(); return; }
            int newDisk = (int)change_disk.Value;
            if (newDisk == 0) { _ = new MessageForm($"New disk cannot be 0", 2).ShowDialog(); return; }
            string series = change_series.Text.Trim();
            string developer = change_dev.Text.Trim();
            string publisher = change_pub.Text.Trim();
            string url = change_url.Text.Trim();

            List<string> newTags = GetCheckedItemsFromCheckedListBox(change_tags);
            if (newTags.Count == 0) { _ = new MessageForm($"At least one tag must be checked", 2).ShowDialog(); return; }

            if (listView1.SelectedItems.Count > 0)
            {
                foreach (int index in listView1.SelectedIndices)
                {
                    string currrentName = listView1.Items[index].SubItems[0].Text;

                    int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                    for (int i = 0; i < records[currentDisk].Count; i++)
                    {
                        if (records[currentDisk][i].Title == currrentName)
                        {
                            Record newRecord = new Record(newName, newDisk, series, developer, publisher, newTags, url);
                            if (currentDisk != newDisk)
                            {
                                if (!records.ContainsKey(newDisk)) { records.Add(newDisk, new List<Record>()); }
                                records[newDisk].Add(newRecord);
                                records[currentDisk].RemoveAt(i);
                                if (records[currentDisk].Count == 0) { records.Remove(newDisk); }
                            }
                            else
                            {
                                records[currentDisk][i] = newRecord;
                            }


                        }
                    }

                    _ = new MessageForm($"Changes made", 1).ShowDialog();

                    ChangeSavedChangesStatus(false);
                    RefreshResultsDynamically();
                    ClearChangeFields();
                }
            }
        }

        private void removeRecord_Click(object sender, EventArgs e)
        {
            int clearedItems = 0;
            if (listView1.SelectedItems.Count > 0)
            {

                foreach (int index in listView1.SelectedIndices)
                {
                    string currrentName = listView1.Items[index].SubItems[0].Text;
                    int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);
                    for (int i = 0; i < records[currentDisk].Count; i++)
                    {
                        if (records[currentDisk][i].Title == currrentName) { records[currentDisk].RemoveAt(i); break; }
                    }

                    clearedItems++;
                }
                RefreshDisksGRoupBoxName();
            }
            else
            {
                _ = new MessageForm($"Must select at least one record from the list first", 2).ShowDialog(); return;
            }
            listView1.Items.Clear();
            RemoveEmptyDrives();
            _ = new MessageForm($"Removed {clearedItems} items from the database.", 1).ShowDialog();
            ChangeSavedChangesStatus(false);
        }
        public void RemoveEmptyDrives()
        {
            foreach (var item in records)
            {
                if (item.Value.Count == 0)
                {
                    records.Remove(item.Key);
                }
            }
        }
        public void SearchInRecords(Search searchData)
        {
            // get the searched name - if empty, it can be with any name, as long as there are other requirements
            string search = searchData.Title;
             // prepare the list of results, for filling
            List<Record> results = new List<Record>();
            // the list of words that should not be containe in the string
            List<string> MustNotContain_List = searchData.ExcludedContents.Trim() == string.Empty ? new List<string>() : searchData.ExcludedContents.Split(',').ToList();
            // get the selected disks if any
            List<int> selectedDisks = GetSelectedDisks(searchData.InDisks);
           // get the cheked tags
            List<string> checkedTags = GetCheckedCheckboxNames(searchData.Tags);
            //---------------------------------------------------------------------
            foreach (int disk_index in selectedDisks)
            {
               if (!records.ContainsKey(disk_index)) { continue; }
                foreach (Record record in records[disk_index])
                {
                    string searched_field = string.Empty;
                    if (searchData.Search_ByTitle)
                    {
                        searched_field = record.Title;
                    }
                    if (searchData.Search_ByDev)
                    {
                        searched_field = record.Developer;
                    }
                    if (searchData.Search_ByPub)
                    {

                        searched_field = record.Publisher;
                    }
                    if (searchData.Search_BySeries)
                    {
                        searched_field = record.Series;
                    }
                    searched_field = searched_field.ToLower();
                    bool Contains_Name = search == string.Empty ? true : searched_field.Contains(search);
                    bool ContainsNOT = MustNotContain_List.Count == 0 ? true : StringContainsNOTstring(searched_field, MustNotContain_List);
                    bool ContainsTags = checkedTags.Count == 0 ? true : RecordTagsArePresent(record, checkedTags);
                    if (Contains_Name && ContainsNOT && ContainsTags) { results.Add(record); }
                }
            }
             DisplayResults(results);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            lastSearch = null;
            lastSearch = new Search(search_name.Text,search_byName.Checked, search_byDev.Checked,search_byPublisher.Checked,search_bySeries.Checked,search_mustnotcontain.Text,search_indisks.Text,search_tags);
            SearchInRecords(lastSearch);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SavedChanges == false)
            {
                DialogResult result = MessageBox.Show("Do you want to save your changes before exiting?", "Confirmation", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    SaveAllChanges(null, null);
                }
                else if (result == DialogResult.No)
                {
                    // Discard changes and allow the form to close.
                }
                else
                {
                    // Cancel the form closing operation.
                    e.Cancel = true;
                }
            }



        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Selected = true;
            }
        }

        private void selectNoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Selected = false;
            }
        }

        private void selectInverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Selected = !item.Selected;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
                pictureBox_Header.Visible = false;
                _ = new MessageForm("Copied to the clipboard", 1);
            }
        }

        private void copyAsTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopySelectedItemsToClipboard(listView1);
        }
        public static void CopySelectedItemsToClipboard(ListView listView)
        {
            // Get selected items from the ListView
            var selectedItems = listView.SelectedItems.Cast<ListViewItem>();

            // Create a list to store the formatted strings
            List<string> formattedStrings = new List<string>();

            // Process selected items and format them
            foreach (var item in selectedItems)
            {
                // Get the subitems (assuming there are at least two columns)
                string[] subitems = item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subitem => subitem.Text).ToArray();

                // Join subitems with "|"
                string formattedString = string.Join("|", subitems);

                // Add the formatted string to the list
                formattedStrings.Add(formattedString);
            }

            // Join formatted strings with newlines
            string result = string.Join(Environment.NewLine, formattedStrings);

            // Copy the result to the clipboard
            Clipboard.SetText(result);

            Console.WriteLine("Selected items copied to clipboard:");
            Console.WriteLine(result);
        }

        private void changeDiskNumber_Click(object sender, EventArgs e)
        {
            if (list_disks.SelectedItems.Count == 1)
            {
                int SelectedDisk = int.Parse(list_disks.Items[list_disks.SelectedIndex].ToString());
                int newDisk = 0;
                using (var v = new changeValue())
                {
                    if (v.ShowDialog() == DialogResult.OK)
                    {
                        newDisk = (int)v.numericUpDown1.Value;

                        if (records.ContainsKey(newDisk))
                        {
                            records[newDisk].AddRange(records[SelectedDisk]);
                            records.Remove(SelectedDisk);
                        }
                        else
                        {
                            records.Add(newDisk, records[SelectedDisk]);
                            records.Remove(SelectedDisk);
                        }
                        RefreshDatabase(null, null);
                        ChangeSavedChangesStatus(false);
                        listView1.Items.Clear();
                    }
                }

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Header_DoubleClick(object sender, EventArgs e)
        {
            pictureBox_Header.Visible = false;
        }

        private void changeSeriesOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }

            string ser = change_series.Text.Trim();
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "series";


            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                    {

                        records[currentDisk][i].Series = ser;

                        updateCount++;
                    }

                }
            }

            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s with the new {updateWhat}.", 1).ShowDialog();

            RefreshResultsDynamically();
            ClearChangeFields();
            ChangeSavedChangesStatus(false);
        }

        private void changeDiskOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }


            int disk = (int)change_disk.Value;
            if (disk == 0) { _ = new MessageForm($"Disk is not allowed to be 0.", 2).ShowDialog(); return; }
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "disk";
            List<string> RecordsToRemove = new List<string>();

            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                    {

                        records[currentDisk][i].Disk = disk;
                        if (!records.ContainsKey(disk)) { records.Add(disk, new List<Record>()); }
                        records[disk].Add(records[currentDisk][i]);
                        RecordsToRemove.Add(records[currentDisk][i].Title);
                        records[currentDisk].RemoveAt(i);
                        updateCount++;
                    }

                }
                while (RecordsToRemove.Count > 0)
                {
                    for (int i = 0; i < records[currentDisk].Count; i++)
                    {
                        if (records[currentDisk][i].Title == RecordsToRemove[0]) ;
                        records[currentDisk].RemoveAt(i);
                        RecordsToRemove.RemoveAt(0);
                        break;
                    }
                }
            }



            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s with the new {updateWhat}.", 1).ShowDialog();

            RefreshResultsDynamically();
            ClearChangeFields();
            ChangeSavedChangesStatus(false);
        }

        private void changeDeveloperOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }

            string dev = change_dev.Text.Trim();
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "developer";


            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                    {

                        records[currentDisk][i].Developer = dev;

                        updateCount++;
                    }

                }
            }

            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s with the new {updateWhat}.", 1).ShowDialog();

            RefreshResultsDynamically();
            ClearChangeFields();
            ChangeSavedChangesStatus(false);
        }

        private void changePublisherOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }

            string publisher = change_pub.Text.Trim();
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "publisher";


            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                    {

                        records[currentDisk][i].Publisher = publisher;

                        updateCount++;
                    }

                }
            }

            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s with the new {updateWhat}.", 1).ShowDialog();

            RefreshResultsDynamically();
            ClearChangeFields();
            ChangeSavedChangesStatus(false);
        }

        private void changeTagsOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }

            List<string> checkedItems = change_tags.CheckedItems.Cast<string>().ToList();
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "tags";


            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                    {

                        records[currentDisk][i].Tags = checkedItems;

                        updateCount++;
                    }

                }
            }

            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s with the new {updateWhat}.", 1).ShowDialog();

            RefreshResultsDynamically();
            ClearChangeFields();
            ChangeSavedChangesStatus(false);
        }

        private void changeImageOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }

            string url = change_url.Text.Trim();
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "image url";


            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                    {

                        records[currentDisk][i].ImageURL = url;

                        updateCount++;
                    }

                }
            }

            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s with the new {updateWhat}.", 1).ShowDialog();


            RefreshResultsDynamically();
            ClearChangeFields();
            ChangeSavedChangesStatus(false);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }

            string title = change_name.Text.Trim();
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "title";


            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                    {

                        records[currentDisk][i].Title = title;

                        updateCount++;
                    }

                }
            }

            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s with the new {updateWhat}.", 1).ShowDialog();

            RefreshResultsDynamically();
            ClearChangeFields();
            ChangeSavedChangesStatus(false);
        }

        private void search_tags_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTagsGroupBoxCount(search_tags, groupBox_tags_search);
        }

        private void add_tags_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTagsGroupBoxCount(add_tags, groupBox_tags_add);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // here the hotkeys
            // Check for the key combination
            if (e.Alt && e.KeyCode == Keys.D1)
            {
                // Your code to handle the key combination goes here
                // For example, display a message box:
               tabControl1.SelectedIndex= 0;
            }
            if (e.Alt && e.KeyCode == Keys.D2)
            {
                // Your code to handle the key combination goes here
                // For example, display a message box:
                tabControl1.SelectedIndex = 1;
            }
            if (e.Alt && e.KeyCode == Keys.D3)
            {
                // Your code to handle the key combination goes here
                // For example, display a message box:
                tabControl1.SelectedIndex = 2;
            }
            if (e.Alt && e.KeyCode == Keys.D4)
            {
                // Your code to handle the key combination goes here
                // For example, display a message box:
                tabControl1.SelectedIndex = 3;
            }
        }
    }
}

