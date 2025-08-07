﻿using System;
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
    public partial class Form_NewCanvasSize : Form
    {
        public int CanvasWidth => (int)numericUpDown_Width.Value;
        public int CanvasHeight => (int)numericUpDown_Height.Value;

        public Form_NewCanvasSize()
        {
            InitializeComponent();
            SettingsManager.Instance.ApplySettingsToForm(this);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
