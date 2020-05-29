using Data.Entities;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsBGChanger;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using Microsoft.VisualBasic.Devices;
using ProgramTest.Data.Repositories;
using System.Threading;

namespace ProgramTest
{
    public partial class MainMenu : Form
    {
        private SettingRepository _settingRepository;
        private List<int> _startedProcessIds = new List<int>();
        private PresetRepository _presetRepository;
        private bool isCollapsedPreset = true;
        private bool isCollapsedClose = true;
        private double[] _ramBorder = new double[4];
        private double[] _delay = new double[3];
        private double _timeToSleep;
        public MainMenu()
        {
            _settingRepository = new SettingRepository(Program.DbContext);
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
            frm.FormClosing += delegate { this.Show(); this.UpdateGridMainMenu(); };
            frm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = MainMenuDataGrid.SelectedRows;
            if (rows.Count >= 1)
            {
                List<Preset> presets = GetSelectedPresets();

                _presetRepository.RemoveRange(presets);
            }
            UpdateGridMainMenu();
        }


        private void runPreset_Click(object sender, EventArgs e)
        {
            _ramBorder[0] = _settingRepository.GetSettingByName("Ram Border 1").Value;
            _ramBorder[1] = _settingRepository.GetSettingByName("Ram Border 2").Value;
            _ramBorder[2] = _settingRepository.GetSettingByName("Ram Border 3").Value;
            _ramBorder[3] = _settingRepository.GetSettingByName("Ram Border 4").Value;
            _delay[0] = _settingRepository.GetSettingByName("Delay 1").Value;
            _delay[0] = _settingRepository.GetSettingByName("Delay 2").Value;
            _delay[0] = _settingRepository.GetSettingByName("Delay 3").Value;
            if (MainMenuDataGrid.SelectedRows.Count == 1)
            {
                Preset preset = GetSelectedPreset();
                List<PresetSetting> currentPresetSettings = preset.PresetSettings.ToList();

                #region Seperate Preset Settings by setting type
                List<PresetSetting> currentPresetSettingsFile = currentPresetSettings
                    .Where(type => type.PresetSettingType == "File").ToList();
                List<PresetSetting> currentPresetSettingsURL = currentPresetSettings
                    .Where(type => type.PresetSettingType == "URL").ToList();
                List<PresetSetting> currentPresetSettingsBG = currentPresetSettings
                    .Where(type => type.PresetSettingType == "Background").ToList();

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
                    double availableMemory = AppManager.GetCurrentMemoryUsagePercent();
                    if (availableMemory < _ramBorder[0])
                    {
                        _timeToSleep = _delay[0];
                    }
                    else if (availableMemory >= _ramBorder[1] && availableMemory < _ramBorder[2])
                    {
                        _timeToSleep = _delay[0];
                    }
                    else if (availableMemory >= _ramBorder[2] && availableMemory < _ramBorder[3])
                    {
                        _timeToSleep = _delay[0];
                    }
                    else if (MemoryExceedsThresholdPercentage(_ramBorder[3]))
                    {
                        break;
                    }
                    Thread.Sleep((int)_timeToSleep * 1000);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGridMainMenu();
        }

        public void UpdateGridMainMenu()
        {
            MainMenuDataGrid.DataSource = _presetRepository.GetAll().ToList();
            MainMenuDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MainMenuDataGrid.Columns[0].Visible = false;    //Hides presetId column
            MainMenuDataGrid.Columns[3].Visible = false;    //Hides presetValue column
            MainMenuDataGrid.Columns[4].Visible = false;    //Hides isActive column
            MainMenuDataGrid.Columns[4].Visible = false;    //Hides isActive column
            MainMenuDataGrid.ReadOnly = true;
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
                frm.FormClosing += delegate { this.UpdateGridMainMenu(); };
                frm.ShowDialog();
            }
        }

        private Preset GetSelectedPreset()
        {
            DataGridViewRow row = this.MainMenuDataGrid.SelectedRows[0];
            Preset preset = new Preset();
            int idToBeDeleted = int.Parse(row.Cells[0].Value.ToString());
            preset = _presetRepository.GetById(idToBeDeleted);
            return preset;
        }

        private List<Preset> GetSelectedPresets()
        {
            DataGridViewSelectedRowCollection rows = MainMenuDataGrid.SelectedRows;
            int[] idsToBeDeleted = new int[rows.Count];
            for (int i = 0; i < rows.Count; i++)
            {
                idsToBeDeleted[i] = int.Parse(rows[i].Cells[0].Value.ToString());
            }
            List<Preset> presets = new List<Preset>();
            foreach (var id in idsToBeDeleted)
            {
                presets.Add(_presetRepository.GetById(id));
            }
            return presets;
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
            #region Moves downwards all buttons, located below Preset Settings
            if (isCollapsedPreset)
            {
                presetSettingsPanel.Height += 10;
                this.closePanel.Location = new Point(
                this.closePanel.Location.X,
                this.closePanel.Location.Y + 10);
                this.UpdateGrid.Location = new Point(
                this.UpdateGrid.Location.X,
                this.UpdateGrid.Location.Y + 10);
                this.settingsButton.Location = new Point(
                this.settingsButton.Location.X,
                this.settingsButton.Location.Y + 10);
                if (presetSettingsPanel.Size == presetSettingsPanel.MaximumSize)
                {
                    isCollapsedPreset = false;
                    presetSettingsTimerPreset.Stop();
                }
            }
            #endregion
            #region Moves upwards all buttons, located below Preset Settings
            else
            {
                presetSettingsPanel.Height -= 10;
                this.closePanel.Location = new Point(
                this.closePanel.Location.X,
                this.closePanel.Location.Y - 10);
                this.UpdateGrid.Location = new Point(
                this.UpdateGrid.Location.X,
                this.UpdateGrid.Location.Y - 10);
                this.settingsButton.Location = new Point(
                this.settingsButton.Location.X,
                this.settingsButton.Location.Y - 10);
                if (presetSettingsPanel.Size == presetSettingsPanel.MinimumSize)
                {
                    isCollapsedPreset = true;
                    presetSettingsTimerPreset.Stop();
                }
            }
            #endregion
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            presetSettingsTimerClose.Enabled = true;
            presetSettingsTimerClose.Start();
        }

        private void presetSettingsTimerClose_Tick(object sender, EventArgs e)
        {
            #region Moves upwards all buttons, located below Close
            if (isCollapsedClose)
            {
                presetSettingsTimerClose.Start();
                closePanel.Height += 10;
                this.UpdateGrid.Location = new Point(
                this.UpdateGrid.Location.X,
                this.UpdateGrid.Location.Y + 9);
                this.settingsButton.Location = new Point(
                this.settingsButton.Location.X,
                this.settingsButton.Location.Y + 9);
                if (closePanel.Size == closePanel.MaximumSize)
                {
                    isCollapsedClose = false;
                    presetSettingsTimerClose.Stop();
                }
            }
            #endregion
            #region Moves downwards all buttons, located below Close
            else
            {
                presetSettingsTimerClose.Start();
                closePanel.Height -= 10;
                this.UpdateGrid.Location = new Point(
                this.UpdateGrid.Location.X,
                this.UpdateGrid.Location.Y - 9);
                this.settingsButton.Location = new Point(
                this.settingsButton.Location.X,
                this.settingsButton.Location.Y - 9);
                if (closePanel.Size == closePanel.MinimumSize)
                {
                    isCollapsedClose = true;
                    presetSettingsTimerClose.Stop();
                }
            }
            #endregion
        }

        private void importExport_Click(object sender, EventArgs e)
        {
            var frm = new ImportPreset();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); this.UpdateGridMainMenu(); };
            frm.ShowDialog();
        }

        public static bool MemoryExceedsThresholdPercentage(double thresholdPercentage)
        {
            double totalMemory = new ComputerInfo().TotalPhysicalMemory;
            double availableMemory = new ComputerInfo().AvailablePhysicalMemory;
            double usedMemory = totalMemory - availableMemory;
            double usedMemoryPercentage = usedMemory / totalMemory * 100;

            if (usedMemoryPercentage >= thresholdPercentage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var frm = new Settings();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}  