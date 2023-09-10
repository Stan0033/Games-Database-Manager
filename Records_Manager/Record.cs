using System;
using System.Collections.Generic;
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

        // Constructor
        public Record(string name,int disk, string series, string developer, string publisher, List<string> tags, string url)
        {
            Title = name;
            Disk = disk;
            Series = series;
            Developer = developer;
            Publisher = publisher;
            Tags = tags;
            ImageURL= url;
        }
        public ListViewItem getRow()
        {
            ListViewItem create = new ListViewItem();
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
