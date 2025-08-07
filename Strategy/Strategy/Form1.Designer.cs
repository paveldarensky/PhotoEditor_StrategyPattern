namespace Strategy
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Tools = new System.Windows.Forms.Panel();
            this.button_EraserBrush = new System.Windows.Forms.Button();
            this.button_BlurBrush = new System.Windows.Forms.Button();
            this.button_PencilBrush = new System.Windows.Forms.Button();
            this.button_SimpleBrush = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button_SharpenFilter = new System.Windows.Forms.Button();
            this.button_BlurFilter = new System.Windows.Forms.Button();
            this.button_InvertFilter = new System.Windows.Forms.Button();
            this.button_BlackWhiteFilter = new System.Windows.Forms.Button();
            this.contextMenuStrip_Brush = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeBrushColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBrushSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Projects = new System.Windows.Forms.TabControl();
            this.menuStrip_Main.SuspendLayout();
            this.panel_Tools.SuspendLayout();
            this.contextMenuStrip_Brush.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ServiceToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip_Main.Size = new System.Drawing.Size(1200, 32);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip_Main";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ExitToolStripMenuItem,
            this.CloseCurrentTabToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.FileToolStripMenuItem.Tag = "menuFile";
            this.FileToolStripMenuItem.Text = "&Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CreateToolStripMenuItem.Image")));
            this.CreateToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.CreateToolStripMenuItem.Tag = "submenuNew";
            this.CreateToolStripMenuItem.Text = "&Создать";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.OpenToolStripMenuItem.Tag = "submenuOpen";
            this.OpenToolStripMenuItem.Text = "&Открыть";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(313, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.SaveToolStripMenuItem.Tag = "submenuSave";
            this.SaveToolStripMenuItem.Text = "&Сохранить";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.SaveAsToolStripMenuItem.Tag = "submenuSaveAs";
            this.SaveAsToolStripMenuItem.Text = "Сохранить &как";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.ExitToolStripMenuItem.Tag = "submenuExit";
            this.ExitToolStripMenuItem.Text = "Вы&ход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // CloseCurrentTabToolStripMenuItem
            // 
            this.CloseCurrentTabToolStripMenuItem.Image = global::Strategy.Properties.Resources.close;
            this.CloseCurrentTabToolStripMenuItem.Name = "CloseCurrentTabToolStripMenuItem";
            this.CloseCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.CloseCurrentTabToolStripMenuItem.Tag = "submenuCloseTab";
            this.CloseCurrentTabToolStripMenuItem.Text = "Закрыть текущую вкладку";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionCancelToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.EditToolStripMenuItem.Tag = "menuEdit";
            this.EditToolStripMenuItem.Text = "&Правка";
            // 
            // ActionCancelToolStripMenuItem
            // 
            this.ActionCancelToolStripMenuItem.Name = "ActionCancelToolStripMenuItem";
            this.ActionCancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ActionCancelToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.ActionCancelToolStripMenuItem.Tag = "submenuUndo";
            this.ActionCancelToolStripMenuItem.Text = "&Отмена действия";
            this.ActionCancelToolStripMenuItem.Click += new System.EventHandler(this.ActionCancelToolStripMenuItem_Click);
            // 
            // ServiceToolStripMenuItem
            // 
            this.ServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem";
            this.ServiceToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.ServiceToolStripMenuItem.Tag = "menuService";
            this.ServiceToolStripMenuItem.Text = "&Сервис";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SettingsToolStripMenuItem.Tag = "submenuSettings";
            this.SettingsToolStripMenuItem.Text = "&Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.HelpToolStripMenuItem.Tag = "menuHelp";
            this.HelpToolStripMenuItem.Text = "Спра&вка";
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AboutProgramToolStripMenuItem.Tag = "submenuAbout";
            this.AboutProgramToolStripMenuItem.Text = "&О программе...";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // panel_Tools
            // 
            this.panel_Tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Tools.Controls.Add(this.button_EraserBrush);
            this.panel_Tools.Controls.Add(this.button_BlurBrush);
            this.panel_Tools.Controls.Add(this.button_PencilBrush);
            this.panel_Tools.Controls.Add(this.button_SimpleBrush);
            this.panel_Tools.Controls.Add(this.splitter1);
            this.panel_Tools.Controls.Add(this.button_SharpenFilter);
            this.panel_Tools.Controls.Add(this.button_BlurFilter);
            this.panel_Tools.Controls.Add(this.button_InvertFilter);
            this.panel_Tools.Controls.Add(this.button_BlackWhiteFilter);
            this.panel_Tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Tools.Enabled = false;
            this.panel_Tools.Location = new System.Drawing.Point(0, 32);
            this.panel_Tools.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Tools.Name = "panel_Tools";
            this.panel_Tools.Size = new System.Drawing.Size(1200, 40);
            this.panel_Tools.TabIndex = 1;
            // 
            // button_EraserBrush
            // 
            this.button_EraserBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_EraserBrush.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_EraserBrush.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_EraserBrush.FlatAppearance.BorderSize = 3;
            this.button_EraserBrush.Location = new System.Drawing.Point(227, 0);
            this.button_EraserBrush.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_EraserBrush.Name = "button_EraserBrush";
            this.button_EraserBrush.Size = new System.Drawing.Size(32, 38);
            this.button_EraserBrush.TabIndex = 8;
            this.button_EraserBrush.UseVisualStyleBackColor = true;
            this.button_EraserBrush.Click += new System.EventHandler(this.button_EraserBrush_Click);
            // 
            // button_BlurBrush
            // 
            this.button_BlurBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BlurBrush.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_BlurBrush.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_BlurBrush.FlatAppearance.BorderSize = 3;
            this.button_BlurBrush.Location = new System.Drawing.Point(195, 0);
            this.button_BlurBrush.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_BlurBrush.Name = "button_BlurBrush";
            this.button_BlurBrush.Size = new System.Drawing.Size(32, 38);
            this.button_BlurBrush.TabIndex = 7;
            this.button_BlurBrush.UseVisualStyleBackColor = true;
            this.button_BlurBrush.Click += new System.EventHandler(this.button_BlurBrush_Click);
            // 
            // button_PencilBrush
            // 
            this.button_PencilBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_PencilBrush.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_PencilBrush.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_PencilBrush.FlatAppearance.BorderSize = 3;
            this.button_PencilBrush.Location = new System.Drawing.Point(163, 0);
            this.button_PencilBrush.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_PencilBrush.Name = "button_PencilBrush";
            this.button_PencilBrush.Size = new System.Drawing.Size(32, 38);
            this.button_PencilBrush.TabIndex = 6;
            this.button_PencilBrush.UseVisualStyleBackColor = true;
            this.button_PencilBrush.Click += new System.EventHandler(this.button_PencilBrush_Click);
            // 
            // button_SimpleBrush
            // 
            this.button_SimpleBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SimpleBrush.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_SimpleBrush.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_SimpleBrush.FlatAppearance.BorderSize = 3;
            this.button_SimpleBrush.Location = new System.Drawing.Point(131, 0);
            this.button_SimpleBrush.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_SimpleBrush.Name = "button_SimpleBrush";
            this.button_SimpleBrush.Size = new System.Drawing.Size(32, 38);
            this.button_SimpleBrush.TabIndex = 5;
            this.button_SimpleBrush.UseVisualStyleBackColor = true;
            this.button_SimpleBrush.Click += new System.EventHandler(this.button_SimpleBrush_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Gray;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(128, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 38);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // button_SharpenFilter
            // 
            this.button_SharpenFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SharpenFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_SharpenFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_SharpenFilter.FlatAppearance.BorderSize = 3;
            this.button_SharpenFilter.Location = new System.Drawing.Point(96, 0);
            this.button_SharpenFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_SharpenFilter.Name = "button_SharpenFilter";
            this.button_SharpenFilter.Size = new System.Drawing.Size(32, 38);
            this.button_SharpenFilter.TabIndex = 3;
            this.button_SharpenFilter.UseVisualStyleBackColor = true;
            // 
            // button_BlurFilter
            // 
            this.button_BlurFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BlurFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_BlurFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_BlurFilter.FlatAppearance.BorderSize = 3;
            this.button_BlurFilter.Location = new System.Drawing.Point(64, 0);
            this.button_BlurFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_BlurFilter.Name = "button_BlurFilter";
            this.button_BlurFilter.Size = new System.Drawing.Size(32, 38);
            this.button_BlurFilter.TabIndex = 2;
            this.button_BlurFilter.UseVisualStyleBackColor = true;
            // 
            // button_InvertFilter
            // 
            this.button_InvertFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_InvertFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_InvertFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_InvertFilter.FlatAppearance.BorderSize = 3;
            this.button_InvertFilter.Location = new System.Drawing.Point(32, 0);
            this.button_InvertFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_InvertFilter.Name = "button_InvertFilter";
            this.button_InvertFilter.Size = new System.Drawing.Size(32, 38);
            this.button_InvertFilter.TabIndex = 1;
            this.button_InvertFilter.UseVisualStyleBackColor = true;
            // 
            // button_BlackWhiteFilter
            // 
            this.button_BlackWhiteFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BlackWhiteFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_BlackWhiteFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_BlackWhiteFilter.Location = new System.Drawing.Point(0, 0);
            this.button_BlackWhiteFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_BlackWhiteFilter.Name = "button_BlackWhiteFilter";
            this.button_BlackWhiteFilter.Size = new System.Drawing.Size(32, 38);
            this.button_BlackWhiteFilter.TabIndex = 0;
            this.button_BlackWhiteFilter.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip_Brush
            // 
            this.contextMenuStrip_Brush.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip_Brush.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Brush.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeBrushColorToolStripMenuItem,
            this.ChangeBrushSizeToolStripMenuItem});
            this.contextMenuStrip_Brush.Name = "contextMenuStrip_Brush";
            this.contextMenuStrip_Brush.Size = new System.Drawing.Size(211, 84);
            // 
            // ChangeBrushColorToolStripMenuItem
            // 
            this.ChangeBrushColorToolStripMenuItem.Name = "ChangeBrushColorToolStripMenuItem";
            this.ChangeBrushColorToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.ChangeBrushColorToolStripMenuItem.Tag = "contextBrushColor";
            this.ChangeBrushColorToolStripMenuItem.Text = "Цвет кисти";
            this.ChangeBrushColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeBrushColorToolStripMenuItem_Click);
            // 
            // ChangeBrushSizeToolStripMenuItem
            // 
            this.ChangeBrushSizeToolStripMenuItem.Name = "ChangeBrushSizeToolStripMenuItem";
            this.ChangeBrushSizeToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.ChangeBrushSizeToolStripMenuItem.Tag = "contextBrushSize";
            this.ChangeBrushSizeToolStripMenuItem.Text = "Размер кисти";
            this.ChangeBrushSizeToolStripMenuItem.Click += new System.EventHandler(this.ChangeBrushSizeToolStripMenuItem_Click);
            // 
            // tabControl_Projects
            // 
            this.tabControl_Projects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Projects.Location = new System.Drawing.Point(0, 72);
            this.tabControl_Projects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl_Projects.Name = "tabControl_Projects";
            this.tabControl_Projects.SelectedIndex = 0;
            this.tabControl_Projects.Size = new System.Drawing.Size(1200, 681);
            this.tabControl_Projects.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 753);
            this.Controls.Add(this.tabControl_Projects);
            this.Controls.Add(this.panel_Tools);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фоторедактор";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.panel_Tools.ResumeLayout(false);
            this.contextMenuStrip_Brush.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActionCancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Tools;
        private System.Windows.Forms.Button button_BlackWhiteFilter;
        private System.Windows.Forms.Button button_BlurFilter;
        private System.Windows.Forms.Button button_InvertFilter;
        private System.Windows.Forms.Button button_SharpenFilter;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button_BlurBrush;
        private System.Windows.Forms.Button button_PencilBrush;
        private System.Windows.Forms.Button button_SimpleBrush;
        private System.Windows.Forms.Button button_EraserBrush;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Brush;
        private System.Windows.Forms.ToolStripMenuItem ChangeBrushColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeBrushSizeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_Projects;
        private System.Windows.Forms.ToolStripMenuItem CloseCurrentTabToolStripMenuItem;
    }
}

