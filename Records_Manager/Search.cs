using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Records_Manager
{
    public class Search
    {
        public string Keywords { get; set; }
        public bool Search_ByTitle { get; set; }
        public bool Search_ByDev { get; set; }
        public bool Search_ByPub { get; set; }
        public bool Search_BySeries { get; set; }
        public string ExcludedKeywords { get; set; }
       
       public List<int> Disks { get; set; }
        public Search_Filter Filter { get; set; }
        public CheckedListBox Tags { get; set; }
        public List<string> TagsList { get; set; }  
        public string Time { get; set; }   
        public string SearchByWhat()
        {
            string result = string.Empty;
            if (Search_ByTitle == true) { result = "title"; }
            if (Search_ByDev == true) { result = "developer"; }
            if (Search_ByPub == true) { result = "publisher"; }
            if (Search_BySeries == true) { result = "series"; }
            return result;
        }
        public Search(
       string title, bool byTitle, bool byDev, bool byPub, bool bySerie,
       string excludedContents, string indisks, CheckedListBox tags, Search_Filter filter, string time)
        {
            Keywords = title;
            Search_ByTitle = byTitle;
            Search_ByDev = byDev;
            Search_ByPub = byPub;
            Search_BySeries = bySerie;
            ExcludedKeywords = excludedContents;
            Time = time;
            // Disks =  indisks.Split(',').Select(i => int.Parse(i.Trim())).ToList();
            Disks = new List<int>();
            foreach (string disk in indisks.Split(','))
            {
                if (int.TryParse(disk.Trim(), out int result))
                {
                    Disks.Add(result);
                }
                else
                {
                    // Handle the case where parsing fails (e.g., log an error, display a message, or take appropriate action)
                }
            }
            TagsList = new List<string>();
            TagsList = GetCheckedItemsNames(tags);
            Tags = tags;
            
            Filter = filter == null? new Search_Filter() : filter;
            
        }
        private static List<string> GetCheckedItemsNames(CheckedListBox checkedListBox)
        {
            if (checkedListBox == null) { return new List<string>(); }
            List<string> checkedItemNames = new List<string>();

            foreach (var item in checkedListBox.CheckedItems)
            {
                if (item is string itemName)
                {
                    checkedItemNames.Add(itemName);
                }
            }

            return checkedItemNames;
        }
    }
}
