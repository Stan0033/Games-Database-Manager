﻿using System;
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
    public partial class changeValue : Form
    {
        public changeValue()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
