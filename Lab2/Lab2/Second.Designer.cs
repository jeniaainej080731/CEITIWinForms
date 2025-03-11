namespace Lab2
{
    partial class Second
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Second));
            ConvertButton = new Button();
            CloseButton = new Button();
            Result = new Label();
            InputTextBox = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ConvertButton
            // 
            ConvertButton.Enabled = false;
            ConvertButton.Location = new Point(143, 124);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(94, 29);
            ConvertButton.TabIndex = 11;
            ConvertButton.Text = "Convert!";
            ConvertButton.UseCompatibleTextRendering = true;
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(30, 189);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 10;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(381, 81);
            Result.Name = "Result";
            Result.Size = new Size(0, 20);
            Result.TabIndex = 9;
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(132, 78);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(125, 27);
            InputTextBox.TabIndex = 8;
            InputTextBox.TextChanged += InputTextBox_TextChanged;
            InputTextBox.KeyPress += InputTextBox_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "meters/s", "knots", "miles/s", "foots/s" });
            comboBox1.Location = new Point(315, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(61, 29);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 6;
            label1.Text = "Convert km/h into:";
            // 
            // Second
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(575, 251);
            Controls.Add(ConvertButton);
            Controls.Add(CloseButton);
            Controls.Add(Result);
            Controls.Add(InputTextBox);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Second";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Second";
            Load += Second_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConvertButton;
        private Button CloseButton;
        private Label Result;
        private TextBox InputTextBox;
        private ComboBox comboBox1;
        private Label label1;
    }
}