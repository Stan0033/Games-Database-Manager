namespace Records_Manager
{
    partial class string_input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(string_input));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_string = new System.Windows.Forms.GroupBox();
            this.textBox_string = new System.Windows.Forms.TextBox();
            this.groupBox_newstring = new System.Windows.Forms.GroupBox();
            this.textBox_newstring = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_string.SuspendLayout();
            this.groupBox_newstring.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(136, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox_string
            // 
            this.groupBox_string.Controls.Add(this.textBox_string);
            this.groupBox_string.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_string.Location = new System.Drawing.Point(0, 0);
            this.groupBox_string.Name = "groupBox_string";
            this.groupBox_string.Size = new System.Drawing.Size(286, 46);
            this.groupBox_string.TabIndex = 4;
            this.groupBox_string.TabStop = false;
            this.groupBox_string.Text = "string";
            // 
            // textBox_string
            // 
            this.textBox_string.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_string.Location = new System.Drawing.Point(3, 16);
            this.textBox_string.Name = "textBox_string";
            this.textBox_string.Size = new System.Drawing.Size(280, 31);
            this.textBox_string.TabIndex = 1;
            // 
            // groupBox_newstring
            // 
            this.groupBox_newstring.Controls.Add(this.textBox_newstring);
            this.groupBox_newstring.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_newstring.Location = new System.Drawing.Point(0, 46);
            this.groupBox_newstring.Name = "groupBox_newstring";
            this.groupBox_newstring.Size = new System.Drawing.Size(286, 46);
            this.groupBox_newstring.TabIndex = 5;
            this.groupBox_newstring.TabStop = false;
            this.groupBox_newstring.Text = "new string";
            // 
            // textBox_newstring
            // 
            this.textBox_newstring.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_newstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_newstring.Location = new System.Drawing.Point(3, 16);
            this.textBox_newstring.Name = "textBox_newstring";
            this.textBox_newstring.Size = new System.Drawing.Size(280, 31);
            this.textBox_newstring.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 77);
            this.panel1.TabIndex = 6;
            // 
            // string_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 169);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_newstring);
            this.Controls.Add(this.groupBox_string);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "string_input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "String input";
            this.groupBox_string.ResumeLayout(false);
            this.groupBox_string.PerformLayout();
            this.groupBox_newstring.ResumeLayout(false);
            this.groupBox_newstring.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.GroupBox groupBox_string;
        public System.Windows.Forms.TextBox textBox_string;
        public System.Windows.Forms.GroupBox groupBox_newstring;
        public System.Windows.Forms.TextBox textBox_newstring;
        private System.Windows.Forms.Panel panel1;
    }
}