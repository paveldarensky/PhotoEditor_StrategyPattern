namespace Strategy
{
    partial class Form_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_Settings = new System.Windows.Forms.TabControl();
            this.tabPage_Theme = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Theme = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_ThemeDark = new System.Windows.Forms.RadioButton();
            this.radioButton_ThemeLight = new System.Windows.Forms.RadioButton();
            this.tabPage_Language = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Language = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_LanguageENG = new System.Windows.Forms.RadioButton();
            this.radioButton_LanguageRUS = new System.Windows.Forms.RadioButton();
            this.button_Apply = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Settings.SuspendLayout();
            this.tabControl_Settings.SuspendLayout();
            this.tabPage_Theme.SuspendLayout();
            this.tableLayoutPanel_Theme.SuspendLayout();
            this.tabPage_Language.SuspendLayout();
            this.tableLayoutPanel_Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Settings
            // 
            this.tableLayoutPanel_Settings.ColumnCount = 1;
            this.tableLayoutPanel_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Settings.Controls.Add(this.tabControl_Settings, 0, 0);
            this.tableLayoutPanel_Settings.Controls.Add(this.button_Apply, 0, 1);
            this.tableLayoutPanel_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Settings.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Settings.Name = "tableLayoutPanel_Settings";
            this.tableLayoutPanel_Settings.RowCount = 2;
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.09882F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.90119F));
            this.tableLayoutPanel_Settings.Size = new System.Drawing.Size(382, 253);
            this.tableLayoutPanel_Settings.TabIndex = 0;
            // 
            // tabControl_Settings
            // 
            this.tabControl_Settings.Controls.Add(this.tabPage_Theme);
            this.tabControl_Settings.Controls.Add(this.tabPage_Language);
            this.tabControl_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Settings.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Settings.Name = "tabControl_Settings";
            this.tabControl_Settings.SelectedIndex = 0;
            this.tabControl_Settings.Size = new System.Drawing.Size(376, 183);
            this.tabControl_Settings.TabIndex = 0;
            // 
            // tabPage_Theme
            // 
            this.tabPage_Theme.Controls.Add(this.tableLayoutPanel_Theme);
            this.tabPage_Theme.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Theme.Name = "tabPage_Theme";
            this.tabPage_Theme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Theme.Size = new System.Drawing.Size(368, 142);
            this.tabPage_Theme.TabIndex = 0;
            this.tabPage_Theme.Tag = "lblTheme";
            this.tabPage_Theme.Text = "Тема";
            this.tabPage_Theme.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Theme
            // 
            this.tableLayoutPanel_Theme.ColumnCount = 1;
            this.tableLayoutPanel_Theme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Theme.Controls.Add(this.radioButton_ThemeDark, 0, 1);
            this.tableLayoutPanel_Theme.Controls.Add(this.radioButton_ThemeLight, 0, 0);
            this.tableLayoutPanel_Theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Theme.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Theme.Name = "tableLayoutPanel_Theme";
            this.tableLayoutPanel_Theme.RowCount = 2;
            this.tableLayoutPanel_Theme.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Theme.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Theme.Size = new System.Drawing.Size(362, 136);
            this.tableLayoutPanel_Theme.TabIndex = 0;
            // 
            // radioButton_ThemeDark
            // 
            this.radioButton_ThemeDark.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton_ThemeDark.AutoSize = true;
            this.radioButton_ThemeDark.Location = new System.Drawing.Point(15, 86);
            this.radioButton_ThemeDark.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.radioButton_ThemeDark.Name = "radioButton_ThemeDark";
            this.radioButton_ThemeDark.Size = new System.Drawing.Size(99, 32);
            this.radioButton_ThemeDark.TabIndex = 1;
            this.radioButton_ThemeDark.TabStop = true;
            this.radioButton_ThemeDark.Tag = "radioDark";
            this.radioButton_ThemeDark.Text = "Темная";
            this.radioButton_ThemeDark.UseVisualStyleBackColor = true;
            // 
            // radioButton_ThemeLight
            // 
            this.radioButton_ThemeLight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton_ThemeLight.AutoSize = true;
            this.radioButton_ThemeLight.Location = new System.Drawing.Point(15, 18);
            this.radioButton_ThemeLight.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.radioButton_ThemeLight.Name = "radioButton_ThemeLight";
            this.radioButton_ThemeLight.Size = new System.Drawing.Size(105, 32);
            this.radioButton_ThemeLight.TabIndex = 0;
            this.radioButton_ThemeLight.TabStop = true;
            this.radioButton_ThemeLight.Tag = "radioLight";
            this.radioButton_ThemeLight.Text = "Светлая";
            this.radioButton_ThemeLight.UseVisualStyleBackColor = true;
            // 
            // tabPage_Language
            // 
            this.tabPage_Language.Controls.Add(this.tableLayoutPanel_Language);
            this.tabPage_Language.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Language.Name = "tabPage_Language";
            this.tabPage_Language.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Language.Size = new System.Drawing.Size(368, 142);
            this.tabPage_Language.TabIndex = 1;
            this.tabPage_Language.Tag = "lblLanguage";
            this.tabPage_Language.Text = "Язык";
            this.tabPage_Language.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Language
            // 
            this.tableLayoutPanel_Language.ColumnCount = 1;
            this.tableLayoutPanel_Language.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Language.Controls.Add(this.radioButton_LanguageENG, 0, 1);
            this.tableLayoutPanel_Language.Controls.Add(this.radioButton_LanguageRUS, 0, 0);
            this.tableLayoutPanel_Language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Language.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Language.Name = "tableLayoutPanel_Language";
            this.tableLayoutPanel_Language.RowCount = 2;
            this.tableLayoutPanel_Language.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Language.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Language.Size = new System.Drawing.Size(362, 136);
            this.tableLayoutPanel_Language.TabIndex = 1;
            // 
            // radioButton_LanguageENG
            // 
            this.radioButton_LanguageENG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton_LanguageENG.AutoSize = true;
            this.radioButton_LanguageENG.Location = new System.Drawing.Point(15, 86);
            this.radioButton_LanguageENG.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.radioButton_LanguageENG.Name = "radioButton_LanguageENG";
            this.radioButton_LanguageENG.Size = new System.Drawing.Size(72, 32);
            this.radioButton_LanguageENG.TabIndex = 1;
            this.radioButton_LanguageENG.TabStop = true;
            this.radioButton_LanguageENG.Text = "ENG";
            this.radioButton_LanguageENG.UseVisualStyleBackColor = true;
            // 
            // radioButton_LanguageRUS
            // 
            this.radioButton_LanguageRUS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton_LanguageRUS.AutoSize = true;
            this.radioButton_LanguageRUS.Location = new System.Drawing.Point(15, 18);
            this.radioButton_LanguageRUS.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.radioButton_LanguageRUS.Name = "radioButton_LanguageRUS";
            this.radioButton_LanguageRUS.Size = new System.Drawing.Size(67, 32);
            this.radioButton_LanguageRUS.TabIndex = 0;
            this.radioButton_LanguageRUS.TabStop = true;
            this.radioButton_LanguageRUS.Text = "РУС";
            this.radioButton_LanguageRUS.UseVisualStyleBackColor = true;
            // 
            // button_Apply
            // 
            this.button_Apply.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Apply.AutoSize = true;
            this.button_Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Apply.Location = new System.Drawing.Point(241, 202);
            this.button_Apply.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(126, 38);
            this.button_Apply.TabIndex = 1;
            this.button_Apply.Tag = "btnApply";
            this.button_Apply.Text = "Применить";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.tableLayoutPanel_Settings);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Settings";
            this.Tag = "formSettings";
            this.Text = "Настройки";
            this.tableLayoutPanel_Settings.ResumeLayout(false);
            this.tableLayoutPanel_Settings.PerformLayout();
            this.tabControl_Settings.ResumeLayout(false);
            this.tabPage_Theme.ResumeLayout(false);
            this.tableLayoutPanel_Theme.ResumeLayout(false);
            this.tableLayoutPanel_Theme.PerformLayout();
            this.tabPage_Language.ResumeLayout(false);
            this.tableLayoutPanel_Language.ResumeLayout(false);
            this.tableLayoutPanel_Language.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Settings;
        private System.Windows.Forms.TabControl tabControl_Settings;
        private System.Windows.Forms.TabPage tabPage_Theme;
        private System.Windows.Forms.TabPage tabPage_Language;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Theme;
        private System.Windows.Forms.RadioButton radioButton_ThemeDark;
        private System.Windows.Forms.RadioButton radioButton_ThemeLight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Language;
        private System.Windows.Forms.RadioButton radioButton_LanguageENG;
        private System.Windows.Forms.RadioButton radioButton_LanguageRUS;
    }
}