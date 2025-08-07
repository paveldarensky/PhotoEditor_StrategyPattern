using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
            SettingsManager.Instance.ApplySettingsToForm(this);
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            if (radioButton_ThemeLight.Checked)
                SettingsManager.Instance.SetTheme(Theme.Light);
            else if (radioButton_ThemeDark.Checked)
                SettingsManager.Instance.SetTheme(Theme.Dark);

            if (radioButton_LanguageRUS.Checked)
                SettingsManager.Instance.SetLanguage(Language.Russian);
            else if (radioButton_LanguageENG.Checked)
                SettingsManager.Instance.SetLanguage(Language.English);

            // Применить настройки ко всем открытым формам
            foreach (Form form in Application.OpenForms)
            {
                SettingsManager.Instance.ApplySettingsToForm(form);
            }

            MessageBox.Show("Настройки применены");
            Close();
        }
    }
}
