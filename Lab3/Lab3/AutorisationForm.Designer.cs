namespace Lab3
{
    partial class AutorisationForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorisationForm));
            SignupLabel = new Label();
            ShowpassButton = new Button();
            panel1 = new Panel();
            CleanButton = new Guna.UI2.WinForms.Guna2Button();
            LoginButton = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            panel3 = new Panel();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            LoginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            guna2GradientPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // SignupLabel
            // 
            SignupLabel.AutoSize = true;
            SignupLabel.Cursor = Cursors.Hand;
            SignupLabel.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignupLabel.Location = new Point(3, 6);
            SignupLabel.Name = "SignupLabel";
            SignupLabel.Size = new Size(66, 17);
            SignupLabel.TabIndex = 4;
            SignupLabel.Text = "Sign Up";
            SignupLabel.Click += SignupLabel_Click;
            // 
            // ShowpassButton
            // 
            ShowpassButton.BackColor = Color.Transparent;
            ShowpassButton.FlatAppearance.BorderSize = 0;
            ShowpassButton.FlatStyle = FlatStyle.Flat;
            ShowpassButton.Location = new Point(179, 130);
            ShowpassButton.Name = "ShowpassButton";
            ShowpassButton.Size = new Size(32, 32);
            ShowpassButton.TabIndex = 4;
            ShowpassButton.UseVisualStyleBackColor = false;
            ShowpassButton.Click += ShowpassButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(CleanButton);
            panel1.Controls.Add(LoginButton);
            panel1.Location = new Point(89, 329);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 38);
            panel1.TabIndex = 7;
            // 
            // CleanButton
            // 
            CleanButton.Animated = true;
            CleanButton.AutoRoundedCorners = true;
            CleanButton.BorderRadius = 14;
            CleanButton.CustomizableEdges = customizableEdges1;
            CleanButton.DisabledState.BorderColor = Color.DarkGray;
            CleanButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CleanButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CleanButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CleanButton.Font = new Font("Segoe UI", 9F);
            CleanButton.ForeColor = Color.White;
            CleanButton.Location = new Point(123, 3);
            CleanButton.Name = "CleanButton";
            CleanButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CleanButton.Size = new Size(84, 31);
            CleanButton.TabIndex = 3;
            CleanButton.Text = "Clean";
            CleanButton.Click += CleanButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Animated = true;
            LoginButton.AutoRoundedCorners = true;
            LoginButton.BorderRadius = 14;
            LoginButton.CustomizableEdges = customizableEdges3;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.Font = new Font("Segoe UI", 9F);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(18, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            LoginButton.Size = new Size(84, 31);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Log In";
            LoginButton.Click += LoginButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(SignupLabel);
            panel2.Location = new Point(165, 376);
            panel2.Name = "panel2";
            panel2.Size = new Size(72, 35);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(guna2GradientPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 513);
            panel3.TabIndex = 8;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(panel2);
            guna2GradientPanel1.Controls.Add(panel4);
            guna2GradientPanel1.Controls.Add(panel1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges9;
            guna2GradientPanel1.Dock = DockStyle.Fill;
            guna2GradientPanel1.FillColor = Color.FromArgb(14, 190, 255);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 66, 179);
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2GradientPanel1.Size = new Size(402, 513);
            guna2GradientPanel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(PasswordTextBox);
            panel4.Controls.Add(LoginTextBox);
            panel4.Controls.Add(ShowpassButton);
            panel4.Location = new Point(87, 107);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 199);
            panel4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 10.8F);
            label4.Location = new Point(47, 99);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 11);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 8;
            label3.Text = "Login";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Animated = true;
            PasswordTextBox.AutoRoundedCorners = true;
            PasswordTextBox.BorderColor = Color.FromArgb(255, 128, 128);
            PasswordTextBox.BorderRadius = 12;
            PasswordTextBox.CustomizableEdges = customizableEdges5;
            PasswordTextBox.DefaultText = "";
            PasswordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Font = new Font("Segoe UI", 9F);
            PasswordTextBox.ForeColor = Color.Black;
            PasswordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Location = new Point(48, 133);
            PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '\0';
            PasswordTextBox.PlaceholderForeColor = Color.DimGray;
            PasswordTextBox.PlaceholderText = "Enter Password ";
            PasswordTextBox.SelectedText = "";
            PasswordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PasswordTextBox.Size = new Size(125, 26);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Animated = true;
            LoginTextBox.AutoRoundedCorners = true;
            LoginTextBox.BorderColor = Color.FromArgb(255, 128, 128);
            LoginTextBox.BorderRadius = 12;
            LoginTextBox.CustomizableEdges = customizableEdges7;
            LoginTextBox.DefaultText = "";
            LoginTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LoginTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LoginTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LoginTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LoginTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LoginTextBox.Font = new Font("Segoe UI", 9F);
            LoginTextBox.ForeColor = Color.Black;
            LoginTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LoginTextBox.Location = new Point(48, 41);
            LoginTextBox.Margin = new Padding(3, 4, 3, 4);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PasswordChar = '\0';
            LoginTextBox.PlaceholderForeColor = Color.DimGray;
            LoginTextBox.PlaceholderText = "Enter LogIn";
            LoginTextBox.SelectedText = "";
            LoginTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            LoginTextBox.Size = new Size(125, 26);
            LoginTextBox.TabIndex = 0;
            // 
            // AutorisationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(402, 513);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AutorisationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autorisation";
            Load += AutorisationForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label SignupLabel;
        private Button ShowpassButton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox LoginTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button CleanButton;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}
