using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Records_Manager
{
    public partial class Form1 : Form
    {
        Dictionary<int, List<Record>> records = new Dictionary<int, List<Record>>();
        List<Disk> Disks = new List<Disk>();
        List<Record> lastSearchedRecords = new List<Record>();
        bool SavedChanges;
        int CurrentlySelectedDiskInListView = 0;
        bool SelectedAllDisks = false;
        const string saveFileName = "database.grecs";
        public Search lastSearch;
        public Search tempSearch;
        bool searched_count = false;
        string appName;
        int Changes_Counter;
        Search_Filter Filter;
        List<Search> SearchHistory; 
        public Form1()
        {
            InitializeComponent();
            SavedChanges = true;
            CurrentlySelectedDiskInListView = 0;
            lastSearch = null;
            appName = Text;
            Changes_Counter = 0;
            Filter = new Search_Filter();
            SearchHistory = new List<Search>();
        }
        public void RefreshLastSearch()
        {
           
                SearchInRecords(lastSearch);
        
        }
        public void SearchInRecords(Search searchData)
        {
            if (searchData == null) { return; }
            if (records.Count == 0) { _ = new MessageForm("Database is empty", 2).ShowDialog(); return; }
            // get the searched name - if empty, it can be with any name, as long as there are other requirements
            string search = searchData.Keywords;
            List<string> multiSearch = search.Split(',').Select(x => x.Trim()).ToList();
            // prepare the list of results, for filling
            List<Record> results = new List<Record>();
            // the list of words that should not be containe in the string
            List<string> MustNotContain_List = searchData.ExcludedKeywords.Trim() == string.Empty ? new List<string>() : searchData.ExcludedKeywords.Split(',').ToList();
            // get the selected disks if any
            List<int> selectedDisks = searchData.Disks;
            if (selectedDisks.Count == 0)
            {
                foreach (var v in records)
                {
                    selectedDisks.Add(v.Key);
                }

            }
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
                    if (multiSearch.Count > 1) { foreach (string keyword in multiSearch) { if (searched_field.Contains(keyword)) { Contains_Name = true; break; } } }
                    bool ContainsNOT = MustNotContain_List.Count == 0 ? true : StringContainsNOTstring(searched_field, MustNotContain_List);
                    bool ContainsTags = checkedTags.Count == 0 ? true : RecordTagsArePresent(record, checkedTags);
                    bool SatisfiesFilters = true;
                    if (searchData.Filter.Search_Dev == -1) { SatisfiesFilters = record.Developer.Trim().Length == 0 ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }
                    if (searchData.Filter.Search_Dev == 0) { SatisfiesFilters = true; }
                    if (searchData.Filter.Search_Dev == 1) { SatisfiesFilters = record.Developer.Trim().Length > 0 ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }

                    if (searchData.Filter.Search_Series == -1) { SatisfiesFilters = record.Series.Trim().Length == 0 ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }
                    if (searchData.Filter.Search_Series == 0) { SatisfiesFilters = true; }
                    if (searchData.Filter.Search_Series == 1) { SatisfiesFilters = record.Series.Trim().Length > 0 ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }

                    if (searchData.Filter.Search_Pub == -1) { SatisfiesFilters = record.Publisher.Trim().Length == 0 ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }
                    if (searchData.Filter.Search_Pub == 0) { SatisfiesFilters = true; }
                    if (searchData.Filter.Search_Pub == 1) { SatisfiesFilters = record.Publisher.Trim().Length > 0 ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }

                    if (searchData.Filter.Search_Image == -1) { SatisfiesFilters = record.ImageURL.Trim().Length == 0 ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }
                    if (searchData.Filter.Search_Image == 0) { SatisfiesFilters = true; }
                    if (searchData.Filter.Search_Image == 1) { SatisfiesFilters = record.ImageURL.Trim().Length > 0 ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }

                    if (searchData.Filter.Search_Missing == 1) { SatisfiesFilters = record.Missing == true ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }
                    if (searchData.Filter.Search_Missing == 0) { SatisfiesFilters = true; }
                    if (searchData.Filter.Search_Missing == -1) { SatisfiesFilters = record.Missing == false ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }

                    if (searchData.Filter.Search_Broken == 1) { SatisfiesFilters = record.Broken == true ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }
                    if (searchData.Filter.Search_Broken == 0) { SatisfiesFilters = true; }
                    if (searchData.Filter.Search_Broken == -1) { SatisfiesFilters = record.Broken == false ? true : false; }
                    if (SatisfiesFilters == false) { goto final; }
                final:
                    if (Contains_Name && ContainsNOT && ContainsTags && SatisfiesFilters) { results.Add(record); }
                }
            }
            if (searched_count==true)
            {
                searched_count = false;
                label_countSearch.Text = $"Count search results: {results.Count}";
                
            }
            else
            {
                label_countResuults.Text = $"Search results: {results.Count}";
                lastSearch = searchData;
                DisplayResultsAsync(results);
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
                Text = $"{appName} [saved]";
                Changes_Counter= 0;
            }
            else
            {
                SavedChanges = false;
                Text = $"{appName} [unsaved]* - {Changes_Counter} unsaved changes";
            }
        }
        static string RemoveLastCharacter(string input, out char lastChar)
        {
            if (!string.IsNullOrEmpty(input))
            {
                lastChar = input[input.Length - 1];
                return input.Substring(0, input.Length - 1);
            }
            else
            {
                lastChar = '\0'; // Return null character if the input string is empty
                return input;
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
                        string edited = string.Empty;

                        char lastChar = line[line.Length - 1];
                        bool missing = lastChar == '-' ? true : false;
                        bool broken = lastChar == '=' ? true : false;
                        if (lastChar != ']') { edited = line.Substring(0, line.Length - 1); }
                        edited = RemoveFirstAndLastCharacter(line);
                        string[] parts = edited.Split('|');
                        currentDisk = int.Parse(parts[1]);
                        Record r = new Record(parts[0], int.Parse(parts[1]), parts[2], parts[3], parts[4], parts[5].Split(',').ToList(), parts[6], broken, missing);
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
                    ChangeSavedChangesStatus(true);
                    listView1.Items.Clear();
                    label_countResuults.Text = string.Empty;
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
        private void RefreshDatabase_ListOfDisks(object sender, EventArgs e)
        {
            list_disks.Items.Clear();
            foreach (var disk in records)
            {
                list_disks.Items.Add(disk.Key);
            }
            SortListBoxItemsNumeric(list_disks);
            RefreshDisksGRoupBoxName();
        }
        public bool recordExists(string name)
        {
            bool exists = false;
            foreach (var disk in records)
            {
                foreach (var record in disk.Value)
                {
                    if (record.Title.ToLower() == name.ToLower()) { exists = true; break; }
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
        public bool CheckForDulicatingRecords(List<string> list)
        {
            if (list.Count == 1) { return false; }
            //first lowrcase them to compare easier
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].ToLower();

            }
            bool thereAreDuplicates = false;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; i++)
                {
                    if (i == j) { continue; }
                    if (list[i] == list[j])
                    thereAreDuplicates = true;
                    break;
                }
                if (thereAreDuplicates) { break; }
            }


            return thereAreDuplicates;
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
            bool DuplicatingRecords = CheckForDulicatingRecords(listOfTitles);
            if (DuplicatingRecords)
            {
                _ = new MessageForm("There are duplicating lines in the input field 'Title/s'.\nAdding process was cancelled.", 2).ShowDialog(); return;
            }
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
            bool hasNewDisks = false;
            if (listOfTitles.Count > 0)
            {
                foreach (string name in listOfTitles)
                {
                    if (add_action_options.GetItemChecked(0) == false)
                    {
                        if (recordExists(name)) { ExistingRecords.Add(name + " -> " + disk.ToString()); continue; }
                    }

                    Record n = new Record(name, disk, ser, dev, pub, checkedItems, url);
                    if (records.ContainsKey(disk) == false) { records.Add(disk, new List<Record> { n }); addedTitles++; hasNewDisks = true; }
                    else
                    {
                        records[disk].Add(n); addedTitles++;
                    }
                }
            }
            if (hasNewDisks) { RefreshDatabase_ListOfDisks(null,null); }
            add_Names.Text = string.Empty;
            add_Developer.Text = string.Empty;
            add_Publisher.Text = string.Empty;
            add_Series.Text = string.Empty;
            add_Disk.Value = 0;
            UncheckAllCheckBoxes(add_tags);

            _ = new MessageForm($"Added {addedTitles}/{maxTitles} titles.", 1).ShowDialog();

            RefreshDisksGRoupBoxName();
            Changes_Counter++;
            ChangeSavedChangesStatus(false);
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
            RefreshLastSearch();
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
                string searchedDisk = list_disks.SelectedItems[0].ToString().Trim();
                 
                 lastSearch = new Search("", true, false, false, false, "", searchedDisk, null, new Search_Filter(),DateTime.Now.ToString());
                SearchHistory.Add(lastSearch);
                SearchInRecords(lastSearch);

                
            }
        }
        private void ViewDisk(object sender, EventArgs e)
        {
            ViewDisk();
        }

        private void ViewDisks(object sender, EventArgs e)
        {
            string allDisks =   string.Join(",", list_disks.Items.Cast<string>());
            lastSearch = new Search("",true,false,false,false,"", allDisks, null,new Search_Filter(), DateTime.Now.ToString());
            SearchHistory.Add(lastSearch);
            SearchInRecords(lastSearch);

          
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
            RefreshDisksGRoupBoxName();
        }

        private void DeleteDisk(object sender, EventArgs e)
        {
            if (list_disks.SelectedItems.Count == 1)
            {
                int disk = int.Parse(list_disks.SelectedItems[0].ToString());
                records.Remove(disk);
                RefreshDatabase_ListOfDisks(null, null);
                ChangeSavedChangesStatus(false);
                _ = new MessageForm($"Deleted disk {disk} from the database", 2).ShowDialog();
                RefreshLastSearch();
                RefreshDisksGRoupBoxName();
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
               
                tempSearch = new Search(search_name.Text, search_byName.Checked, search_byDev.Checked, search_byPublisher.Checked, search_bySeries.Checked, search_mustnotcontain.Text, search_indisks.Text, search_tags, Filter, DateTime.Now.ToString());
                SearchHistory.Add(tempSearch);
                SearchInRecords(tempSearch);
            }

        }
        public List<string> GetCheckedCheckboxNames(CheckedListBox listCheckBox)
        {
                if (listCheckBox == null) { return new List<string>(); } 
            List<string> checkedNames = new List<string>();

            for (int i = 0; i < listCheckBox.Items.Count; i++)
            {
                if (listCheckBox.GetItemChecked(i))
                {
                    checkedNames.Add(listCheckBox.Items[i].ToString());
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

        private async Task DisplayResultsAsync(List<Record> results)
        {
            int batchSize = 50; // Adjust the batch size as needed
            int count = 0;
            listView1.Items.Clear();

            if (results.Count > 0)
            {
                // Show the progress bar
                progressBar1.Visible = true;

                // Perform the time-consuming operation on a separate thread
                await Task.Run(() =>
                {
                    listView1.BeginInvoke(new Action(() =>
                    {
                        listView1.BeginUpdate(); // Suspend layout updates
                    }));

                    for (int i = 0; i < results.Count; i++)
                    {
                        ListViewItem temp = results[i].getRow();

                        // Add the item to the ListView
                        listView1.BeginInvoke(new Action(() =>
                        {
                            listView1.Items.Add(temp);
                        }));

                        count++;

                        if (count % batchSize == 0 || i == results.Count - 1)
                        {
                            // Update progress after each batch or at the end
                            int progress = (count * 100) / results.Count;
                            UpdateProgressBar(progress);
                        }
                    }

                    listView1.BeginInvoke(new Action(() =>
                    {
                        listView1.EndUpdate(); // Resume layout updates
                    }));
                });

                // Hide the progress bar when done
                progressBar1.Visible = false;
               
            }
        }

        private void UpdateProgressBar(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => progressBar1.Value = value));
            }
            else
            {
                progressBar1.Value = value;
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
                PopulateTagsCheckedListBox(SelectedRecordItemsData[5], change_tags);
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
        private void PopulateTagsCheckedListBox(string inputString, CheckedListBox whichCLB)
        {
            // Split the input string into individual items using the comma as a separator
            string[] items = inputString.Split(',');

            // Uncheck all checkboxes in change_tags
            for (int i = 0; i < whichCLB.Items.Count; i++)
            {
                whichCLB.SetItemChecked(i, false);
            }

            // Iterate through the items and check the corresponding checkboxes in change_tags
            foreach (string item in items)
            {
                int index = whichCLB.FindStringExact(item); // Find the index of the item
                if (index != ListBox.NoMatches)
                {
                    // If the item is found in change_tags, check it
                    whichCLB.SetItemChecked(index, true);
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
                    Changes_Counter++;
                    ChangeSavedChangesStatus(false);
                    RefreshLastSearch();
                    ClearChangeFields();
                  
                }
            }
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
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
            RefreshLastSearch();
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
       
        private void searchButton_Click(object sender, EventArgs e)
        {
             
            tempSearch = new Search(search_name.Text,search_byName.Checked, search_byDev.Checked,search_byPublisher.Checked,search_bySeries.Checked,search_mustnotcontain.Text,search_indisks.Text,search_tags, Filter, DateTime.Now.ToString());
            SearchHistory.Add(tempSearch);
            SearchInRecords(tempSearch);
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
            if (selectedItems.Count() == 0) { return; }

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
                        RefreshDatabase_ListOfDisks(null, null);
                        ChangeSavedChangesStatus(false);

                        listView1.Items.Clear();
                        RefreshDisksGRoupBoxName();
                    }
                }

            }
            else
            {
                _ = new MessageForm("A disk must be selected first", 2).ShowDialog();
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

            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
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

            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
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

            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
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

            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
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

            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
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


            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
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

            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
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
            if (e.Alt && e.KeyCode == Keys.D)
            {
                DeleteRecord_Click(null,null);
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveAllChanges(null, null);
            }
            if (e.Alt && e.KeyCode == Keys.A)
            {
                AddRecords_Click(null, null);
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                data.Add(item.SubItems[0].Text);
            }
            if (data.Count > 0)
            {
                Clipboard.SetText(string.Join("\n", data));
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                TextBox focusedTextBox = (TextBox)this.ActiveControl;
                // Now, you have a reference to the focused TextBox.

                // You can access its properties or handle events, for example:
                string text = Clipboard.GetText();
                // Do something with the text...
                focusedTextBox.Text = text + focusedTextBox.Text;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                TextBox focusedTextBox = (TextBox)this.ActiveControl;
                // Now, you have a reference to the focused TextBox.

                // You can access its properties or handle events, for example:
                string text =  focusedTextBox.Text;
                 
                    if (!string.IsNullOrEmpty(text))
                    {
                    Clipboard.SetText(text);
                }
                
                
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                TextBox focusedTextBox = (TextBox)this.ActiveControl;
                string text = Clipboard.GetText();
                focusedTextBox.Text = focusedTextBox.Text + text;
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is TextBox)
            {
                TextBox focusedTextBox = (TextBox)this.ActiveControl;
                string text = Clipboard.GetText();
                focusedTextBox.Text = text;
            }
        }

        private void searchNameInGoogleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string term = listView1.SelectedItems[0].SubItems[0].Text;
                if (!string.IsNullOrEmpty(term))
                {
                    OpenDefaultBrowserWithGoogleSearch(term);
                }
            }
        }
        private void OpenDefaultBrowserWithGoogleSearch(string searchTerm)
        {
            try
            {
                // Encode the search term to make it URL-safe
                string encodedSearchTerm = Uri.EscapeDataString(searchTerm);

                // Construct the Google search URL
                string googleSearchUrl = $"https://www.google.com/search?q={encodedSearchTerm}";

                // Start the default web browser with the Google search URL
                Process.Start(googleSearchUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void list_disks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toggle1_Load(object sender, EventArgs e)
        {

        }
        
        private void series_NO_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);
        }

        private void series_PAS_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void series_YES_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void pub_NO_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void pub_PAS_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void pub_YES_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void dev_NO_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void dev_PAS_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void dev_YES_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void img_NO_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void img_PAS_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void img_YES_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void markAsBrokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }

            string title = change_name.Text.Trim();
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "broken";


            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title.ToLower() == currrentName.ToLower()) // if matching the name, found the record
                    {

                        records[currentDisk][i].Broken= true;
                        records[currentDisk][i].Missing = false;
                        updateCount++;
                        
                    }

                }
            }

            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s as {updateWhat}.", 1).ShowDialog();

            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
            ChangeSavedChangesStatus(false);
        }

        private void markAsMissingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }

            string title = change_name.Text.Trim();
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "missing";


            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                    {

                        records[currentDisk][i].Broken = false;
                        records[currentDisk][i].Missing = true;

                        updateCount++;
                    }

                }
            }

            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s as {updateWhat}.", 1).ShowDialog();

            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
            ChangeSavedChangesStatus(false);
        }

        private void markAsHealthyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) { _ = new MessageForm($"No record is selected from the list.", 2).ShowDialog(); return; }

            string title = change_name.Text.Trim();
            int allSelected = listView1.SelectedItems.Count;
            int updateCount = 0;
            string updateWhat = "healthy";


            foreach (int index in listView1.SelectedIndices)
            {
                string currrentName = listView1.Items[index].SubItems[0].Text;

                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                for (int i = 0; i < records[currentDisk].Count; i++)
                {
                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                    {

                        records[currentDisk][i].Broken = false;
                        records[currentDisk][i].Missing = false;
                        updateCount++;
                    }

                }
            }

            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s as {updateWhat}.", 1).ShowDialog();

            RefreshLastSearch();
            ClearChangeFields();
            Changes_Counter++;
            ChangeSavedChangesStatus(false);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           if (listView1.SelectedItems.Count == 1)
            {
                int disk = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                string name = listView1.SelectedItems[0].SubItems[0].Text;
                foreach (Record r in records[disk])
                {
                    if (r.Title == name)
                    {
                        MessageBox.Show($"Broken: {r.Broken}\nMissing: {r.Missing}");
                    }
                }
            } 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SEARCH_MISSING_PASS.Checked = true;
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SEARCH_BROKEN_PASS.Checked=true;
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void SEARCH_BROKEN_NO_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void SEARCH_BROKEN_PASS_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void groupBox25_Enter(object sender, EventArgs e)
        {

        }

        private void SEARCH_MISSING_NO_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void SEARCH_MISSING_PASS_CheckedChanged(object sender, EventArgs e)
        {
            Filter.setFilter(dev_NO, dev_PAS, dev_YES, pub_NO, pub_PAS, pub_YES, series_NO, series_PASS, series_YES, img_NO, img_PAS, img_YES, SEARCH_BROKEN_NO, SEARCH_BROKEN_PASS, SEARCH_BROKEN_YES, SEARCH_MISSING_NO, SEARCH_MISSING_PASS, SEARCH_MISSING_YES);

        }

        private void Search_Count_Click(object sender, EventArgs e)
        {
            searched_count = true;

            tempSearch = new Search(search_name.Text, search_byName.Checked, search_byDev.Checked, search_byPublisher.Checked, search_bySeries.Checked, search_mustnotcontain.Text, search_indisks.Text, search_tags, Filter, DateTime.Now.ToString());
            SearchHistory.Add(tempSearch);
            SearchInRecords(tempSearch);
        }

        private void label_countSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void label_countSearch_DoubleClick(object sender, EventArgs e)
        {
            label_countSearch.Text = string.Empty;
        }
        public void FillSearchFieldsFromSearch(Search search)
        {
            search_name.Text = search.Keywords;
            search_mustnotcontain.Text = search.ExcludedKeywords;
            search_indisks.Text = string.Join(",", search.Disks);
            search_byName.Checked = search.Search_ByDev;
            search_byDev.Checked = search.Search_ByDev;
            search_byPublisher.Checked = search.Search_ByPub;
            search_bySeries.Checked = search.Search_BySeries;
            string taglist = string.Join( ",",search.TagsList);

            PopulateTagsCheckedListBox(taglist, search_tags);
            series_NO.Checked = search.Filter.Search_Series ==-1? true: false;  
            series_PASS.Checked = search.Filter.Search_Series ==0? true: false;  
            series_YES.Checked = search.Filter.Search_Series ==1? true: false;  
            dev_NO.Checked = search.Filter.Search_Dev== -1? true: false;
            dev_PAS.Checked = search.Filter.Search_Dev== 0? true: false;
            dev_YES.Checked = search.Filter.Search_Dev== 1? true: false;
            pub_NO.Checked = search.Filter.Search_Pub == -1 ? true : false;
            pub_PAS.Checked = search.Filter.Search_Pub == 0 ? true : false;
            pub_YES.Checked = search.Filter.Search_Pub == 1 ? true : false;
            img_NO.Checked = search.Filter.Search_Image == -1 ? true : false;
            img_PAS.Checked = search.Filter.Search_Image == 0 ? true : false;
            img_YES.Checked = search.Filter.Search_Image == 1 ? true : false;

            SEARCH_BROKEN_NO.Checked = search.Filter.Search_Broken == -1 ? true : false;
            SEARCH_BROKEN_PASS.Checked = search.Filter.Search_Broken == 0 ? true : false;
            SEARCH_BROKEN_YES.Checked = search.Filter.Search_Broken == 1 ? true : false;

            SEARCH_MISSING_NO.Checked = search.Filter.Search_Missing == -1 ? true : false;
            SEARCH_MISSING_PASS.Checked = search.Filter.Search_Missing == 0 ? true : false;
            SEARCH_MISSING_YES.Checked = search.Filter.Search_Missing == 1 ? true : false;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            using (var v = new Search_History(SearchHistory))
            {
                v.ShowDialog();
                if ( v.DialogResult == DialogResult.OK )
                {
                    SearchHistory.Add(SearchHistory[v.SelectedSearchIndex]);
                    lastSearch = SearchHistory[v.SelectedSearchIndex];
                    FillSearchFieldsFromSearch(lastSearch);
                    SearchInRecords(lastSearch);
                }
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 1)
            {
                using (var v = new string_input())
                {
                    v.groupBox_newstring.Enabled = false;
                    v.ShowDialog();
                    int allSelected = listView1.SelectedItems.Count;
                    int updateCount = 0;
                    string updateWhat = "title";
                    if (v.DialogResult == DialogResult.OK)
                    {
                        string change = v.textBox_string.Text.Trim();
                        if (change.Length > 0)
                        {

                            foreach (int index in listView1.SelectedIndices)
                            {
                                string currrentName = listView1.Items[index].SubItems[0].Text;

                                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                                for (int i = 0; i < records[currentDisk].Count; i++)
                                {
                                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                                    {
                                        string title = records[currentDisk][i].Title;
                                        string newTitle = title.Replace(change, ""); ;
                                        records[currentDisk][i].Title = newTitle;


                                        updateCount++;
                                    }

                                }
                            }

                            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s as {updateWhat}.", 1).ShowDialog();

                            RefreshLastSearch();
                            ClearChangeFields();
                            Changes_Counter++;
                            ChangeSavedChangesStatus(false);
                        }
                    }
                }
            }
            else
            {
                _ = new MessageForm("At least 2 records must be selected for this command",2).ShowDialog();
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 1)
            {
                using (var v = new string_input())
                {
                    v.groupBox_newstring.Enabled = false;
                    v.ShowDialog();
                    int allSelected = listView1.SelectedItems.Count;
                    int updateCount = 0;
                    string updateWhat = "title";
                    if (v.DialogResult == DialogResult.OK)
                    {
                        string oldString = v.textBox_string.Text.Trim();
                        string newString = v.textBox_newstring.Text.Trim();
                        if (oldString.Length > 0 && newString.Length>0)
                        {

                            foreach (int index in listView1.SelectedIndices)
                            {
                                string currrentName = listView1.Items[index].SubItems[0].Text;

                                int currentDisk = Convert.ToInt32(listView1.Items[index].SubItems[1].Text);

                                for (int i = 0; i < records[currentDisk].Count; i++)
                                {
                                    if (records[currentDisk][i].Title == currrentName) // if matching the name, found the record
                                    {
                                        string title = records[currentDisk][i].Title;
                                        string newTitle = title.Replace(oldString, newString); ;
                                        records[currentDisk][i].Title = newTitle;


                                        updateCount++;
                                    }

                                }
                            }

                            _ = new MessageForm($"Updated {updateCount}/{allSelected} of the selected record/s as {updateWhat}.", 1).ShowDialog();

                            RefreshLastSearch();
                            ClearChangeFields();
                            Changes_Counter++;
                            ChangeSavedChangesStatus(false);
                        }
                    }
                }
            }
            else
            {
                _ = new MessageForm("At least 2 records must be selected for this command", 2).ShowDialog();
            }
        }
    }
    

}

