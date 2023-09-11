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
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.list_disks = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.search_tags = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.search_indisks = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search_mustnotcontain = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.search_byPublisher = new System.Windows.Forms.RadioButton();
            this.search_byName = new System.Windows.Forms.RadioButton();
            this.search_byDev = new System.Windows.Forms.RadioButton();
            this.search_bySeries = new System.Windows.Forms.RadioButton();
            this.search_name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.add_action_options = new System.Windows.Forms.CheckedListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.add_url = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
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
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.change_url = new System.Windows.Forms.TextBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
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
            this.pictureBox_Header = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectInverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_Disk)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_disk)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Header)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(460, 639);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(452, 650);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Database";
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(0, 574);
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
            this.button10.Location = new System.Drawing.Point(0, 395);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(452, 49);
            this.button10.TabIndex = 7;
            this.button10.Text = "Refresh List";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RefreshDatabase);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.button8.Location = new System.Drawing.Point(0, 297);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(452, 49);
            this.button8.TabIndex = 5;
            this.button8.Text = "View";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ViewDisk);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.list_disks);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox9.Location = new System.Drawing.Point(0, 98);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(452, 199);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Disks";
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
            this.list_disks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_disks_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(0, 612);
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
            this.button2.Location = new System.Drawing.Point(0, 49);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(452, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save All Changes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveAllChanges);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(452, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadDatabase);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.groupBox20);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox19);
            this.tabPage1.Controls.Add(this.search_name);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(3, 439);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(446, 40);
            this.button12.TabIndex = 18;
            this.button12.Text = "Search";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox20.Controls.Add(this.search_tags);
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox20.Location = new System.Drawing.Point(3, 261);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(446, 178);
            this.groupBox20.TabIndex = 17;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Tags";
            // 
            // search_tags
            // 
            this.search_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_tags.FormattingEnabled = true;
            this.search_tags.Location = new System.Drawing.Point(3, 22);
            this.search_tags.Name = "search_tags";
            this.search_tags.Size = new System.Drawing.Size(440, 153);
            this.search_tags.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.search_indisks);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(3, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 46);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "In Disk/s";
            // 
            // search_indisks
            // 
            this.search_indisks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_indisks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_indisks.Location = new System.Drawing.Point(3, 27);
            this.search_indisks.Name = "search_indisks";
            this.search_indisks.Size = new System.Drawing.Size(440, 26);
            this.search_indisks.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.search_mustnotcontain);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(3, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 49);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Must NOT Contain";
            // 
            // search_mustnotcontain
            // 
            this.search_mustnotcontain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_mustnotcontain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_mustnotcontain.Location = new System.Drawing.Point(3, 22);
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
            this.groupBox19.Location = new System.Drawing.Point(3, 29);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(446, 137);
            this.groupBox19.TabIndex = 9;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Search by";
            // 
            // search_byPublisher
            // 
            this.search_byPublisher.AutoSize = true;
            this.search_byPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_byPublisher.Location = new System.Drawing.Point(6, 78);
            this.search_byPublisher.Name = "search_byPublisher";
            this.search_byPublisher.Size = new System.Drawing.Size(114, 24);
            this.search_byPublisher.TabIndex = 3;
            this.search_byPublisher.Text = "By Publisher";
            this.search_byPublisher.UseVisualStyleBackColor = true;
            // 
            // search_byName
            // 
            this.search_byName.AutoSize = true;
            this.search_byName.Checked = true;
            this.search_byName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_byName.Location = new System.Drawing.Point(6, 18);
            this.search_byName.Name = "search_byName";
            this.search_byName.Size = new System.Drawing.Size(91, 24);
            this.search_byName.TabIndex = 1;
            this.search_byName.TabStop = true;
            this.search_byName.Text = "By Name";
            this.search_byName.UseVisualStyleBackColor = true;
            // 
            // search_byDev
            // 
            this.search_byDev.AutoSize = true;
            this.search_byDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_byDev.Location = new System.Drawing.Point(6, 48);
            this.search_byDev.Name = "search_byDev";
            this.search_byDev.Size = new System.Drawing.Size(121, 24);
            this.search_byDev.TabIndex = 2;
            this.search_byDev.Text = "By Developer";
            this.search_byDev.UseVisualStyleBackColor = true;
            // 
            // search_bySeries
            // 
            this.search_bySeries.AutoSize = true;
            this.search_bySeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_bySeries.Location = new System.Drawing.Point(6, 108);
            this.search_bySeries.Name = "search_bySeries";
            this.search_bySeries.Size = new System.Drawing.Size(94, 24);
            this.search_bySeries.TabIndex = 4;
            this.search_bySeries.Text = "By Series";
            this.search_bySeries.UseVisualStyleBackColor = true;
            // 
            // search_name
            // 
            this.search_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_name.Location = new System.Drawing.Point(3, 3);
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(446, 26);
            this.search_name.TabIndex = 8;
            this.search_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchRecords_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.groupBox16);
            this.tabPage2.Controls.Add(this.groupBox21);
            this.tabPage2.Controls.Add(this.groupBox15);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox13);
            this.tabPage2.Controls.Add(this.groupBox14);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
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
            this.groupBox16.Size = new System.Drawing.Size(446, 199);
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
            this.add_action_options.Size = new System.Drawing.Size(440, 92);
            this.add_action_options.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(3, 63);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(440, 41);
            this.button7.TabIndex = 1;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AddRecords_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.add_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_url.Location = new System.Drawing.Point(3, 22);
            this.add_url.Name = "add_url";
            this.add_url.Size = new System.Drawing.Size(440, 26);
            this.add_url.TabIndex = 1;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.add_tags);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox15.Location = new System.Drawing.Point(3, 259);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(446, 94);
            this.groupBox15.TabIndex = 16;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Tags";
            // 
            // add_tags
            // 
            this.add_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_tags.FormattingEnabled = true;
            this.add_tags.Location = new System.Drawing.Point(3, 22);
            this.add_tags.Name = "add_tags";
            this.add_tags.Size = new System.Drawing.Size(440, 69);
            this.add_tags.TabIndex = 0;
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
            this.groupBox12.Text = "Disk";
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
            this.groupBox14.Text = "Title/s";
            // 
            // add_Names
            // 
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
            this.tabPage4.Controls.Add(this.groupBox17);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(452, 601);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Change";
            // 
            // groupBox18
            // 
            this.groupBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox18.Controls.Add(this.button5);
            this.groupBox18.Controls.Add(this.button4);
            this.groupBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox18.Location = new System.Drawing.Point(0, 454);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(452, 147);
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
            this.button5.Location = new System.Drawing.Point(3, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(446, 51);
            this.button5.TabIndex = 12;
            this.button5.Text = "Delete Record";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.removeRecord_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(446, 48);
            this.button4.TabIndex = 11;
            this.button4.Text = "Change";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.changeRecord_Click);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.change_url);
            this.groupBox22.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox22.Location = new System.Drawing.Point(0, 408);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(452, 46);
            this.groupBox22.TabIndex = 20;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Image URL (460x215)";
            // 
            // change_url
            // 
            this.change_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_url.Location = new System.Drawing.Point(3, 22);
            this.change_url.Name = "change_url";
            this.change_url.Size = new System.Drawing.Size(446, 26);
            this.change_url.TabIndex = 1;
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox17.Controls.Add(this.change_tags);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox17.Location = new System.Drawing.Point(0, 230);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(452, 178);
            this.groupBox17.TabIndex = 18;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Tags";
            // 
            // change_tags
            // 
            this.change_tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_tags.FormattingEnabled = true;
            this.change_tags.Location = new System.Drawing.Point(3, 22);
            this.change_tags.Name = "change_tags";
            this.change_tags.Size = new System.Drawing.Size(446, 153);
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
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(452, 46);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Series";
            // 
            // change_series
            // 
            this.change_series.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_series.Location = new System.Drawing.Point(3, 22);
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
            this.listView1.Location = new System.Drawing.Point(460, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(822, 854);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.pictureBox_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 854);
            this.panel1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.selectNoneToolStripMenuItem,
            this.selectInverseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 94);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // selectNoneToolStripMenuItem
            // 
            this.selectNoneToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectNoneToolStripMenuItem.Name = "selectNoneToolStripMenuItem";
            this.selectNoneToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.selectNoneToolStripMenuItem.Text = "Select None";
            this.selectNoneToolStripMenuItem.Click += new System.EventHandler(this.selectNoneToolStripMenuItem_Click);
            // 
            // selectInverseToolStripMenuItem
            // 
            this.selectInverseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectInverseToolStripMenuItem.Name = "selectInverseToolStripMenuItem";
            this.selectInverseToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.selectInverseToolStripMenuItem.Text = "Select Inverse";
            this.selectInverseToolStripMenuItem.Click += new System.EventHandler(this.selectInverseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 854);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games Database Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox15.ResumeLayout(false);
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
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox17.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Header)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
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
        private GroupBox groupBox9;
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
        private GroupBox groupBox15;
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
        private GroupBox groupBox17;
        private CheckedListBox change_tags;
        private Button button10;
        private Button button9;
        private Button button8;
        private GroupBox groupBox19;
        private Button button11;
        private NumericUpDown add_Disk;
        private GroupBox groupBox20;
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
    }
}

