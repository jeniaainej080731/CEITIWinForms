namespace Lab2
{
    partial class First
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            label1 = new Label();
            comboBox1 = new ComboBox();
            InputTextBox = new TextBox();
            Result = new Label();
            CloseButton = new Button();
            ConvertButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(238, 28);
            label1.TabIndex = 0;
            label1.Text = "Convert killogramms into:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "American Pound", "Russian Pound", "Russian Pood" });
            comboBox1.Location = new Point(309, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(126, 90);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(125, 27);
            InputTextBox.TabIndex = 2;
            InputTextBox.TextChanged += InputTextBox_TextChanged;
            InputTextBox.KeyPress += InputTextBox_KeyPress;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(375, 93);
            Result.Name = "Result";
            Result.Size = new Size(0, 20);
            Result.TabIndex = 3;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(24, 201);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ConvertButton
            // 
            ConvertButton.Enabled = false;
            ConvertButton.Location = new Point(137, 136);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(94, 29);
            ConvertButton.TabIndex = 5;
            ConvertButton.Text = "Convert!";
            ConvertButton.UseCompatibleTextRendering = true;
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // First
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(575, 251);
            Controls.Add(ConvertButton);
            Controls.Add(CloseButton);
            Controls.Add(Result);
            Controls.Add(InputTextBox);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "First";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fisrt";
            Load += First_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private TextBox InputTextBox;
        private Label Result;
        private Button CloseButton;
        private Button ConvertButton;
    }
}