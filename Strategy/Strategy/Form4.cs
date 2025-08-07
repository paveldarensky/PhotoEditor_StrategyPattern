using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
            SettingsManager.Instance.ApplySettingsToForm(this);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_GithubDeveloperLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Указываем, что ссылка "посещена" (можно по желанию)
            linkLabel_GithubDeveloperLink.LinkVisited = true;

            // Открываем ссылку в браузере
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/paveldarensky/",
                UseShellExecute = true
            });
        }
    }
}
