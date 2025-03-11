namespace Lab6
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            DrawSnowmanButton = new Button();
            DrawBallsButton = new Button();
            DrawDotsButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(558, 374);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += PictureBox1_Paint;
            // 
            // DrawSnowmanButton
            // 
            DrawSnowmanButton.Location = new Point(24, 58);
            DrawSnowmanButton.Name = "DrawSnowmanButton";
            DrawSnowmanButton.Size = new Size(160, 50);
            DrawSnowmanButton.TabIndex = 1;
            DrawSnowmanButton.Text = "Draw snowman";
            DrawSnowmanButton.UseVisualStyleBackColor = true;
            DrawSnowmanButton.Click += DrawSnowmanButton_Click;
            // 
            // DrawBallsButton
            // 
            DrawBallsButton.Location = new Point(205, 58);
            DrawBallsButton.Name = "DrawBallsButton";
            DrawBallsButton.Size = new Size(160, 50);
            DrawBallsButton.TabIndex = 2;
            DrawBallsButton.Text = "Draw ball";
            DrawBallsButton.UseVisualStyleBackColor = true;
            // 
            // DrawDotsButton
            // 
            DrawDotsButton.Location = new Point(468, 58);
            DrawDotsButton.Name = "DrawDotsButton";
            DrawDotsButton.Size = new Size(82, 50);
            DrawDotsButton.TabIndex = 3;
            DrawDotsButton.Text = "Draw dots";
            DrawDotsButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(DrawDotsButton);
            Controls.Add(DrawBallsButton);
            Controls.Add(DrawSnowmanButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Draw!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button DrawSnowmanButton;
        private Button DrawBallsButton;
        private Button DrawDotsButton;
        private System.Windows.Forms.Timer timer1;
    }
}
