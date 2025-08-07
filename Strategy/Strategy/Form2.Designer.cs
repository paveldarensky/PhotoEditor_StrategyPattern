namespace Strategy
{
    partial class Form_ChangeBrushSize
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
            this.textBox_BrushSize = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_BrushSize
            // 
            this.textBox_BrushSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_BrushSize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BrushSize.Location = new System.Drawing.Point(0, 0);
            this.textBox_BrushSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_BrushSize.Name = "textBox_BrushSize";
            this.textBox_BrushSize.Size = new System.Drawing.Size(257, 35);
            this.textBox_BrushSize.TabIndex = 0;
            this.textBox_BrushSize.Text = "5";
            // 
            // button_OK
            // 
            this.button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OK.Location = new System.Drawing.Point(0, 35);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(257, 45);
            this.button_OK.TabIndex = 1;
            this.button_OK.Tag = "btnOK";
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_ChangeBrushSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 80);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_BrushSize);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ChangeBrushSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "formBrushSize";
            this.Text = "Размер кисти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_BrushSize;
        private System.Windows.Forms.Button button_OK;
    }
}