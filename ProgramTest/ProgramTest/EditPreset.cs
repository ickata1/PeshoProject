﻿using Data.Entities;
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
using System.Data.SqlClient;

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
            _presetRepository = new PresetRepository(Program.DbContext);
            _presetSettingRepository = new PresetSettingRepository(Program.DbContext);
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
            frm.FormClosing += delegate { this.Show(); this.UpdateGrid();};
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
            int id = int.Parse(row.Cells[0].Value.ToString());
            presetSetting = _presetSettingRepository.GetById(id);

            return presetSetting;
        }

        private List<PresetSetting> GetSelectedPresets()
        {
            DataGridViewSelectedRowCollection rows = this.presetSettingsGridBox.SelectedRows;
            int[] ids = new int[rows.Count];
            for (int i = 0; i < rows.Count; i++)
            {
                ids[i] = int.Parse(rows[i].Cells[0].Value.ToString());
            }
            List<PresetSetting> presetSettings = new List<PresetSetting>();
            foreach (var id in ids)
            {
                presetSettings.Add(_presetSettingRepository.GetById(id));
            }
            return presetSettings;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (presetSettingsGridBox.SelectedRows.Count >= 1) 
            {
                List<PresetSetting> presetSettings = GetSelectedPresets();

                _presetSettingRepository.RemoveRange(presetSettings);
            }
            UpdateGrid();
        }
    }
}
