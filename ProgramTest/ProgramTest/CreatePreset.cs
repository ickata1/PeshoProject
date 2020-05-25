using Data;
using Data.Repositories;
using Local = Local_Data.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Entities;
using System.Data.Entity;
using Local_Data;

namespace ProgramTest
{
    public partial class CreatePreset : Form
    {
        private PresetRepository _presetRepository;
        private Local.PresetRepository _localPresetRepository;
        private bool _useServerDb = false;
        public CreatePreset()
        {
            _presetRepository = new PresetRepository(Program.DbContext);
            _localPresetRepository = new Local.PresetRepository(Program.LocalDbContext);
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Preset preset = new Preset();

            preset.Name = PresetName.Text;
            preset.Description = DescriptionBox.Text;
            if (_useServerDb)
            {
                _presetRepository.Add(preset);
            }
            else
            {
                _localPresetRepository.Add(preset);
            }
            this.Close();
        }
    }
}
