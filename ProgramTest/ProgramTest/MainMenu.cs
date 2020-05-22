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
    public partial class MainMenu : Form
    {
        private PresetRepository _presetRepository;
        public MainMenu()
        {
            _presetRepository = new PresetRepository(new PresetDbContext());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGridMainMenu();
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
            if (MainMenuDataGrid.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.MainMenuDataGrid.SelectedRows[0];
                Preset preset = new Preset();
                int idToBeDeleted = int.Parse(row.Cells[0].Value.ToString());
                preset = _presetRepository.GetOne(item => item.Id == idToBeDeleted);
                _presetRepository.Remove(preset);
            }
            UpdateGridMainMenu();
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

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGridMainMenu();
        }

        public void UpdateGridMainMenu()
        {
            MainMenuDataGrid.DataSource = _presetRepository.GetAll().ToList();
            MainMenuDataGrid.Columns[0].Width = 25;
            MainMenuDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MainMenuDataGrid.Columns[3].Visible = false;
            MainMenuDataGrid.Columns[4].Visible = false;
            MainMenuDataGrid.ReadOnly = true;
        }

        private void MainMenuDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditPreset_Click(object sender, EventArgs e)
        {

        }
    }
}
