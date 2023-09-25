namespace Records_Manager
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.info = new System.Windows.Forms.PictureBox();
            this.label_message = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info.BackgroundImage")));
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info.Location = new System.Drawing.Point(12, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(50, 50);
            this.info.TabIndex = 0;
            this.info.TabStop = false;
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Location = new System.Drawing.Point(68, 31);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(307, 13);
            this.label_message.TabIndex = 1;
            this.label_message.Text = "11111111111111111111111111111111111111111111111111";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(324, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warning
            // 
            this.warning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("warning.BackgroundImage")));
            this.warning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.warning.Location = new System.Drawing.Point(12, 12);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(50, 50);
            this.warning.TabIndex = 3;
            this.warning.TabStop = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(411, 119);
            this.ControlBox = false;
            this.Controls.Add(this.warning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox warning;
    }
}