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
    public partial class Form_ChangeBrushSize : Form
    {
        public double SelectedSize { get; private set; }

        public Form_ChangeBrushSize()
        {
            this.Icon = Properties.Resources.PhotoEditor;
            InitializeComponent();
            SettingsManager.Instance.ApplySettingsToForm(this);
            SelectedSize = 5;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            // Пытаемся преобразовать введенное значение в double
            if (double.TryParse(textBox_BrushSize.Text, out double newSize))
            {
                // Проверяем, что введенное значение в допустимом диапазоне
                if (newSize >= 0.5 && newSize <= 25)
                {
                    SelectedSize = newSize;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                    SettingsManager.Instance.Translate("msgInvalidBrushRange"),
                    SettingsManager.Instance.Translate("msgInputError"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show(
                SettingsManager.Instance.Translate("msgInvalidBrushNumber"),
                SettingsManager.Instance.Translate("msgInputError"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }
        }
    }
}
