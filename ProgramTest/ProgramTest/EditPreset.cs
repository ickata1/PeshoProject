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
using Data;

namespace ProgramTest
{
    public partial class EditPreset : Form
    {
        public List<PresetSetting> presetSettings { get; set; }
        private Preset _currentPreset = new Preset();
        private PresetSettingRepository _presetSettingRepository;
        private PresetRepository _presetRepository;
        
        public EditPreset(Preset preset)
        {
            this._currentPreset = preset;
            _presetSettingRepository = new PresetSettingRepository(Program.DbContext);
            _presetRepository = new PresetRepository(Program.DbContext);
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
            _presetRepository.Update(_currentPreset);
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
            int idToBeDeleted = int.Parse(row.Cells[0].Value.ToString());

            presetSetting = _presetSettingRepository.GetOne(item => item.Id == idToBeDeleted);

            return presetSetting;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (presetSettingsGridBox.SelectedRows.Count == 1) 
            {
                PresetSetting preset = GetSelectedPreset();
                _presetSettingRepository.Remove(preset);
            }
            UpdateGrid();
        }
    }
}
