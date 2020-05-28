using Data.Entities;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramTest
{
    public partial class EditPreset : Form
    {
        private Preset _currentPreset = new Preset();
        private PresetSettingRepository _presetSettingRepository;
        private PresetRepository _presetRepository;

        public EditPreset(Preset preset)
        {
            _currentPreset = preset;
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

        private void AddNewPresetSetting_Click(object sender, EventArgs e)
        {
            var frm = new AddPreset(_currentPreset);
            
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); this.UpdateGrid();};
            frm.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _currentPreset.Name = nameTextBox.Text;
            _currentPreset.Description = descriptionTextBox.Text;      
            _presetRepository.Update(_currentPreset);

            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPreset_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = _currentPreset.Name;
            descriptionTextBox.Text = _currentPreset.Description;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateGrid();
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

        private void EditPresetSettingButton_Click(object sender, EventArgs e)
        {
            if (presetSettingsGridBox.SelectedRows.Count == 1)
            {
                DataGridViewRow row = this.presetSettingsGridBox.SelectedRows[0];
                PresetSetting presetSetting = GetSelectedPresetSetting();
                var frm = new EditPresetSetting(presetSetting);
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.UpdateGrid(); };
                frm.ShowDialog();
            }
        }

        private PresetSetting GetSelectedPresetSetting()
        {
            DataGridViewRow row = this.presetSettingsGridBox.SelectedRows[0];
            PresetSetting presetSetting = new PresetSetting();
            int idToBeEdited = int.Parse(row.Cells[0].Value.ToString());
            presetSetting = _presetSettingRepository.GetById(idToBeEdited);
            return presetSetting;
        }
    }
}
