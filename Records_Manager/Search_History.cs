using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Records_Manager
{
    public partial class Search_History : Form
    {
        
        public Search_History(List<Search> searches)
        {
            InitializeComponent();
            SelectedSearch = null;
            Searches = new List<Search>();
            SelectedSearchIndex = 0;
            int count = 0;
            int gap = 15;
            foreach (Search s in searches)
            {
                count++;    
                RichTextBox t = new RichTextBox();
                t.Size = new Size(225, 190);
                int HPos = (225 * count + gap*count) - 220;
                t.Location = new Point(HPos, 10);
                t.ReadOnly = true;
                t.Cursor  = Cursors.Hand;
                t.Text = OrganizeData(s);
                t.MouseEnter += Search_MouseEnter;
                t.MouseLeave += Search_MouseEnter;
                t.MouseClick += Search_MouseClick;
                panel1.Controls.Add(t); 
            }
        }
        public RichTextBox SelectedSearch;
        List<Search> Searches;
        public int SelectedSearchIndex;
        private void Search_History_Load(object sender, EventArgs e)
        {

        }
        private string OrganizeData(Search s)
        {
            string result = string.Empty;
            StringBuilder b = new StringBuilder();
            b.AppendLine("Keyword/s (OR): "+ s.Keywords);
            b.AppendLine("Excluded Keyword/s (AND): "+ s.ExcludedKeywords);
            b.AppendLine("Search in: " + s.SearchByWhat());
            b.AppendLine(s.Filter.ToString());
            b.AppendLine("Disk/s (OR): "+string.Join(",",s.Disks));
            b.AppendLine("Tag/s (AND): "+string.Join(",",s.TagsList));
            b.AppendLine("Searched: " + s.Time);
            result = b.ToString();
            return result;
        }
        private void Search_MouseEnter(object sender, EventArgs e)
        {
            RichTextBox t = (RichTextBox)sender;
            t.BorderStyle = BorderStyle.Fixed3D;
        }
        private void Search_MouseLeave(object sender, EventArgs e)
        {
            RichTextBox t = (RichTextBox)sender;
            t.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Search_MouseClick(object sender, EventArgs e)
        {
            RichTextBox our = (RichTextBox)sender;
            int count = -1;
            foreach (RichTextBox r in panel1.Controls)
            {
                count++;
                if (r == our) { SelectedSearchIndex = count; }
                r.BackColor = Color.White;
            }
            our.BackColor = Color.DarkSeaGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.OK;
        }
    }
}
