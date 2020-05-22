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
        private Preset _currentPreset = new Preset();
        private string filePath;
        public AddPreset(Preset preset)
        {
            _currentPreset = preset;
            _presetSettingRepository = new PresetSettingRepository(new PresetDbContext());
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
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

        private void SavePreset_Click(object sender, EventArgs e)
        {
            PresetSetting singlePresetSetting = new PresetSetting();
            singlePresetSetting.Name = ProgramName.Text;
            singlePresetSetting.Value = FilePathTextBox.Text;
            singlePresetSetting.PresetSettingType = listBox1.Text;
            singlePresetSetting.PresetId = _currentPreset.Id;
            singlePresetSetting.Preset = _currentPreset;
            _presetSettingRepository.Add(singlePresetSetting);
            this.Close();
        }
    }
}
