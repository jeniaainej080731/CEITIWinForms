namespace Lab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FirstForm = new Button();
            SecondForm = new Button();
            ThirdForm = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // FirstForm
            // 
            FirstForm.Location = new Point(332, 102);
            FirstForm.Name = "FirstForm";
            FirstForm.Size = new Size(127, 70);
            FirstForm.TabIndex = 0;
            FirstForm.Text = "Convert kg's";
            FirstForm.UseVisualStyleBackColor = true;
            FirstForm.Click += FirstForm_Click;
            // 
            // SecondForm
            // 
            SecondForm.Location = new Point(332, 193);
            SecondForm.Name = "SecondForm";
            SecondForm.Size = new Size(127, 70);
            SecondForm.TabIndex = 0;
            SecondForm.Text = "Convert km's";
            SecondForm.UseVisualStyleBackColor = true;
            SecondForm.Click += SecondForm_Click;
            // 
            // ThirdForm
            // 
            ThirdForm.Location = new Point(332, 280);
            ThirdForm.Name = "ThirdForm";
            ThirdForm.Size = new Size(127, 70);
            ThirdForm.TabIndex = 0;
            ThirdForm.Text = "Convert LEI's";
            ThirdForm.UseVisualStyleBackColor = true;
            ThirdForm.Click += ThirdForm_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(348, 426);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(98, 40);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(CloseButton);
            Controls.Add(ThirdForm);
            Controls.Add(SecondForm);
            Controls.Add(FirstForm);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Button FirstForm;
        private Button SecondForm;
        private Button ThirdForm;
        private Button CloseButton;
    }
}
