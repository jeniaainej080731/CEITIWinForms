namespace Lab2
{
    partial class Third
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Third));
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
            ConvertButton.Location = new Point(153, 126);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(94, 29);
            ConvertButton.TabIndex = 17;
            ConvertButton.Text = "Convert!";
            ConvertButton.UseCompatibleTextRendering = true;
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(40, 191);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 16;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(391, 83);
            Result.Name = "Result";
            Result.Size = new Size(0, 20);
            Result.TabIndex = 15;
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(142, 80);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(125, 27);
            InputTextBox.TabIndex = 14;
            InputTextBox.TextChanged += InputTextBox_TextChanged;
            InputTextBox.KeyPress += InputTextBox_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "USD", "EUR", "UAH", "RON", "RUB" });
            comboBox1.Location = new Point(325, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(71, 31);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 12;
            label1.Text = "Convert leu into:";
            // 
            // Third
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(575, 251);
            Controls.Add(ConvertButton);
            Controls.Add(CloseButton);
            Controls.Add(Result);
            Controls.Add(InputTextBox);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Third";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Third";
            Load += Third_Load;
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