using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Records_Manager
{
    public partial class Existing_Records : Form
    {
        public Existing_Records()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string all = string.Empty;
            foreach (var item in listBox1.Items)
            {
                all += item.ToString() + "\n";
            }
            Clipboard.SetText(all);
        }
    }
}
