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
using System.Data.SqlClient;
using Data.Repositories;
using Local = Local_Data.Repo;
using Data;
using Local_Data;

namespace ProgramTest
{
    public partial class EditPreset : Form
    {
        public List<PresetSetting> presetSettings { get; set; }
        private Preset _currentPreset = new Preset();
        private PresetSettingRepository _presetSettingRepository;
        private PresetRepository _presetRepository;
        private Local.PresetSettingRepository _localPresetSettingRepository;
        private Local.PresetRepository _localPresetRepository;
        private bool _useServerDb = false;

        public EditPreset(Preset preset)
        {
            this._currentPreset = preset;
            _presetSettingRepository = new PresetSettingRepository(Program.DbContext);
            _presetRepository = new PresetRepository(Program.DbContext);
            _localPresetRepository = new Local.PresetRepository(Program.LocalDbContext);
            _localPresetSettingRepository = new Local.PresetSettingRepository(Program.LocalDbContext);
            InitializeComponent();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            presetSettingsGridBox.DataSource = _currentPreset.PresetSettings.ToList();
            presetSettingsGridBox.Columns[0].Visible = false;
            presetSettingsGridBox.Columns[4].Visible = false;
            presetSettingsGridBox.Columns[5].Visible = false;
            presetSettingsGridBox.Columns[6].Visible = false;
            presetSettingsGridBox.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddNewPresetSetting_Click(object sender, EventArgs e)
        {
            var frm = new AddPreset(_currentPreset);
            
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
        }

        private void CreatePreset_Click(object sender, EventArgs e)
        {
            _currentPreset.Name = PresetName.Text;
            _currentPreset.Description = presetDescription.Text;
            if (_useServerDb)
            {
                _presetRepository.Update(_currentPreset);
            }
            else
            {
                _localPresetRepository.Update(_currentPreset);
            }
            this.Close();
        }

        private void Dismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPreset_Load(object sender, EventArgs e)
        {
            PresetName.Text = _currentPreset.Name;
            presetDescription.Text = _currentPreset.Description;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private PresetSetting GetSelectedPreset()
        {
            DataGridViewRow row = this.presetSettingsGridBox.SelectedRows[0];
            PresetSetting presetSetting = new PresetSetting();
            int id = int.Parse(row.Cells[0].Value.ToString());
            if (_useServerDb)
            {
                presetSetting = _presetSettingRepository.GetById(id);
            }
            else
            {
                presetSetting = _localPresetSettingRepository.GetById(id);
            }
            return presetSetting;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (presetSettingsGridBox.SelectedRows.Count == 1) 
            {
                PresetSetting preset = GetSelectedPreset();
                if (_useServerDb)
                {
                    _presetSettingRepository.Remove(preset);
                }
                else
                {
                    _localPresetSettingRepository.Remove(preset);
                }
            }
            UpdateGrid();
        }
    }
}
