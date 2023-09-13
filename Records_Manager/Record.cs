using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Records_Manager
{
    public class Record
    {
        public string Title { get; set; }
        public int Disk { get; set; }
        public string Series { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public List<string> Tags { get; set; }
        public string ImageURL { get; set; }
        public int ReleaseYear { get; set; }
        public string Platform { get; set; }
        public string Link_Steam { get; set; }
        public string Link_Wiki { get; set; }
        public double SizeOnDisk { get; set; }
        

        // Constructor
        public Record(string name,int disk, string series, string developer, string publisher, List<string> tags, string url, double sizeOnDisk= 0,string platform = "", string link_steam="", string link_wiki="",int releaseYear=0  )
        {
            Title = name;
            Disk = disk;
            Series = series;
            Developer = developer;
            Publisher = publisher;
            Tags = tags;
            ImageURL= url;
            ReleaseYear = releaseYear;
            Platform = platform;
            Link_Steam = link_steam;
            Link_Wiki = link_wiki;
            SizeOnDisk = sizeOnDisk;
        }
        public ListViewItem getRow()
        {
            ListViewItem create = new ListViewItem();
            if (ImageURL.Length > 3) { create.ForeColor = Color.Gold; }
            Series = Series == string.Empty ? " " : Series;
            Developer = Developer == string.Empty ? " " : Developer;
            Publisher = Publisher == string.Empty ? " " : Publisher;
            ImageURL = ImageURL == string.Empty ? " " : ImageURL;
            create.Text= Title;
            create.SubItems.Add(Disk.ToString());
            create.SubItems.Add(Series);
            create.SubItems.Add(Developer);
            create.SubItems.Add(Publisher);
            create.SubItems.Add(string.Join(",", Tags));
            create.SubItems.Add(ImageURL);
            
            
            return create;
        }
        public string ToString()
        {
            Series = Series == string.Empty ? " " : Series;
            Developer = Developer == string.Empty ? " " : Developer;
            Publisher = Publisher == string.Empty ? " " : Publisher;
            ImageURL = ImageURL == string.Empty ? " " : ImageURL;

            // Clean each tag to remove newline characters
            List<string> cleanedTags = Tags.Select(tag => tag.Replace("\n", "").Replace("\r", "")).ToList();

            string tagsJoined = string.Join(",", cleanedTags);

            return $"[{Title}|{Disk}|{Series}|{Developer}|{Publisher}|{tagsJoined}|{ImageURL}]";
        }
        

    }
   

}
