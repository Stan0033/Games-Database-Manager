using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            label_message.Text = BreakFilePathIntoLines(message,45);
            info.Visible = type == 1? true : false;
            warning.Visible = type == 2? true : false;
            if (type == 1) { asteriskPlayer.Play(); }
            if (type == 2) { exclamationPlayer.Play(); }
            
        }

       

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
        public static string BreakFilePathIntoLines(string input, int maxCharactersPerLine)
        {
            if (string.IsNullOrEmpty(input) || maxCharactersPerLine <= 0)
            {
                return input;
            }

            var lines = new List<string>();

            string[] pathParts = input.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);

            string currentLine = string.Empty;

            foreach (var part in pathParts)
            {
                if ((currentLine + part).Length <= maxCharactersPerLine)
                {
                    currentLine += (currentLine == string.Empty) ? part : Path.DirectorySeparatorChar + part;
                }
                else
                {
                    lines.Add(currentLine);
                    currentLine = part;
                }
            }

            if (!string.IsNullOrEmpty(currentLine))
            {
                lines.Add(currentLine);
            }

            return string.Join(Environment.NewLine, lines);
        }
    }
}
