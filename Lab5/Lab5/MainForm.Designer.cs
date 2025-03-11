namespace Lab5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            FigureTypeComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            FigureComboBox = new ComboBox();
            InputSizesButton = new Button();
            SuspendLayout();
            // 
            // FigureTypeComboBox
            // 
            FigureTypeComboBox.FormattingEnabled = true;
            FigureTypeComboBox.Location = new Point(163, 30);
            FigureTypeComboBox.Name = "FigureTypeComboBox";
            FigureTypeComboBox.Size = new Size(151, 28);
            FigureTypeComboBox.TabIndex = 0;
            FigureTypeComboBox.SelectedIndexChanged += FigureTypeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Choose type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 99);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 2;
            label2.Text = "Choose figure";
            // 
            // FigureComboBox
            // 
            FigureComboBox.FormattingEnabled = true;
            FigureComboBox.Location = new Point(163, 96);
            FigureComboBox.Name = "FigureComboBox";
            FigureComboBox.Size = new Size(151, 28);
            FigureComboBox.TabIndex = 3;
            // 
            // InputSizesButton
            // 
            InputSizesButton.Location = new Point(413, 33);
            InputSizesButton.Name = "InputSizesButton";
            InputSizesButton.Size = new Size(94, 29);
            InputSizesButton.TabIndex = 4;
            InputSizesButton.Text = "Input sizes";
            InputSizesButton.UseVisualStyleBackColor = true;
            InputSizesButton.Click += InputSizesButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 559);
            Controls.Add(InputSizesButton);
            Controls.Add(FigureComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FigureTypeComboBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geometrica Figures";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FigureTypeComboBox;
        private Label label1;
        private Label label2;
        private ComboBox FigureComboBox;
        private GroupBox InputsGroupBox;
        private Button InputSizesButton;
    }
}
