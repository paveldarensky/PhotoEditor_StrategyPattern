namespace Strategy
{
    partial class Form_NewCanvasSize
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
            this.numericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Height = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Height)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown_Width
            // 
            this.numericUpDown_Width.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Width.Location = new System.Drawing.Point(165, 14);
            this.numericUpDown_Width.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_Width.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_Width.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Width.Name = "numericUpDown_Width";
            this.numericUpDown_Width.Size = new System.Drawing.Size(154, 34);
            this.numericUpDown_Width.TabIndex = 0;
            this.numericUpDown_Width.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // numericUpDown_Height
            // 
            this.numericUpDown_Height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Height.Location = new System.Drawing.Point(165, 77);
            this.numericUpDown_Height.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_Height.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_Height.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Height.Name = "numericUpDown_Height";
            this.numericUpDown_Height.Size = new System.Drawing.Size(154, 34);
            this.numericUpDown_Height.TabIndex = 1;
            this.numericUpDown_Height.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_Cancel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Height, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Width, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_OK, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 205);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cancel.Location = new System.Drawing.Point(186, 144);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(112, 43);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Tag = "btnCancel";
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 2;
            this.label1.Tag = "lblWidth";
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 3;
            this.label2.Tag = "lblHeight";
            this.label2.Text = "Высота";
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OK.Location = new System.Drawing.Point(24, 144);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(112, 43);
            this.button_OK.TabIndex = 4;
            this.button_OK.Tag = "btnCreate";
            this.button_OK.Text = "Создать";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_NewCanvasSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 205);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_NewCanvasSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "formCreateEmptyCanvas";
            this.Text = "Создать пустой лист";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Height)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_Width;
        private System.Windows.Forms.NumericUpDown numericUpDown_Height;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_OK;
    }
}