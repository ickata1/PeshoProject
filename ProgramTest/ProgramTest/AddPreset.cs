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
using System.Drawing.Printing;

namespace ProgramTest
{
    public partial class AddPreset : Form
    {
        private PresetSettingRepository _presetSettingRepository;
        private Preset _currentPreset = new Preset();
        private string _filePath;

        public AddPreset(Preset preset)
        {
            _currentPreset = preset;
            _presetSettingRepository = new PresetSettingRepository(Program.DbContext);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _filePath = FileBrowserDialogue.GetFullFilePath();
            FilePathTextBox.Text = _filePath;
        }

        private void FilePathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgramName_TextChanged(object sender, EventArgs e)
        {

        }
        private void SavePreset_Click(object sender, EventArgs e)
        {
            if (presetType.Text == "URL")
            {
                PresetSetting presetSetting = new PresetSetting();
                presetSetting.Name = ProgramName.Text;
                presetSetting.Value = FilePathTextBox.Text;
                presetSetting.PresetSettingType = presetType.Text;
                presetSetting.PresetId = _currentPreset.Id;
                presetSetting.Preset = _currentPreset;
                _presetSettingRepository.Add(presetSetting);
                this.Close();
            }
            else if (System.IO.File.Exists(FilePathTextBox.Text))
            {
                PresetSetting presetSetting = new PresetSetting();
                presetSetting.Name = ProgramName.Text;
                presetSetting.Value = FilePathTextBox.Text;
                presetSetting.PresetSettingType = presetType.Text;
                presetSetting.PresetId = _currentPreset.Id;
                presetSetting.Preset = _currentPreset;

                _presetSettingRepository.Add(presetSetting);
                this.Close();
            }
            else
            {
                FilePathTextBox.Clear();
                MessageBox.Show("File does not exist.");
            }

        }
    }
}
