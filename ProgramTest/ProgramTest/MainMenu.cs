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

        private List<int> _startedProcessIds = new List<int>();
        private PresetRepository _presetRepository;
        private bool isCollapsedPreset = true;
        private bool isCollapsedClose = true;
        public MainMenu()
        {
            _presetRepository = new PresetRepository(Program.DbContext);
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGridMainMenu();
            MainMenuDataGrid.Columns[1].Width = 100;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new CreatePreset();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MainMenuDataGrid.SelectedRows.Count == 1) //Delete Fucnition
            {
                Preset preset = GetSelectedPreset();
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
            Preset preset = GetSelectedPreset();
            List<PresetSetting> currentPresetSettings = preset.PresetSettings.ToList();

            #region Seperate Preset Settings by setting type
            List<PresetSetting> currentPresetSettingsFile = currentPresetSettings
                .Where(type => type.PresetSettingType == "File").ToList();
            List<PresetSetting> currentPresetSettingsURL = currentPresetSettings
                .Where(type => type.PresetSettingType == "URL").ToList();
            List<PresetSetting> currentPresetSettingsBG = currentPresetSettings
                .Where(type => type.PresetSettingType == "BG").ToList();

            List<string> filePaths = new List<string>();
            List<string> urlPaths = new List<string>();
            List<string> bgPaths = new List<string>();
            #endregion

            #region Preset Settings' execution
            //Files and exe's
            foreach (var presetSetting in currentPresetSettingsFile)
            {
                filePaths.Add(presetSetting.Value);
            }
            foreach (var filePath in filePaths)
            {
                //TODO... Check if there is space available
                _startedProcessIds.Add(AppManager.OpenExe(filePath));
            }

            //Links
            foreach (var presetSetting in currentPresetSettingsURL)
            {
                urlPaths.Add(presetSetting.Value);
            }
            foreach (var urlPath in urlPaths)
            {
                AppManager.OpenLink(urlPath);
            }

            //Wallpaper(s)
            foreach (var presetSetting in currentPresetSettingsBG)
            {
                bgPaths.Add(presetSetting.Value);
            }
            foreach (var bgPath in bgPaths)
            {
                WindowsWallpaper.SetWallpaper(bgPath);
            }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGridMainMenu();
        }

        public void UpdateGridMainMenu()
        {
            MainMenuDataGrid.DataSource = _presetRepository.GetAll().ToList();
            MainMenuDataGrid.Columns[0].Visible = false;
            //MainMenuDataGrid.Columns[0].Width = 25;
            MainMenuDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MainMenuDataGrid.Columns[3].Visible = false;    //Hides presetValue column
            MainMenuDataGrid.Columns[4].Visible = false;    //Hides isActive column
            MainMenuDataGrid.ReadOnly = true;
        }

        private void MainMenuDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditPreset_Click(object sender, EventArgs e)
        {
            if (MainMenuDataGrid.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.MainMenuDataGrid.SelectedRows[0];
                Preset preset = GetSelectedPreset();

                var frm = new EditPreset(preset);
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.ShowDialog();
            }
        }

        private Preset GetSelectedPreset()
        {
            DataGridViewRow row = this.MainMenuDataGrid.SelectedRows[0];
            Preset preset = new Preset();
            int idToBeDeleted = int.Parse(row.Cells[0].Value.ToString());

            preset = _presetRepository.GetOne(item => item.Id == idToBeDeleted);

            return preset;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            AppManager.CloseEverythingById(_startedProcessIds);
            AppManager.CloseAllBrowsers();
            _startedProcessIds.Clear();
        }

        private void ForceCloseButton_Click(object sender, EventArgs e)
        {
            AppManager.ForceCloseEverythingById(_startedProcessIds);
            AppManager.CloseAllBrowsers();
            _startedProcessIds.Clear();
        }

        private void presetSettingsButton_Click(object sender, EventArgs e)
        {
            presetSettingsTimerPreset.Enabled = true;
            presetSettingsTimerPreset.Start();
        }

        private void presetSettingsTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsedPreset)
            {
                presetSettingsPanel.Height += 10;
                this.closePanel.Location = new Point(
                this.closePanel.Location.X,
                this.closePanel.Location.Y + 10);
                this.UpdateGrid.Location = new Point(
                this.UpdateGrid.Location.X,
                this.UpdateGrid.Location.Y + 10);
                if (presetSettingsPanel.Size == presetSettingsPanel.MaximumSize)
                {
                    isCollapsedPreset = false;
                    presetSettingsTimerPreset.Stop();
                }
            }
            else
            {
                presetSettingsPanel.Height -= 10;
                this.closePanel.Location = new Point(
                this.closePanel.Location.X,
                this.closePanel.Location.Y - 10);
                this.UpdateGrid.Location = new Point(
                this.UpdateGrid.Location.X,
                this.UpdateGrid.Location.Y - 10);
                if (presetSettingsPanel.Size == presetSettingsPanel.MinimumSize)
                {
                    isCollapsedPreset = true;
                    presetSettingsTimerPreset.Stop();
                }
            }

        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            presetSettingsTimerClose.Enabled = true;
            presetSettingsTimerClose.Start();
        }

        private void presetSettingsTimerClose_Tick(object sender, EventArgs e)
        {
            if (isCollapsedClose)
            {
                presetSettingsTimerClose.Start();
                closePanel.Height += 10;
                this.UpdateGrid.Location = new Point(
                this.UpdateGrid.Location.X,
                this.UpdateGrid.Location.Y + 9);
                if (closePanel.Size == closePanel.MaximumSize)
                {
                    isCollapsedClose = false;
                    presetSettingsTimerClose.Stop();
                }
            }
            else
            {
                presetSettingsTimerClose.Start();
                closePanel.Height -= 10;
                this.UpdateGrid.Location = new Point(
                this.UpdateGrid.Location.X,
                this.UpdateGrid.Location.Y - 9);
                if (closePanel.Size == closePanel.MinimumSize)
                {
                    isCollapsedClose = true;
                    presetSettingsTimerClose.Stop();
                }
            }
        }
    }
}
