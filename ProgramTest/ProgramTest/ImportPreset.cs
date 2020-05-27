using Data.Entities;
using Data.Repositories;
using System;
using System.IO;
using System.Linq;
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
                string Json = JsonConverter.ConvertToJson(preset);
                System.IO.File.WriteAllText(filePathTextBox.Text, Json);
            }
        }

        private void filePathButton_Click(object sender, EventArgs e)
        {
            _filePathExport = FileBrowserDialogue.GetFolderPath();
            _filePathExport += (_filePathExport[_filePathExport.Length-1]=='\\') ? "Export.json" : "\\Export.json";
            filePathTextBox.Text = _filePathExport;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string message = "";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (filePathImportTextBox.Text!="")
            {
                Preset currentPreset = JsonConverter.ConvertFromJson(_filePathImport);
                string newFilepath;
                #region Checks the value of the imported PresetSettings and requests new ones if needed
                foreach (PresetSetting presetSetting in currentPreset.PresetSettings)
                {
                    if (presetSetting.PresetSettingType == "File" || presetSetting.PresetSettingType == "BG")
                    {
                        if (!File.Exists(presetSetting.Value))
                        {
                            message = "Please select a valid file path for " + presetSetting.Name + "!";
                            caption = presetSetting.Name + " does not contain a valid file path!";
                            DialogResult importRequest = MessageBox.Show(message, caption, buttons);
                            newFilepath = FileBrowserDialogue.GetFullFilePath();
                            presetSetting.Value = newFilepath;
                        }
                    }
                }
                #endregion
                _presetRepository.Update(currentPreset);
                message = "Successfully imported " + currentPreset.Name + "!";
                caption = "Import successful!";
                DialogResult importSuccessful = MessageBox.Show(message, caption, buttons);
                UpdateGrid();
            }
            else
            {
                message = "Please sellect a valid file path to import from!";
                caption = "Invalid import file path!";
                DialogResult success = MessageBox.Show(message, caption, buttons);
            }

        }

        private void filePathImportButton_Click(object sender, EventArgs e)
        {
            _filePathImport = FileBrowserDialogue.GetFullFilePath();
            filePathImportTextBox.Text = _filePathImport;
        }


        public void UpdateGrid()
        {
            MainMenuDataGrid.DataSource = _presetRepository.GetAll().ToList();
            MainMenuDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MainMenuDataGrid.Columns[0].Visible = false;    //Hides presetId column
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
