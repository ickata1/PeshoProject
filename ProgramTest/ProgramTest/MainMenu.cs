using Data.Entities;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new EditPreset();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void displayText_TextChanged(object sender, EventArgs e)
        {

        }

        public void Presets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void runPreset_Click(object sender, EventArgs e)
        {
            Preset currentPreset = new Preset(); //temporary to be changed
            List<PresetSetting> currentPresetSettings = currentPreset.PresetSettings.ToList();
            currentPresetSettings = currentPresetSettings.Where(type => type.PresetSettingType == "File/URL").ToList();
            List<string> filePaths = new List<string>();
            foreach (var presetSetting in currentPresetSettings)
            {
                filePaths.Add(presetSetting.Value);
            }
            foreach (var filePath in filePaths)
            {
                AppManager.OpenExe(filePath);
            }
        }
    }
}
