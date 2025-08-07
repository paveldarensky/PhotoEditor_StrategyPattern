namespace Strategy
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.tableLayoutPanel_Labels = new System.Windows.Forms.TableLayoutPanel();
            this.label_ProgramVersion = new System.Windows.Forms.Label();
            this.label_DeveloperName = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.linkLabel_GithubDeveloperLink = new System.Windows.Forms.LinkLabel();
            this.button_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Labels.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Labels
            // 
            this.tableLayoutPanel_Labels.ColumnCount = 1;
            this.tableLayoutPanel_Labels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Labels.Controls.Add(this.label_ProgramVersion, 0, 0);
            this.tableLayoutPanel_Labels.Controls.Add(this.label_DeveloperName, 0, 1);
            this.tableLayoutPanel_Labels.Controls.Add(this.label_Description, 0, 2);
            this.tableLayoutPanel_Labels.Controls.Add(this.label_Copyright, 0, 3);
            this.tableLayoutPanel_Labels.Controls.Add(this.linkLabel_GithubDeveloperLink, 0, 4);
            this.tableLayoutPanel_Labels.Controls.Add(this.button_OK, 0, 5);
            this.tableLayoutPanel_Labels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Labels.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Labels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel_Labels.Name = "tableLayoutPanel_Labels";
            this.tableLayoutPanel_Labels.RowCount = 6;
            this.tableLayoutPanel_Labels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889F));
            this.tableLayoutPanel_Labels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111F));
            this.tableLayoutPanel_Labels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel_Labels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel_Labels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel_Labels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel_Labels.Size = new System.Drawing.Size(624, 358);
            this.tableLayoutPanel_Labels.TabIndex = 0;
            // 
            // label_ProgramVersion
            // 
            this.label_ProgramVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_ProgramVersion.AutoSize = true;
            this.label_ProgramVersion.Location = new System.Drawing.Point(3, 10);
            this.label_ProgramVersion.Name = "label_ProgramVersion";
            this.label_ProgramVersion.Size = new System.Drawing.Size(269, 28);
            this.label_ProgramVersion.TabIndex = 0;
            this.label_ProgramVersion.Tag = "lblVersion";
            this.label_ProgramVersion.Text = "Фоторедактор — версия 1.0";
            // 
            // label_DeveloperName
            // 
            this.label_DeveloperName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_DeveloperName.AutoSize = true;
            this.label_DeveloperName.Location = new System.Drawing.Point(3, 56);
            this.label_DeveloperName.Name = "label_DeveloperName";
            this.label_DeveloperName.Size = new System.Drawing.Size(279, 28);
            this.label_DeveloperName.TabIndex = 1;
            this.label_DeveloperName.Tag = "lblDeveloper";
            this.label_DeveloperName.Text = "Разработчик: Даренский П.А.\r\n";
            // 
            // label_Description
            // 
            this.label_Description.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(3, 93);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(557, 108);
            this.label_Description.TabIndex = 2;
            this.label_Description.Tag = "lblDescription";
            this.label_Description.Text = resources.GetString("label_Description.Text");
            // 
            // label_Copyright
            // 
            this.label_Copyright.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.Location = new System.Drawing.Point(3, 208);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(286, 28);
            this.label_Copyright.TabIndex = 3;
            this.label_Copyright.Tag = "lblCopyright";
            this.label_Copyright.Text = "© 2025. Все права защищены.";
            // 
            // linkLabel_GithubDeveloperLink
            // 
            this.linkLabel_GithubDeveloperLink.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel_GithubDeveloperLink.AutoSize = true;
            this.linkLabel_GithubDeveloperLink.Location = new System.Drawing.Point(3, 256);
            this.linkLabel_GithubDeveloperLink.Name = "linkLabel_GithubDeveloperLink";
            this.linkLabel_GithubDeveloperLink.Size = new System.Drawing.Size(351, 28);
            this.linkLabel_GithubDeveloperLink.TabIndex = 4;
            this.linkLabel_GithubDeveloperLink.TabStop = true;
            this.linkLabel_GithubDeveloperLink.Tag = "linkSource";
            this.linkLabel_GithubDeveloperLink.Text = "Источник: github.com/paveldarensky/";
            this.linkLabel_GithubDeveloperLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GithubDeveloperLink_LinkClicked);
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_OK.AutoSize = true;
            this.button_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OK.Location = new System.Drawing.Point(539, 309);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 13, 10, 13);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 36);
            this.button_OK.TabIndex = 5;
            this.button_OK.Tag = "btnOK";
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 358);
            this.Controls.Add(this.tableLayoutPanel_Labels);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "formAbout";
            this.Text = "О программе";
            this.tableLayoutPanel_Labels.ResumeLayout(false);
            this.tableLayoutPanel_Labels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Labels;
        private System.Windows.Forms.Label label_ProgramVersion;
        private System.Windows.Forms.Label label_DeveloperName;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Copyright;
        private System.Windows.Forms.LinkLabel linkLabel_GithubDeveloperLink;
        private System.Windows.Forms.Button button_OK;
    }
}