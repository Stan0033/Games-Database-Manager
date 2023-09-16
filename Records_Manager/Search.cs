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
        public string Title { get; set; }
        public bool Search_ByTitle { get; set; }
        public bool Search_ByDev { get; set; }
        public bool Search_ByPub { get; set; }
        public bool Search_BySeries { get; set; }
        public string ExcludedContents { get; set; }
       
       public List<int> Disks { get; set; }
        public Search_Filter Filter { get; set; }
        public CheckedListBox Tags { get; set; }
        public Search(
       string title, bool byTitle, bool byDev, bool byPub, bool bySerie,
       string excludedContents, string indisks, CheckedListBox tags, Search_Filter filter)
        {
            Title = title;
            Search_ByTitle = byTitle;
            Search_ByDev = byDev;
            Search_ByPub = byPub;
            Search_BySeries = bySerie;
            ExcludedContents = excludedContents;

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
            Tags = tags;
            Filter = filter == null? new Search_Filter() : filter;
        }
    }
}
