using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramTest
{
    public partial class EditPreset : Form
    {
        public EditPreset()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void Dismiss_Click(object sender, EventArgs e)
        {
            //var frm = new MainMenu();
            //frm.Location = this.Location;
            //frm.StartPosition = FormStartPosition.Manual;
            //frm.FormClosing += delegate { this.Show(); };
            //frm.Show();
            this.Close();
        }

        private void EditPreset_Load(object sender, EventArgs e)
        {

        }
    }
}
