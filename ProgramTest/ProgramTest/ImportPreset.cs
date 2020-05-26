using Data.Entities;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsBGChanger;

namespace ProgramTest
{
    public partial class ImportPreset : Form
    {
        private PresetRepository _presetRepository;
        private string _filePathExport;
        private string _filePathImport;
        public ImportPreset()
        {
            _presetRepository = new PresetRepository(Program.DbContext);
            InitializeComponent();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (MainMenuDataGrid.SelectedRows.Count == 1)
            {
                Preset preset = GetSelectedPreset();
                string Json = Program.ConvertToJson(preset);
                System.IO.File.WriteAllText(_filePathExport, Json);
            }
        }

        private void filePathButton_Click(object sender, EventArgs e)
        {
            _filePathExport = FileBrowserDialogue.GetFolderPath();
            _filePathExport += "Export.json";
            filePathTextBox.Text = _filePathExport;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            Program.ConvertFromJson(_filePathImport);
        }

        private void filePathImportButton_Click(object sender, EventArgs e)
        {
            _filePathImport = FileBrowserDialogue.GetFullFilePath();
            filePathImportTextBox.Text = _filePathImport;
        }


        public void UpdateGrid()
        {
            MainMenuDataGrid.DataSource = _presetRepository.GetAll().ToList();
            MainMenuDataGrid.Columns[0].Visible = false;
            //MainMenuDataGrid.Columns[0].Width = 25;
            MainMenuDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MainMenuDataGrid.Columns[3].Visible = false;    //Hides presetValue column
            MainMenuDataGrid.Columns[4].Visible = false;    //Hides isActive column
            MainMenuDataGrid.ReadOnly = true;
        }

        private Preset GetSelectedPreset()
        {
            DataGridViewRow row = this.MainMenuDataGrid.SelectedRows[0];
            Preset preset = new Preset();
            int idToBeSelected = int.Parse(row.Cells[0].Value.ToString());

            preset = _presetRepository.GetOne(item => item.Id == idToBeSelected);

            return preset;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
