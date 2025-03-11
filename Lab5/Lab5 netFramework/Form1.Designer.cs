namespace Lab5_netFramework
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose figure";
            // 
            // FigureTypeComboBox
            // 
            this.FigureTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FigureTypeComboBox.FormattingEnabled = true;
            this.FigureTypeComboBox.Location = new System.Drawing.Point(159, 32);
            this.FigureTypeComboBox.Name = "FigureTypeComboBox";
            this.FigureTypeComboBox.Size = new System.Drawing.Size(128, 24);
            this.FigureTypeComboBox.TabIndex = 2;
            this.FigureTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FigureTypeComboBox_SelectedIndexChanged);
            // 
            // FigureComboBox
            // 
            this.FigureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FigureComboBox.FormattingEnabled = true;
            this.FigureComboBox.Location = new System.Drawing.Point(159, 88);
            this.FigureComboBox.Name = "FigureComboBox";
            this.FigureComboBox.Size = new System.Drawing.Size(128, 24);
            this.FigureComboBox.TabIndex = 2;
            // 
            // InputSizesButton
            // 
            this.InputSizesButton.Location = new System.Drawing.Point(365, 32);
            this.InputSizesButton.Name = "InputSizesButton";
            this.InputSizesButton.Size = new System.Drawing.Size(111, 23);
            this.InputSizesButton.TabIndex = 3;
            this.InputSizesButton.Text = "Input sizes";
            this.InputSizesButton.UseVisualStyleBackColor = true;
            this.InputSizesButton.Click += new System.EventHandler(this.InputSizesButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 397);
            this.panel1.TabIndex = 4;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(365, 92);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(111, 23);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 572);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.panel1);
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
            this.Text = "GeometricaFigures";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CalculateButton;
    }
}

