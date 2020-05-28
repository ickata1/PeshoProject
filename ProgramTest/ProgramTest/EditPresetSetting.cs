using Data.Entities;
using Data.Repositories;
using System;
using System.Windows.Forms;
using WindowsBGChanger;

namespace ProgramTest
{
    public partial class EditPresetSetting : Form
    {
        private PresetSettingRepository _presetSettingRepository;
        private PresetSetting _presetSetting;
        private string _filePath;
        public EditPresetSetting(PresetSetting presetSetting)
        {
            _presetSetting = presetSetting;
            _presetSettingRepository = new PresetSettingRepository(Program.DbContext);
            InitializeComponent();
        }

  
        private void GetFilePathButton_Click(object sender, EventArgs e)
        {
            _filePath = FileBrowserDialogue.GetFullFilePath();
            valueTextBox.Text = _filePath;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (presetTypeComboBox.Text == "URL")
            {
                _presetSetting.Name = nameTextBox.Text;
                _presetSetting.Value = valueTextBox.Text;
                _presetSetting.PresetSettingType = presetTypeComboBox.Text;
                _presetSettingRepository.Update(_presetSetting);
                this.Close();
            }
            else if (System.IO.File.Exists(valueTextBox.Text))
            {
                _presetSetting.Name = nameTextBox.Text;
                _presetSetting.Value = valueTextBox.Text;
                _presetSetting.PresetSettingType = presetTypeComboBox.Text;
                _presetSettingRepository.Update(_presetSetting);
                this.Close();
            }
            else
            {
                valueTextBox.Clear();
                MessageBox.Show("File does not exist.");
            }
        }

        private void EditPresetSetting_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = _presetSetting.Name;
            valueTextBox.Text = _presetSetting.Value;
            presetTypeComboBox.SelectedItem = _presetSetting.PresetSettingType;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
