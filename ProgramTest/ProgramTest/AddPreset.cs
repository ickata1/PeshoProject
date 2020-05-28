using Data.Entities;
using Data.Repositories;
using System;
using System.Windows.Forms;
using WindowsBGChanger;

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilePathButton_Click(object sender, EventArgs e)
        {
            _filePath = FileBrowserDialogue.GetFullFilePath();
            valueTextBox.Text = _filePath;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (typeComboBox.Text == "URL")
            {
                PresetSetting presetSetting = new PresetSetting();
                presetSetting.Name = nameTextBox.Text;
                presetSetting.Value = valueTextBox.Text;
                presetSetting.PresetSettingType = typeComboBox.Text;
                presetSetting.PresetId = _currentPreset.Id;
                presetSetting.Preset = _currentPreset;
                _presetSettingRepository.Add(presetSetting);
                this.Close();
            }
            else if (System.IO.File.Exists(valueTextBox.Text))
            {
                PresetSetting presetSetting = new PresetSetting();
                presetSetting.Name = nameTextBox.Text;
                presetSetting.Value = valueTextBox.Text;
                presetSetting.PresetSettingType = typeComboBox.Text;
                presetSetting.PresetId = _currentPreset.Id;
                presetSetting.Preset = _currentPreset;
                _presetSettingRepository.Add(presetSetting);
                this.Close();
            }
            else
            {
                valueTextBox.Clear();
                MessageBox.Show("File does not exist.");
            }
        }
    }
}
