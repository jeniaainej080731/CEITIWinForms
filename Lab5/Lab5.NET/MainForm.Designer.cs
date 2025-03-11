namespace Lab5.NET
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FigureTypeComboBox = new System.Windows.Forms.ComboBox();
            this.FigureComboBox = new System.Windows.Forms.ComboBox();
            this.InputSizesButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(155)))));
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose figure";
            // 
            // FigureTypeComboBox
            // 
            this.FigureTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.FigureTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FigureTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FigureTypeComboBox.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FigureTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(155)))));
            this.FigureTypeComboBox.FormattingEnabled = true;
            this.FigureTypeComboBox.Location = new System.Drawing.Point(186, 26);
            this.FigureTypeComboBox.Name = "FigureTypeComboBox";
            this.FigureTypeComboBox.Size = new System.Drawing.Size(156, 28);
            this.FigureTypeComboBox.TabIndex = 1;
            this.FigureTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FigureTypeComboBox_SelectedIndexChanged);
            // 
            // FigureComboBox
            // 
            this.FigureComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.FigureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FigureComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FigureComboBox.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.FigureComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(155)))));
            this.FigureComboBox.FormattingEnabled = true;
            this.FigureComboBox.Location = new System.Drawing.Point(186, 83);
            this.FigureComboBox.Name = "FigureComboBox";
            this.FigureComboBox.Size = new System.Drawing.Size(156, 28);
            this.FigureComboBox.TabIndex = 1;
            // 
            // InputSizesButton
            // 
            this.InputSizesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.InputSizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputSizesButton.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.InputSizesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(155)))));
            this.InputSizesButton.Location = new System.Drawing.Point(372, 26);
            this.InputSizesButton.Name = "InputSizesButton";
            this.InputSizesButton.Size = new System.Drawing.Size(128, 31);
            this.InputSizesButton.TabIndex = 2;
            this.InputSizesButton.Text = "Input sizes";
            this.InputSizesButton.UseVisualStyleBackColor = false;
            this.InputSizesButton.Click += new System.EventHandler(this.InputSizesButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.CalculateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(155)))));
            this.CalculateButton.Location = new System.Drawing.Point(372, 80);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(128, 31);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 292);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InputSizesButton);
            this.Controls.Add(this.FigureComboBox);
            this.Controls.Add(this.FigureTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geometrica Figures";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FigureTypeComboBox;
        private System.Windows.Forms.ComboBox FigureComboBox;
        private System.Windows.Forms.Button InputSizesButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Panel panel1;
    }
}

