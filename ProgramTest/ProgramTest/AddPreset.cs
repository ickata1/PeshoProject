using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsBGChanger;

namespace ProgramTest
{
    public partial class AddPreset : Form
    {
        private string filePath;
        public AddPreset()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new EditPreset();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new EditPreset();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filePath = FileBrowserDialogue.GetFullFilePath();
            FilePathTextBox.Text = filePath;
        }

        private void FilePathTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ProgramName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
