using System;
using System.Collections.Generic;
using System.Linq;
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
        public string InDisks { get; set; }
        public CheckedListBox Tags { get; set; }
        public Search(
       string title, bool byTitle, bool byDev, bool byPub, bool bySerie,
       string excludedContents, string inDisks, CheckedListBox tags)
        {
            Title = title;
            Search_ByTitle = byTitle;
            Search_ByDev = byDev;
            Search_ByPub = byPub;
            Search_BySeries = bySerie;
            ExcludedContents = excludedContents;
            InDisks = inDisks;
            Tags = tags;
        }
    }
}
