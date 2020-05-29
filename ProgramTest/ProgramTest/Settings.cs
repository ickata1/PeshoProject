using System;
using System.Windows.Forms;
using ProgramTest.Data.Entities;
using ProgramTest.Data.Repositories;

namespace ProgramTest
{
    public partial class Settings : Form
    {
        private SettingRepository _settingRepository;
        private Setting[] _ramBorderSettings = new Setting[4];
        private Setting[] _delaySettings = new Setting[3];
        public Settings()
        {
            _settingRepository = new SettingRepository(Program.DbContext);
            InitializeComponent();
            _ramBorderSettings[0] = _settingRepository.GetSettingByName("Ram Border 1");
            _ramBorderSettings[1] = _settingRepository.GetSettingByName("Ram Border 2");
            _ramBorderSettings[2] = _settingRepository.GetSettingByName("Ram Border 3");
            _ramBorderSettings[3] = _settingRepository.GetSettingByName("Ram Border 4");
            _delaySettings[0] = _settingRepository.GetSettingByName("Delay 1");
            _delaySettings[1] = _settingRepository.GetSettingByName("Delay 2");
            _delaySettings[2] = _settingRepository.GetSettingByName("Delay 3");
            border1.Text = _ramBorderSettings[0].Value.ToString();
            border2.Text = _ramBorderSettings[1].Value.ToString();
            border4.Text = _ramBorderSettings[2].Value.ToString();
            border6.Text = _ramBorderSettings[3].Value.ToString();
            delay1.Text = _delaySettings[0].Value.ToString();
            delay2.Text = _delaySettings[1].Value.ToString();
            delay3.Text = _delaySettings[2].Value.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void border2_TextChanged(object sender, EventArgs e)
        {
            border3.Text = border2.Text;
        }

        private void border4_TextChanged(object sender, EventArgs e)
        {
            border5.Text = border4.Text;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(int.Parse(border6.Text) > int.Parse(border4.Text) && int.Parse(border4.Text) > int.Parse(border2.Text))
            {
                _ramBorderSettings[1].Value = int.Parse(border2.Text);
                _ramBorderSettings[2].Value = int.Parse(border4.Text);
                _ramBorderSettings[3].Value = int.Parse(border6.Text);
                _delaySettings[0].Value = int.Parse(delay1.Text);
                _delaySettings[1].Value = int.Parse(delay2.Text);
                _delaySettings[2].Value = int.Parse(delay3.Text);
                _settingRepository.Update(_ramBorderSettings[1]);
                _settingRepository.Update(_ramBorderSettings[2]);
                _settingRepository.Update(_ramBorderSettings[3]);
                _settingRepository.Update(_delaySettings[0]);
                _settingRepository.Update(_delaySettings[1]);
                _settingRepository.Update(_delaySettings[2]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Values!");
            }
        }
    }
}
