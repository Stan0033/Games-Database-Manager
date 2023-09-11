using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Records_Manager
{
    public partial class MessageForm : Form
    {
        public MessageForm(string message, int type)
        {
            InitializeComponent();
            string asteriskSoundFilePath = @"C:\Windows\Media\Windows Notify.wav";
            string exclamationSoundFilePath = @"C:\Windows\Media\Windows Exclamation.wav";
            SoundPlayer asteriskPlayer = new SoundPlayer(asteriskSoundFilePath);
            SoundPlayer exclamationPlayer = new SoundPlayer(exclamationSoundFilePath);
            //1=info
            //2=warning
            label_message.Text = message;
            info.Visible = type == 1? true : false;
            warning.Visible = type == 2? true : false;
            if (type == 1) { asteriskPlayer.Play(); }
            if (type == 2) { exclamationPlayer.Play(); }
            
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
