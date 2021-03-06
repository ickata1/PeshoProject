﻿using Data.Entities;
using Data.Repositories;
using System;
using System.Windows.Forms;

namespace ProgramTest
{
    public partial class CreatePreset : Form
    {
        private PresetRepository _presetRepository;
        public CreatePreset()
        {
            _presetRepository = new PresetRepository(Program.DbContext);
            InitializeComponent();
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
