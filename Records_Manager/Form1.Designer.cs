using System.Windows.Forms;

namespace Records_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox_disks = new System.Windows.Forms.GroupBox();
            this.list_disks = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.menu_search = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.label_countSearch = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.label_countResuults = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.SEARCH_MISSING_YES = new System.Windows.Forms.RadioButton();
            this.SEARCH_MISSING_PASS = new System.Windows.Forms.RadioButton();
            this.SEARCH_MISSING_NO = new System.Windows.Forms.RadioButton();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.SEARCH_BROKEN_YES = new System.Windows.Forms.RadioButton();
            this.SEARCH_BROKEN_PASS = new System.Windows.Forms.RadioButton();
            this.SEARCH_BROKEN_NO = new System.Windows.Forms.RadioButton();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.img_YES = new System.Windows.Forms.RadioButton();
            this.img_PAS = new System.Windows.Forms.RadioButton();
            this.img_NO = new System.Windows.Forms.RadioButton();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.pub_YES = new System.Windows.Forms.RadioButton();
            this.pub_PAS = new System.Windows.Forms.RadioButton();
            this.pub_NO = new System.Windows.Forms.RadioButton();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.dev_YES = new System.Windows.Forms.RadioButton();
            this.dev_PAS = new System.Windows.Forms.RadioButton();
            this.dev_NO = new System.Windows.Forms.RadioButton();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.series_YES = new System.Windows.Forms.RadioButton();
            this.series_PASS = new System.Windows.Forms.RadioButton();
            this.series_NO = new System.Windows.Forms.RadioButton();
            this.groupBox_tags_search = new System.Windows.Forms.GroupBox();
            this.search_tags = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.search_indisks = new System.Windows.Forms.TextBox();
            this.menu_textb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search_mustnotcontain = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.search_byPublisher = new System.Windows.Forms.RadioButton();
            this.search_byName = new System.Windows.Forms.RadioButton();
            this.search_byDev = new System.Windows.Forms.RadioButton();
            this.search_bySeries = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.add_action_options = new System.Windows.Forms.CheckedListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.add_url = new System.Windows.Forms.TextBox();
            this.groupBox_tags_add = new System.Windows.Forms.GroupBox();
            this.add_tags = new System.Windows.Forms.CheckedListBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.add_Publisher = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.add_Developer = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.add_Disk = new System.Windows.Forms.NumericUpDown();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.add_Series = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.add_Names = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menu_change = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.changeSeriesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.changeDiskOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.changeDeveloperOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.changePublisherOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changeTagsOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeImageOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.markAsBrokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.markAsMissingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.markAsHealthyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.change_url = new System.Windows.Forms.TextBox();
            this.change_groupBox_tags = new System.Windows.Forms.GroupBox();
            this.change_tags = new System.Windows.Forms.CheckedListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.change_pub = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.change_dev = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.change_disk = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.change_series = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.change_name = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectInverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchNameInGoogleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_Header = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel_search_results = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox_disks.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.menu_search.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox_tags_search.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menu_textb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox_tags_add.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_Disk)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.menu_change.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.change_groupBox_tags.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_disk)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Header)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_search_results.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 215);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 796);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.button13);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.groupBox_disks);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(452, 758);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Database";
            this.toolTip1.SetToolTip(this.tabPage3, "Alt+1");
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(0, 444);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(452, 49);
            this.button13.TabIndex = 9;
            this.button13.Text = "Change disk number";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.changeDiskNumber_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(0, 682);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(452, 38);
            this.button11.TabIndex = 8;
            this.button11.Text = "Delete Disk";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.DeleteDisk);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 395);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(452, 49);
            this.button10.TabIndex = 7;
            this.button10.Text = "Refresh List";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RefreshDatabase_ListOfDisks);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 346);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(452, 49);
            this.button9.TabIndex = 6;
            this.button9.Text = "View All";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ViewDisks);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 297);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(452, 49);
            this.button8.TabIndex = 5;
            this.button8.Text = "View";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ViewDisk);
            // 
            // groupBox_disks
            // 
            this.groupBox_disks.Controls.Add(this.list_disks);
            this.groupBox_disks.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_disks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_disks.Location = new System.Drawing.Point(0, 98);
            this.groupBox_disks.Name = "groupBox_disks";
            this.groupBox_disks.Size = new System.Drawing.Size(452, 199);
            this.groupBox_disks.TabIndex = 4;
            this.groupBox_disks.TabStop = false;
            this.groupBox_disks.Text = "Disks: 0, records: - 0";
            // 
            // list_disks
            // 
            this.list_disks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_disks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_disks.FormattingEnabled = true;
            this.list_disks.ItemHeight = 20;
            this.list_disks.Location = new System.Drawing.Point(3, 27);
            this.list_disks.Name = "list_disks";
            this.list_disks.Size = new System.Drawing.Size(446, 169);
            this.list_disks.TabIndex = 3;
            this.list_disks.SelectedIndexChanged += new System.EventHandler(this.list_disks_SelectedIndexChanged);
            this.list_disks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_disks_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 720);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(452, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Discard Database";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DiscardDatabase);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Cyan;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 49);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(452, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save All Changes";
            this.toolTip1.SetToolTip(this.button2, "Alt+S");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveAllChanges);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(452, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadDatabase);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.groupBox28);
            this.tabPage1.Controls.Add(this.groupBox27);
            this.tabPage1.Controls.Add(this.groupBox26);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox_tags_search);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox19);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 758);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.toolTip1.SetToolTip(this.tabPage1, "Alt+2");
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.button15);
            this.groupBox28.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox28.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox28.Location = new System.Drawing.Point(3, 674);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(446, 65);
            this.groupBox28.TabIndex = 25;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Search History";
            // 
            // button15
            // 
            this.button15.ContextMenuStrip = this.menu_search;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.ForeColor = System.Drawing.Color.Silver;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(3, 22);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(440, 40);
            this.button15.TabIndex = 18;
            this.button15.Text = "Browse";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // menu_search
            // 
            this.menu_search.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10});
            this.menu_search.Name = "contextMenuStrip1";
            this.menu_search.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu_search.Size = new System.Drawing.Size(205, 38);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(204, 34);
            this.toolStripMenuItem10.Text = "Search Count";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.Search_Count_Click);
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.label_countSearch);
            this.groupBox27.Controls.Add(this.button14);
            this.groupBox27.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox27.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox27.Location = new System.Drawing.Point(3, 583);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(446, 91);
            this.groupBox27.TabIndex = 24;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Search Count";
            // 
            // label_countSearch
            // 
            this.label_countSearch.AutoSize = true;
            this.label_countSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_countSearch.Location = new System.Drawing.Point(3, 62);
            this.label_countSearch.Name = "label_countSearch";
            this.label_countSearch.Size = new System.Drawing.Size(18, 20);
            this.label_countSearch.TabIndex = 20;
            this.label_countSearch.Text = "_";
            // 
            // button14
            // 
            this.button14.ContextMenuStrip = this.menu_search;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.ForeColor = System.Drawing.Color.Silver;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 22);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(440, 40);
            this.button14.TabIndex = 18;
            this.button14.Text = "Search Count";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Search_Count_Click);
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.label_countResuults);
            this.groupBox26.Controls.Add(this.button12);
            this.groupBox26.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox26.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox26.Location = new System.Drawing.Point(3, 492);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(446, 91);
            this.groupBox26.TabIndex = 23;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Search";
            // 
            // label_countResuults
            // 
            this.label_countResuults.AutoSize = true;
            this.label_countResuults.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_countResuults.Location = new System.Drawing.Point(3, 62);
            this.label_countResuults.Name = "label_countResuults";
            this.label_countResuults.Size = new System.Drawing.Size(18, 20);
            this.label_countResuults.TabIndex = 20;
            this.label_countResuults.Text = "_";
            // 
            // button12
            // 
            this.button12.ContextMenuStrip = this.menu_search;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(3, 22);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(440, 40);
            this.button12.TabIndex = 18;
            this.button12.Text = "Search";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox9.Controls.Add(this.groupBox25);
            this.groupBox9.Controls.Add(this.groupBox24);
            this.groupBox9.Controls.Add(this.groupBox23);
            this.groupBox9.Controls.Add(this.groupBox20);
            this.groupBox9.Controls.Add(this.groupBox17);
            this.groupBox9.Controls.Add(this.groupBox15);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox9.Location = new System.Drawing.Point(3, 382);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(446, 110);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Additional Filters (Must NOT Have, Neutral, Must Have)";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.SEARCH_MISSING_YES);
            this.groupBox25.Controls.Add(this.SEARCH_MISSING_PASS);
            this.groupBox25.Controls.Add(this.SEARCH_MISSING_NO);
            this.groupBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox25.ForeColor = System.Drawing.Color.White;
            this.groupBox25.Location = new System.Drawing.Point(10, 66);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(76, 38);
            this.groupBox25.TabIndex = 9;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Missing";
            this.groupBox25.Enter += new System.EventHandler(this.groupBox25_Enter);
            // 
            // SEARCH_MISSING_YES
            // 
            this.SEARCH_MISSING_YES.AutoSize = true;
            this.SEARCH_MISSING_YES.Location = new System.Drawing.Point(46, 19);
            this.SEARCH_MISSING_YES.Name = "SEARCH_MISSING_YES";
            this.SEARCH_MISSING_YES.Size = new System.Drawing.Size(14, 13);
            this.SEARCH_MISSING_YES.TabIndex = 2;
            this.SEARCH_MISSING_YES.UseVisualStyleBackColor = true;
            this.SEARCH_MISSING_YES.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // SEARCH_MISSING_PASS
            // 
            this.SEARCH_MISSING_PASS.AutoSize = true;
            this.SEARCH_MISSING_PASS.Checked = true;
            this.SEARCH_MISSING_PASS.Location = new System.Drawing.Point(26, 19);
            this.SEARCH_MISSING_PASS.Name = "SEARCH_MISSING_PASS";
            this.SEARCH_MISSING_PASS.Size = new System.Drawing.Size(14, 13);
            this.SEARCH_MISSING_PASS.TabIndex = 1;
            this.SEARCH_MISSING_PASS.TabStop = true;
            this.SEARCH_MISSING_PASS.UseVisualStyleBackColor = true;
            this.SEARCH_MISSING_PASS.CheckedChanged += new System.EventHandler(this.SEARCH_MISSING_PASS_CheckedChanged);
            // 
            // SEARCH_MISSING_NO
            // 
            this.SEARCH_MISSING_NO.AutoSize = true;
            this.SEARCH_MISSING_NO.Location = new System.Drawing.Point(6, 19);
            this.SEARCH_MISSING_NO.Name = "SEARCH_MISSING_NO";
            this.SEARCH_MISSING_NO.Size = new System.Drawing.Size(14, 13);
            this.SEARCH_MISSING_NO.TabIndex = 0;
            this.SEARCH_MISSING_NO.UseVisualStyleBackColor = true;
            this.SEARCH_MISSING_NO.CheckedChanged += new System.EventHandler(this.SEARCH_MISSING_NO_CheckedChanged);
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.SEARCH_BROKEN_YES);
            this.groupBox24.Controls.Add(this.SEARCH_BROKEN_PASS);
            this.groupBox24.Controls.Add(this.SEARCH_BROKEN_NO);
            this.groupBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox24.ForeColor = System.Drawing.Color.White;
            this.groupBox24.Location = new System.Drawing.Point(338, 21);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(76, 38);
            this.groupBox24.TabIndex = 8;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Broken";
            // 
            // SEARCH_BROKEN_YES
            // 
            this.SEARCH_BROKEN_YES.AutoSize = true;
            this.SEARCH_BROKEN_YES.Location = new System.Drawing.Point(46, 19);
            this.SEARCH_BROKEN_YES.Name = "SEARCH_BROKEN_YES";
            this.SEARCH_BROKEN_YES.Size = new System.Drawing.Size(14, 13);
            this.SEARCH_BROKEN_YES.TabIndex = 2;
            this.SEARCH_BROKEN_YES.UseVisualStyleBackColor = true;
            this.SEARCH_BROKEN_YES.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SEARCH_BROKEN_PASS
            // 
            this.SEARCH_BROKEN_PASS.AutoSize = true;
            this.SEARCH_BROKEN_PASS.Checked = true;
            this.SEARCH_BROKEN_PASS.Location = new System.Drawing.Point(26, 19);
            this.SEARCH_BROKEN_PASS.Name = "SEARCH_BROKEN_PASS";
            this.SEARCH_BROKEN_PASS.Size = new System.Drawing.Size(14, 13);
            this.SEARCH_BROKEN_PASS.TabIndex = 1;
            this.SEARCH_BROKEN_PASS.TabStop = true;
            this.SEARCH_BROKEN_PASS.UseVisualStyleBackColor = true;
            this.SEARCH_BROKEN_PASS.CheckedChanged += new System.EventHandler(this.SEARCH_BROKEN_PASS_CheckedChanged);
            // 
            // SEARCH_BROKEN_NO
            // 
            this.SEARCH_BROKEN_NO.AutoSize = true;
            this.SEARCH_BROKEN_NO.Location = new System.Drawing.Point(6, 19);
            this.SEARCH_BROKEN_NO.Name = "SEARCH_BROKEN_NO";
            this.SEARCH_BROKEN_NO.Size = new System.Drawing.Size(14, 13);
            this.SEARCH_BROKEN_NO.TabIndex = 0;
            this.SEARCH_BROKEN_NO.UseVisualStyleBackColor = true;
            this.SEARCH_BROKEN_NO.CheckedChanged += new System.EventHandler(this.SEARCH_BROKEN_NO_CheckedChanged);
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.img_YES);
            this.groupBox23.Controls.Add(this.img_PAS);
            this.groupBox23.Controls.Add(this.img_NO);
            this.groupBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox23.ForeColor = System.Drawing.Color.White;
            this.groupBox23.Location = new System.Drawing.Point(256, 21);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(76, 38);
            this.groupBox23.TabIndex = 7;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Image";
            // 
            // img_YES
            // 
            this.img_YES.AutoSize = true;
            this.img_YES.Location = new System.Drawing.Point(46, 19);
            this.img_YES.Name = "img_YES";
            this.img_YES.Size = new System.Drawing.Size(14, 13);
            this.img_YES.TabIndex = 2;
            this.img_YES.UseVisualStyleBackColor = true;
            this.img_YES.CheckedChanged += new System.EventHandler(this.img_YES_CheckedChanged);
            // 
            // img_PAS
            // 
            this.img_PAS.AutoSize = true;
            this.img_PAS.Checked = true;
            this.img_PAS.Location = new System.Drawing.Point(26, 19);
            this.img_PAS.Name = "img_PAS";
            this.img_PAS.Size = new System.Drawing.Size(14, 13);
            this.img_PAS.TabIndex = 1;
            this.img_PAS.TabStop = true;
            this.img_PAS.UseVisualStyleBackColor = true;
            this.img_PAS.CheckedChanged += new System.EventHandler(this.img_PAS_CheckedChanged);
            // 
            // img_NO
            // 
            this.img_NO.AutoSize = true;
            this.img_NO.Location = new System.Drawing.Point(6, 19);
            this.img_NO.Name = "img_NO";
            this.img_NO.Size = new System.Drawing.Size(14, 13);
            this.img_NO.TabIndex = 0;
            this.img_NO.UseVisualStyleBackColor = true;
            this.img_NO.CheckedChanged += new System.EventHandler(this.img_NO_CheckedChanged);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.pub_YES);
            this.groupBox20.Controls.Add(this.pub_PAS);
            this.groupBox20.Controls.Add(this.pub_NO);
            this.groupBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox20.ForeColor = System.Drawing.Color.White;
            this.groupBox20.Location = new System.Drawing.Point(92, 21);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(76, 38);
            this.groupBox20.TabIndex = 6;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Publisher";
            // 
            // pub_YES
            // 
            this.pub_YES.AutoSize = true;
            this.pub_YES.Location = new System.Drawing.Point(46, 19);
            this.pub_YES.Name = "pub_YES";
            this.pub_YES.Size = new System.Drawing.Size(14, 13);
            this.pub_YES.TabIndex = 2;
            this.pub_YES.UseVisualStyleBackColor = true;
            this.pub_YES.CheckedChanged += new System.EventHandler(this.pub_YES_CheckedChanged);
            // 
            // pub_PAS
            // 
            this.pub_PAS.AutoSize = true;
            this.pub_PAS.Checked = true;
            this.pub_PAS.Location = new System.Drawing.Point(26, 19);
            this.pub_PAS.Name = "pub_PAS";
            this.pub_PAS.Size = new System.Drawing.Size(14, 13);
            this.pub_PAS.TabIndex = 1;
            this.pub_PAS.TabStop = true;
            this.pub_PAS.UseVisualStyleBackColor = true;
            this.pub_PAS.CheckedChanged += new System.EventHandler(this.pub_PAS_CheckedChanged);
            // 
            // pub_NO
            // 
            this.pub_NO.AutoSize = true;
            this.pub_NO.Location = new System.Drawing.Point(6, 19);
            this.pub_NO.Name = "pub_NO";
            this.pub_NO.Size = new System.Drawing.Size(14, 13);
            this.pub_NO.TabIndex = 0;
            this.pub_NO.UseVisualStyleBackColor = true;
            this.pub_NO.CheckedChanged += new System.EventHandler(this.pub_NO_CheckedChanged);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.dev_YES);
            this.groupBox17.Controls.Add(this.dev_PAS);
            this.groupBox17.Controls.Add(this.dev_NO);
            this.groupBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox17.ForeColor = System.Drawing.Color.White;
            this.groupBox17.Location = new System.Drawing.Point(174, 21);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(76, 38);
            this.groupBox17.TabIndex = 6;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Developer";
            // 
            // dev_YES
            // 
            this.dev_YES.AutoSize = true;
            this.dev_YES.Location = new System.Drawing.Point(46, 19);
            this.dev_YES.Name = "dev_YES";
            this.dev_YES.Size = new System.Drawing.Size(14, 13);
            this.dev_YES.TabIndex = 2;
            this.dev_YES.UseVisualStyleBackColor = true;
            this.dev_YES.CheckedChanged += new System.EventHandler(this.dev_YES_CheckedChanged);
            // 
            // dev_PAS
            // 
            this.dev_PAS.AutoSize = true;
            this.dev_PAS.Checked = true;
            this.dev_PAS.Location = new System.Drawing.Point(26, 19);
            this.dev_PAS.Name = "dev_PAS";
            this.dev_PAS.Size = new System.Drawing.Size(14, 13);
            this.dev_PAS.TabIndex = 1;
            this.dev_PAS.TabStop = true;
            this.dev_PAS.UseVisualStyleBackColor = true;
            this.dev_PAS.CheckedChanged += new System.EventHandler(this.dev_PAS_CheckedChanged);
            // 
            // dev_NO
            // 
            this.dev_NO.AutoSize = true;
            this.dev_NO.Location = new System.Drawing.Point(6, 19);
            this.dev_NO.Name = "dev_NO";
            this.dev_NO.Size = new System.Drawing.Size(14, 13);
            this.dev_NO.TabIndex = 0;
            this.dev_NO.UseVisualStyleBackColor = true;
            this.dev_NO.CheckedChanged += new System.EventHandler(this.dev_NO_CheckedChanged);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.series_YES);
            this.groupBox15.Controls.Add(this.series_PASS);
            this.groupBox15.Controls.Add(this.series_NO);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox15.ForeColor = System.Drawing.Color.White;
            this.groupBox15.Location = new System.Drawing.Point(10, 21);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(76, 38);
            this.groupBox15.TabIndex = 5;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Series";
            // 
            // series_YES
            // 
            this.series_YES.AutoSize = true;
            this.series_YES.Location = new System.Drawing.Point(46, 19);
            this.series_YES.Name = "series_YES";
            this.series_YES.Size = new System.Drawing.Size(14, 13);
            this.series_YES.TabIndex = 2;
            this.series_YES.UseVisualStyleBackColor = true;
            this.series_YES.CheckedChanged += new System.EventHandler(this.series_YES_CheckedChanged);
            // 
            // series_PASS
            // 
            this.series_PASS.AutoSize = true;
            this.series_PASS.Checked = true;
            this.series_PASS.Location = new System.Drawing.Point(26, 19);
            this.series_PASS.Name = "series_PASS";
            this.series_PASS.Size = new System.Drawing.Size(14, 13);
            this.series_PASS.TabIndex = 1;
            this.series_PASS.TabStop = true;
            this.series_PASS.UseVisualStyleBackColor = true;
            this.series_PASS.CheckedChanged += new System.EventHandler(this.series_PAS_CheckedChanged);
            // 
            // series_NO
            // 
            this.series_NO.AutoSize = true;
            this.series_NO.Location = new System.Drawing.Point(6, 19);
            this.series_NO.Name = "series_NO";
            this.series_NO.Size = new System.Drawing.Size(14, 13);
            this.series_NO.TabIndex = 0;
            this.series_NO.UseVisualStyleBackColor = true;
            this.series_NO.CheckedChanged += new System.EventHandler(this.series_NO_CheckedChanged);
            // 
            // groupBox_tags_search
            // 
            this.groupBox_tags_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox_tags_search.Controls.Add(this.search_tags);
            this.groupBox_tags_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_tags_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_tags_search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_tags_search.Location = new System.Drawing.Point(3, 284);
            this.groupBox_tags_search.Name = "groupBox_tags_search";
            this.groupBox_tags_search.Size = new System.Drawing.Size(446, 98);
            this.groupBox_tags_search.TabIndex = 17;
            this.groupBox_tags_search.TabStop = false;
            this.groupBox_tags_search.Text = "Tags";
            // 
            // search_tags
            // 
            this.search_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_tags.FormattingEnabled = true;
            this.search_tags.Location = new System.Drawing.Point(3, 22);
            this.search_tags.Name = "search_tags";
            this.search_tags.Size = new System.Drawing.Size(440, 73);
            this.search_tags.TabIndex = 0;
            this.search_tags.SelectedIndexChanged += new System.EventHandler(this.search_tags_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.search_indisks);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(3, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 46);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "In Disk/s (OR)";
            // 
            // search_indisks
            // 
            this.search_indisks.ContextMenuStrip = this.menu_textb;
            this.search_indisks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_indisks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_indisks.Location = new System.Drawing.Point(3, 25);
            this.search_indisks.MaxLength = 150;
            this.search_indisks.Name = "search_indisks";
            this.search_indisks.Size = new System.Drawing.Size(440, 26);
            this.search_indisks.TabIndex = 0;
            // 
            // menu_textb
            // 
            this.menu_textb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.menu_textb.Name = "contextMenuStrip1";
            this.menu_textb.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu_textb.Size = new System.Drawing.Size(213, 140);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(212, 34);
            this.toolStripMenuItem3.Text = "Copy Field";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(212, 34);
            this.toolStripMenuItem4.Text = "Paste Append";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(212, 34);
            this.toolStripMenuItem5.Text = "Paste Prepend";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(212, 34);
            this.toolStripMenuItem6.Text = "Clear + Paste";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.search_mustnotcontain);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(3, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 49);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Must NOT Contain (AND)";
            // 
            // search_mustnotcontain
            // 
            this.search_mustnotcontain.ContextMenuStrip = this.menu_textb;
            this.search_mustnotcontain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_mustnotcontain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_mustnotcontain.Location = new System.Drawing.Point(3, 22);
            this.search_mustnotcontain.MaxLength = 150;
            this.search_mustnotcontain.Name = "search_mustnotcontain";
            this.search_mustnotcontain.Size = new System.Drawing.Size(440, 26);
            this.search_mustnotcontain.TabIndex = 1;
            // 
            // groupBox19
            // 
            this.groupBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox19.Controls.Add(this.search_byPublisher);
            this.groupBox19.Controls.Add(this.search_byName);
            this.groupBox19.Controls.Add(this.search_byDev);
            this.groupBox19.Controls.Add(this.search_bySeries);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox19.Location = new System.Drawing.Point(3, 52);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(446, 137);
            this.groupBox19.TabIndex = 9;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Search in";
            // 
            // search_byPublisher
            // 
            this.search_byPublisher.AutoSize = true;
            this.search_byPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_byPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_byPublisher.Location = new System.Drawing.Point(6, 78);
            this.search_byPublisher.Name = "search_byPublisher";
            this.search_byPublisher.Size = new System.Drawing.Size(92, 24);
            this.search_byPublisher.TabIndex = 3;
            this.search_byPublisher.Text = "Publisher";
            this.search_byPublisher.UseVisualStyleBackColor = true;
            // 
            // search_byName
            // 
            this.search_byName.AutoSize = true;
            this.search_byName.Checked = true;
            this.search_byName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_byName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_byName.Location = new System.Drawing.Point(6, 18);
            this.search_byName.Name = "search_byName";
            this.search_byName.Size = new System.Drawing.Size(56, 24);
            this.search_byName.TabIndex = 1;
            this.search_byName.TabStop = true;
            this.search_byName.Text = "Title";
            this.search_byName.UseVisualStyleBackColor = true;
            // 
            // search_byDev
            // 
            this.search_byDev.AutoSize = true;
            this.search_byDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_byDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_byDev.Location = new System.Drawing.Point(6, 48);
            this.search_byDev.Name = "search_byDev";
            this.search_byDev.Size = new System.Drawing.Size(99, 24);
            this.search_byDev.TabIndex = 2;
            this.search_byDev.Text = "Developer";
            this.search_byDev.UseVisualStyleBackColor = true;
            // 
            // search_bySeries
            // 
            this.search_bySeries.AutoSize = true;
            this.search_bySeries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_bySeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_bySeries.Location = new System.Drawing.Point(6, 108);
            this.search_bySeries.Name = "search_bySeries";
            this.search_bySeries.Size = new System.Drawing.Size(72, 24);
            this.search_bySeries.TabIndex = 4;
            this.search_bySeries.Text = "Series";
            this.search_bySeries.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.search_name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 49);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keywords (OR)";
            // 
            // search_name
            // 
            this.search_name.ContextMenuStrip = this.menu_textb;
            this.search_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_name.Location = new System.Drawing.Point(3, 22);
            this.search_name.MaxLength = 150;
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(440, 26);
            this.search_name.TabIndex = 8;
            this.toolTip1.SetToolTip(this.search_name, "Enter");
            this.search_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchRecords_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.groupBox16);
            this.tabPage2.Controls.Add(this.groupBox21);
            this.tabPage2.Controls.Add(this.groupBox_tags_add);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox13);
            this.tabPage2.Controls.Add(this.groupBox14);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 758);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New";
            this.toolTip1.SetToolTip(this.tabPage2, "Alt+3");
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.add_action_options);
            this.groupBox16.Controls.Add(this.button7);
            this.groupBox16.Controls.Add(this.button6);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox16.Location = new System.Drawing.Point(3, 399);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(446, 356);
            this.groupBox16.TabIndex = 19;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Actions";
            // 
            // add_action_options
            // 
            this.add_action_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_action_options.FormattingEnabled = true;
            this.add_action_options.Items.AddRange(new object[] {
            "Get Folders",
            "Get Files",
            "Exclude Hidden",
            "Exclude Extensions",
            "Get Sub-folder items"});
            this.add_action_options.Location = new System.Drawing.Point(3, 104);
            this.add_action_options.Name = "add_action_options";
            this.add_action_options.Size = new System.Drawing.Size(440, 249);
            this.add_action_options.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 63);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(440, 41);
            this.button7.TabIndex = 1;
            this.button7.Text = "Add";
            this.toolTip1.SetToolTip(this.button7, "Alt+A");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AddRecords_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(440, 41);
            this.button6.TabIndex = 0;
            this.button6.Text = "Get from Folder";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BrowseFolder_Click);
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.add_url);
            this.groupBox21.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox21.Location = new System.Drawing.Point(3, 353);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(446, 46);
            this.groupBox21.TabIndex = 18;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Image URL (460x215)";
            // 
            // add_url
            // 
            this.add_url.ContextMenuStrip = this.menu_textb;
            this.add_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_url.Location = new System.Drawing.Point(3, 22);
            this.add_url.Name = "add_url";
            this.add_url.Size = new System.Drawing.Size(440, 26);
            this.add_url.TabIndex = 1;
            // 
            // groupBox_tags_add
            // 
            this.groupBox_tags_add.Controls.Add(this.add_tags);
            this.groupBox_tags_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_tags_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_tags_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox_tags_add.Location = new System.Drawing.Point(3, 259);
            this.groupBox_tags_add.Name = "groupBox_tags_add";
            this.groupBox_tags_add.Size = new System.Drawing.Size(446, 94);
            this.groupBox_tags_add.TabIndex = 16;
            this.groupBox_tags_add.TabStop = false;
            this.groupBox_tags_add.Text = "Tags*";
            // 
            // add_tags
            // 
            this.add_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_tags.FormattingEnabled = true;
            this.add_tags.Location = new System.Drawing.Point(3, 22);
            this.add_tags.Name = "add_tags";
            this.add_tags.Size = new System.Drawing.Size(440, 69);
            this.add_tags.TabIndex = 0;
            this.add_tags.SelectedIndexChanged += new System.EventHandler(this.add_tags_SelectedIndexChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.add_Publisher);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox10.Location = new System.Drawing.Point(3, 213);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(446, 46);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Publisher";
            // 
            // add_Publisher
            // 
            this.add_Publisher.ContextMenuStrip = this.menu_textb;
            this.add_Publisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_Publisher.Location = new System.Drawing.Point(3, 22);
            this.add_Publisher.Name = "add_Publisher";
            this.add_Publisher.Size = new System.Drawing.Size(440, 26);
            this.add_Publisher.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.add_Developer);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox11.Location = new System.Drawing.Point(3, 167);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(446, 46);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Developer";
            // 
            // add_Developer
            // 
            this.add_Developer.ContextMenuStrip = this.menu_textb;
            this.add_Developer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_Developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_Developer.Location = new System.Drawing.Point(3, 22);
            this.add_Developer.Name = "add_Developer";
            this.add_Developer.Size = new System.Drawing.Size(440, 26);
            this.add_Developer.TabIndex = 1;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.add_Disk);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox12.Location = new System.Drawing.Point(3, 121);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(446, 46);
            this.groupBox12.TabIndex = 13;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Disk*";
            // 
            // add_Disk
            // 
            this.add_Disk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_Disk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_Disk.Location = new System.Drawing.Point(3, 22);
            this.add_Disk.Name = "add_Disk";
            this.add_Disk.Size = new System.Drawing.Size(440, 26);
            this.add_Disk.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.add_Series);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox13.Location = new System.Drawing.Point(3, 75);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(446, 46);
            this.groupBox13.TabIndex = 12;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Series";
            // 
            // add_Series
            // 
            this.add_Series.ContextMenuStrip = this.menu_textb;
            this.add_Series.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_Series.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_Series.Location = new System.Drawing.Point(3, 22);
            this.add_Series.Name = "add_Series";
            this.add_Series.Size = new System.Drawing.Size(440, 26);
            this.add_Series.TabIndex = 1;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.add_Names);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox14.Location = new System.Drawing.Point(3, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(446, 72);
            this.groupBox14.TabIndex = 11;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Title/s*";
            // 
            // add_Names
            // 
            this.add_Names.ContextMenuStrip = this.menu_textb;
            this.add_Names.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_Names.Location = new System.Drawing.Point(3, 22);
            this.add_Names.Name = "add_Names";
            this.add_Names.Size = new System.Drawing.Size(440, 47);
            this.add_Names.TabIndex = 0;
            this.add_Names.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage4.Controls.Add(this.groupBox18);
            this.tabPage4.Controls.Add(this.groupBox22);
            this.tabPage4.Controls.Add(this.change_groupBox_tags);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(452, 758);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Change";
            this.toolTip1.SetToolTip(this.tabPage4, "Alt+4");
            // 
            // groupBox18
            // 
            this.groupBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox18.Controls.Add(this.button5);
            this.groupBox18.Controls.Add(this.button4);
            this.groupBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox18.Location = new System.Drawing.Point(0, 386);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(452, 372);
            this.groupBox18.TabIndex = 21;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Actions";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(446, 51);
            this.button5.TabIndex = 12;
            this.button5.Text = "Delete Record";
            this.toolTip1.SetToolTip(this.button5, "Alt+D");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.menu_change;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(446, 48);
            this.button4.TabIndex = 11;
            this.button4.Text = "Change";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.changeRecord_Click);
            // 
            // menu_change
            // 
            this.menu_change.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator6,
            this.changeSeriesOnlyToolStripMenuItem,
            this.toolStripSeparator5,
            this.changeDiskOnlyToolStripMenuItem,
            this.toolStripSeparator4,
            this.changeDeveloperOnlyToolStripMenuItem,
            this.toolStripSeparator3,
            this.changePublisherOnlyToolStripMenuItem,
            this.toolStripSeparator2,
            this.changeTagsOnlyToolStripMenuItem,
            this.toolStripSeparator1,
            this.changeImageOnlyToolStripMenuItem,
            this.toolStripSeparator7,
            this.markAsBrokenToolStripMenuItem,
            this.toolStripSeparator8,
            this.markAsMissingToolStripMenuItem,
            this.toolStripSeparator9,
            this.markAsHealthyToolStripMenuItem});
            this.menu_change.Name = "menu_change";
            this.menu_change.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu_change.Size = new System.Drawing.Size(294, 398);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(293, 34);
            this.toolStripMenuItem1.Text = "Change name only";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(290, 6);
            // 
            // changeSeriesOnlyToolStripMenuItem
            // 
            this.changeSeriesOnlyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSeriesOnlyToolStripMenuItem.Name = "changeSeriesOnlyToolStripMenuItem";
            this.changeSeriesOnlyToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.changeSeriesOnlyToolStripMenuItem.Text = "Change series only";
            this.changeSeriesOnlyToolStripMenuItem.Click += new System.EventHandler(this.changeSeriesOnlyToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(290, 6);
            // 
            // changeDiskOnlyToolStripMenuItem
            // 
            this.changeDiskOnlyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeDiskOnlyToolStripMenuItem.Name = "changeDiskOnlyToolStripMenuItem";
            this.changeDiskOnlyToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.changeDiskOnlyToolStripMenuItem.Text = "Change disk only";
            this.changeDiskOnlyToolStripMenuItem.Click += new System.EventHandler(this.changeDiskOnlyToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(290, 6);
            // 
            // changeDeveloperOnlyToolStripMenuItem
            // 
            this.changeDeveloperOnlyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeDeveloperOnlyToolStripMenuItem.Name = "changeDeveloperOnlyToolStripMenuItem";
            this.changeDeveloperOnlyToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.changeDeveloperOnlyToolStripMenuItem.Text = "Change developer only";
            this.changeDeveloperOnlyToolStripMenuItem.Click += new System.EventHandler(this.changeDeveloperOnlyToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(290, 6);
            // 
            // changePublisherOnlyToolStripMenuItem
            // 
            this.changePublisherOnlyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePublisherOnlyToolStripMenuItem.Name = "changePublisherOnlyToolStripMenuItem";
            this.changePublisherOnlyToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.changePublisherOnlyToolStripMenuItem.Text = "Change publisher only";
            this.changePublisherOnlyToolStripMenuItem.Click += new System.EventHandler(this.changePublisherOnlyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(290, 6);
            // 
            // changeTagsOnlyToolStripMenuItem
            // 
            this.changeTagsOnlyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeTagsOnlyToolStripMenuItem.Name = "changeTagsOnlyToolStripMenuItem";
            this.changeTagsOnlyToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.changeTagsOnlyToolStripMenuItem.Text = "Change tags only";
            this.changeTagsOnlyToolStripMenuItem.Click += new System.EventHandler(this.changeTagsOnlyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(290, 6);
            // 
            // changeImageOnlyToolStripMenuItem
            // 
            this.changeImageOnlyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeImageOnlyToolStripMenuItem.Name = "changeImageOnlyToolStripMenuItem";
            this.changeImageOnlyToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.changeImageOnlyToolStripMenuItem.Text = "Change image only";
            this.changeImageOnlyToolStripMenuItem.Click += new System.EventHandler(this.changeImageOnlyToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(290, 6);
            // 
            // markAsBrokenToolStripMenuItem
            // 
            this.markAsBrokenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.markAsBrokenToolStripMenuItem.Name = "markAsBrokenToolStripMenuItem";
            this.markAsBrokenToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.markAsBrokenToolStripMenuItem.Text = "Mark as Broken";
            this.markAsBrokenToolStripMenuItem.Click += new System.EventHandler(this.markAsBrokenToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(290, 6);
            // 
            // markAsMissingToolStripMenuItem
            // 
            this.markAsMissingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.markAsMissingToolStripMenuItem.Name = "markAsMissingToolStripMenuItem";
            this.markAsMissingToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.markAsMissingToolStripMenuItem.Text = "Mark as Missing";
            this.markAsMissingToolStripMenuItem.Click += new System.EventHandler(this.markAsMissingToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(290, 6);
            // 
            // markAsHealthyToolStripMenuItem
            // 
            this.markAsHealthyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.markAsHealthyToolStripMenuItem.Name = "markAsHealthyToolStripMenuItem";
            this.markAsHealthyToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.markAsHealthyToolStripMenuItem.Text = "Mark as Healthy";
            this.markAsHealthyToolStripMenuItem.Click += new System.EventHandler(this.markAsHealthyToolStripMenuItem_Click);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.change_url);
            this.groupBox22.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox22.Location = new System.Drawing.Point(0, 340);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(452, 46);
            this.groupBox22.TabIndex = 20;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Image URL (460x215)";
            // 
            // change_url
            // 
            this.change_url.ContextMenuStrip = this.menu_textb;
            this.change_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_url.Location = new System.Drawing.Point(3, 22);
            this.change_url.Name = "change_url";
            this.change_url.Size = new System.Drawing.Size(446, 26);
            this.change_url.TabIndex = 1;
            // 
            // change_groupBox_tags
            // 
            this.change_groupBox_tags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.change_groupBox_tags.Controls.Add(this.change_tags);
            this.change_groupBox_tags.Dock = System.Windows.Forms.DockStyle.Top;
            this.change_groupBox_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_groupBox_tags.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.change_groupBox_tags.Location = new System.Drawing.Point(0, 230);
            this.change_groupBox_tags.Name = "change_groupBox_tags";
            this.change_groupBox_tags.Size = new System.Drawing.Size(452, 110);
            this.change_groupBox_tags.TabIndex = 18;
            this.change_groupBox_tags.TabStop = false;
            this.change_groupBox_tags.Text = "Tags";
            // 
            // change_tags
            // 
            this.change_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_tags.FormattingEnabled = true;
            this.change_tags.Location = new System.Drawing.Point(3, 22);
            this.change_tags.Name = "change_tags";
            this.change_tags.Size = new System.Drawing.Size(446, 85);
            this.change_tags.TabIndex = 0;
            this.change_tags.Click += new System.EventHandler(this.checkedListBox3_Click);
            this.change_tags.SelectedIndexChanged += new System.EventHandler(this.checkedListBox3_SelectedIndexChanged);
            this.change_tags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox3_MouseDoubleClick);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox8.Controls.Add(this.change_pub);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox8.Location = new System.Drawing.Point(0, 184);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(452, 46);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Publisher";
            // 
            // change_pub
            // 
            this.change_pub.ContextMenuStrip = this.menu_textb;
            this.change_pub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_pub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_pub.Location = new System.Drawing.Point(3, 22);
            this.change_pub.Name = "change_pub";
            this.change_pub.Size = new System.Drawing.Size(446, 26);
            this.change_pub.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox7.Controls.Add(this.change_dev);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Location = new System.Drawing.Point(0, 138);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(452, 46);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Developer";
            // 
            // change_dev
            // 
            this.change_dev.ContextMenuStrip = this.menu_textb;
            this.change_dev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_dev.Location = new System.Drawing.Point(3, 22);
            this.change_dev.Name = "change_dev";
            this.change_dev.Size = new System.Drawing.Size(446, 26);
            this.change_dev.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox6.Controls.Add(this.change_disk);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Location = new System.Drawing.Point(0, 92);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(452, 46);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Disk";
            // 
            // change_disk
            // 
            this.change_disk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_disk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_disk.Location = new System.Drawing.Point(3, 22);
            this.change_disk.Name = "change_disk";
            this.change_disk.Size = new System.Drawing.Size(446, 26);
            this.change_disk.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Controls.Add(this.change_series);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Location = new System.Drawing.Point(0, 46);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(452, 46);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Series";
            // 
            // change_series
            // 
            this.change_series.ContextMenuStrip = this.menu_textb;
            this.change_series.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_series.Location = new System.Drawing.Point(3, 22);
            this.change_series.Margin = new System.Windows.Forms.Padding(0);
            this.change_series.Name = "change_series";
            this.change_series.Size = new System.Drawing.Size(446, 26);
            this.change_series.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.change_name);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 46);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Title";
            // 
            // change_name
            // 
            this.change_name.ContextMenuStrip = this.menu_textb;
            this.change_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_name.Location = new System.Drawing.Point(3, 22);
            this.change_name.Name = "change_name";
            this.change_name.Size = new System.Drawing.Size(446, 26);
            this.change_name.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(822, 988);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Disk";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Series";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Developer";
            this.columnHeader4.Width = 139;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Publisher";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tags";
            this.columnHeader6.Width = 328;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.selectInverseToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.copyAsTextToolStripMenuItem,
            this.toolStripMenuItem2,
            this.searchNameInGoogleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(301, 242);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.selectNoneToolStripMenuItem.Text = "Select None";
            this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // selectInverseToolStripMenuItem
            // 
            this.selectInverseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectInverseToolStripMenuItem.Name = "selectInverseToolStripMenuItem";
            this.selectInverseToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.selectInverseToolStripMenuItem.Text = "Select Inverse";
            this.selectInverseToolStripMenuItem.Click += new System.EventHandler(this.selectInverseToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // copyAsTextToolStripMenuItem
            // 
            this.copyAsTextToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyAsTextToolStripMenuItem.Name = "copyAsTextToolStripMenuItem";
            this.copyAsTextToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.copyAsTextToolStripMenuItem.Text = "Copy Record/s As Text";
            this.copyAsTextToolStripMenuItem.Click += new System.EventHandler(this.copyAsTextToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(300, 34);
            this.toolStripMenuItem2.Text = "Copy Title/s as Text";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // searchNameInGoogleToolStripMenuItem
            // 
            this.searchNameInGoogleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.searchNameInGoogleToolStripMenuItem.Name = "searchNameInGoogleToolStripMenuItem";
            this.searchNameInGoogleToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.searchNameInGoogleToolStripMenuItem.Text = "Search Name In Google";
            this.searchNameInGoogleToolStripMenuItem.Click += new System.EventHandler(this.searchNameInGoogleToolStripMenuItem_Click);
            // 
            // pictureBox_Header
            // 
            this.pictureBox_Header.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Header.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Header.Name = "pictureBox_Header";
            this.pictureBox_Header.Size = new System.Drawing.Size(460, 215);
            this.pictureBox_Header.TabIndex = 3;
            this.pictureBox_Header.TabStop = false;
            this.pictureBox_Header.Visible = false;
            this.pictureBox_Header.DoubleClick += new System.EventHandler(this.pictureBox_Header_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.pictureBox_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 1011);
            this.panel1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 988);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(822, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // panel_search_results
            // 
            this.panel_search_results.Controls.Add(this.listView1);
            this.panel_search_results.Controls.Add(this.progressBar1);
            this.panel_search_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_search_results.Location = new System.Drawing.Point(460, 0);
            this.panel_search_results.Name = "panel_search_results";
            this.panel_search_results.Size = new System.Drawing.Size(822, 1011);
            this.panel_search_results.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 1011);
            this.Controls.Add(this.panel_search_results);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games Database Manager v1.17";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox_disks.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.menu_search.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox_tags_search.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menu_textb.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox_tags_add.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.add_Disk)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.menu_change.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.change_groupBox_tags.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.change_disk)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Header)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_search_results.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
         
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        
        private System.Windows.Forms.GroupBox groupBox2;
         
        private System.Windows.Forms.RadioButton search_bySeries;
        private System.Windows.Forms.RadioButton search_byPublisher;
        private System.Windows.Forms.RadioButton search_byDev;
        private System.Windows.Forms.RadioButton search_byName;
        private TextBox search_name;
        private TextBox search_indisks;
        private TextBox search_mustnotcontain;
        private TabPage tabPage3;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox_disks;
        private ListBox list_disks;
        private TabPage tabPage4;
        private GroupBox groupBox8;
        private TextBox change_pub;
        private GroupBox groupBox7;
        private TextBox change_dev;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private TextBox change_series;
        private GroupBox groupBox4;
        private TextBox change_name;
        private GroupBox groupBox_tags_add;
        private CheckedListBox add_tags;
        private GroupBox groupBox10;
        private TextBox add_Publisher;
        private GroupBox groupBox11;
        private TextBox add_Developer;
        private GroupBox groupBox12;
        private GroupBox groupBox13;
        private TextBox add_Series;
        private GroupBox groupBox14;
        private RichTextBox add_Names;
        private GroupBox change_groupBox_tags;
        private CheckedListBox change_tags;
        private Button button10;
        private Button button9;
        private Button button8;
        private GroupBox groupBox19;
        private Button button11;
        private NumericUpDown add_Disk;
        private GroupBox groupBox_tags_search;
        private CheckedListBox search_tags;
        private GroupBox groupBox16;
        private CheckedListBox add_action_options;
        private Button button7;
        private Button button6;
        private GroupBox groupBox21;
        private TextBox add_url;
        private PictureBox pictureBox_Header;
        private GroupBox groupBox18;
        private Button button5;
        private Button button4;
        private GroupBox groupBox22;
        private TextBox change_url;
        private Panel panel1;
        private NumericUpDown change_disk;
        private Button button12;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem selectNoneToolStripMenuItem;
        private ToolStripMenuItem selectInverseToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem copyAsTextToolStripMenuItem;
        private Button button13;
        private ContextMenuStrip menu_change;
        private ToolStripMenuItem changeSeriesOnlyToolStripMenuItem;
        private ToolStripMenuItem changeDiskOnlyToolStripMenuItem;
        private ToolStripMenuItem changeDeveloperOnlyToolStripMenuItem;
        private ToolStripMenuItem changePublisherOnlyToolStripMenuItem;
        private ToolStripMenuItem changeTagsOnlyToolStripMenuItem;
        private ToolStripMenuItem changeImageOnlyToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ContextMenuStrip menu_textb;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolTip toolTip1;
        private ToolStripMenuItem searchNameInGoogleToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label_countResuults;
        private System.Windows.Forms.GroupBox groupBox9;
        private GroupBox groupBox15;
        private GroupBox groupBox23;
        private RadioButton img_YES;
        private RadioButton img_PAS;
        private RadioButton img_NO;
        private GroupBox groupBox20;
        private RadioButton pub_YES;
        private RadioButton pub_PAS;
        private RadioButton pub_NO;
        private GroupBox groupBox17;
        private RadioButton dev_YES;
        private RadioButton dev_PAS;
        private RadioButton dev_NO;
        private RadioButton series_YES;
        private RadioButton series_PASS;
        private RadioButton series_NO;
        private ProgressBar progressBar1;
        private Panel panel_search_results;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem markAsBrokenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem markAsMissingToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem markAsHealthyToolStripMenuItem;
        private GroupBox groupBox25;
        private RadioButton SEARCH_MISSING_YES;
        private RadioButton SEARCH_MISSING_PASS;
        private RadioButton SEARCH_MISSING_NO;
        private GroupBox groupBox24;
        private RadioButton SEARCH_BROKEN_YES;
        private RadioButton SEARCH_BROKEN_PASS;
        private RadioButton SEARCH_BROKEN_NO;
        private ContextMenuStrip menu_search;
        private ToolStripMenuItem toolStripMenuItem10;
        private GroupBox groupBox28;
        private Button button15;
        private GroupBox groupBox27;
        private Label label_countSearch;
        private Button button14;
        private GroupBox groupBox26;
    }
}

