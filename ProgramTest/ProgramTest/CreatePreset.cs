using Data;
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
using Data.Entities;

namespace ProgramTest
{
    public partial class CreatePreset : Form
    {
        private PresetSettingRepository _presetSettingRepository;
        private PresetRepository _presetRepository;
        public CreatePreset()
        {
            _presetRepository = new PresetRepository(new PresetDbContext());
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
            _presetRepository.Add(preset);
            this.Close();
        }
    }
}
