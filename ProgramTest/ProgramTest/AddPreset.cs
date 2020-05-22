using Data;
using Data.Entities;
using Data.Repositories;
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
        private PresetSettingRepository _presetSettingRepository;
        private string filePath;
        public AddPreset()
        {
            _presetSettingRepository = new PresetSettingRepository(new PresetDbContext());
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var frm = new EditPreset();
            //frm.Location = this.Location;
            //frm.StartPosition = FormStartPosition.Manual;
            //frm.FormClosing += delegate { this.Show(); };
            //frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PresetSetting singlePreset = new PresetSetting();
            singlePreset.Name = ProgramName.Text;
            singlePreset.Value = FilePathTextBox.Text;
            singlePreset.PresetSettingType = listBox1.Text;
            _presetSettingRepository.Add(singlePreset);
            this.Close();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
