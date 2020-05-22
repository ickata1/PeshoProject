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
        private PresetSettingRepository _presetSettingRepository;
        private PresetRepository _presetRepository;
        public EditPreset()
        {
            _presetSettingRepository = new PresetSettingRepository(new PresetDbContext());

            _presetRepository = new PresetRepository(new PresetDbContext());
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            presetSettingsGridBox.DataSource = _presetSettingRepository.GetAll().ToList();
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
            var frm = new AddPreset();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
        }

        private void CreatePreset_Click(object sender, EventArgs e)
        {
            Preset Preset = new Preset();
            Preset.Name = PresetName.Text;
            Preset.Description = presetDescription.Text;
            _presetRepository.Add(Preset);
            this.Close();
        }

        private void Dismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPreset_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
