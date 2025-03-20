namespace Lab9
{
    partial class AddEditCountryForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditCountryForm));
            GovernmentType = new Guna.UI2.WinForms.Guna2ComboBox();
            NameTxtBox = new TextBox();
            CapitalTxtBox = new TextBox();
            FlagPathTxtBox = new TextBox();
            SelectFlagBtn = new CuoreUI.Controls.cuiButton();
            OKBtn = new CuoreUI.Controls.cuiButton();
            CancelBtn = new CuoreUI.Controls.cuiButton();
            PopulationNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PopulationNum).BeginInit();
            SuspendLayout();
            // 
            // GovernmentType
            // 
            GovernmentType.AutoRoundedCorners = true;
            GovernmentType.BackColor = Color.Transparent;
            GovernmentType.CustomizableEdges = customizableEdges1;
            GovernmentType.DrawMode = DrawMode.OwnerDrawFixed;
            GovernmentType.DropDownStyle = ComboBoxStyle.DropDownList;
            GovernmentType.FocusedColor = Color.FromArgb(94, 148, 255);
            GovernmentType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            GovernmentType.Font = new Font("Malgun Gothic", 11F);
            GovernmentType.ForeColor = Color.FromArgb(68, 88, 112);
            GovernmentType.ItemHeight = 30;
            GovernmentType.Location = new Point(25, 46);
            GovernmentType.Name = "GovernmentType";
            GovernmentType.ShadowDecoration.CustomizableEdges = customizableEdges2;
            GovernmentType.Size = new Size(175, 36);
            GovernmentType.TabIndex = 1;
            // 
            // NameTxtBox
            // 
            NameTxtBox.Font = new Font("Malgun Gothic", 11F);
            NameTxtBox.Location = new Point(25, 104);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.PlaceholderText = "Country Name";
            NameTxtBox.Size = new Size(228, 32);
            NameTxtBox.TabIndex = 2;
            // 
            // CapitalTxtBox
            // 
            CapitalTxtBox.Font = new Font("Malgun Gothic", 11F);
            CapitalTxtBox.Location = new Point(25, 152);
            CapitalTxtBox.Name = "CapitalTxtBox";
            CapitalTxtBox.PlaceholderText = "Capital";
            CapitalTxtBox.Size = new Size(228, 32);
            CapitalTxtBox.TabIndex = 3;
            // 
            // FlagPathTxtBox
            // 
            FlagPathTxtBox.Font = new Font("Malgun Gothic", 11F);
            FlagPathTxtBox.Location = new Point(25, 262);
            FlagPathTxtBox.Name = "FlagPathTxtBox";
            FlagPathTxtBox.PlaceholderText = "Path to Flag image";
            FlagPathTxtBox.ReadOnly = true;
            FlagPathTxtBox.Size = new Size(228, 32);
            FlagPathTxtBox.TabIndex = 4;
            // 
            // SelectFlagBtn
            // 
            SelectFlagBtn.CheckButton = false;
            SelectFlagBtn.Checked = false;
            SelectFlagBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            SelectFlagBtn.CheckedForeColor = Color.White;
            SelectFlagBtn.CheckedImageTint = Color.White;
            SelectFlagBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            SelectFlagBtn.Content = "Select Flag";
            SelectFlagBtn.DialogResult = DialogResult.None;
            SelectFlagBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            SelectFlagBtn.ForeColor = Color.White;
            SelectFlagBtn.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            SelectFlagBtn.HoveredImageTint = Color.White;
            SelectFlagBtn.HoverForeColor = Color.White;
            SelectFlagBtn.HoverOutline = Color.Empty;
            SelectFlagBtn.Image = null;
            SelectFlagBtn.ImageAutoCenter = true;
            SelectFlagBtn.ImageExpand = new Point(0, 0);
            SelectFlagBtn.ImageOffset = new Point(0, 0);
            SelectFlagBtn.ImageTint = Color.White;
            SelectFlagBtn.Location = new Point(64, 300);
            SelectFlagBtn.Name = "SelectFlagBtn";
            SelectFlagBtn.NormalBackground = Color.FromArgb(255, 106, 0);
            SelectFlagBtn.NormalOutline = Color.Empty;
            SelectFlagBtn.OutlineThickness = 1.6F;
            SelectFlagBtn.PressedBackground = Color.FromArgb(255, 106, 0);
            SelectFlagBtn.PressedForeColor = Color.White;
            SelectFlagBtn.PressedImageTint = Color.White;
            SelectFlagBtn.PressedOutline = Color.Empty;
            SelectFlagBtn.Rounding = new Padding(22);
            SelectFlagBtn.Size = new Size(143, 42);
            SelectFlagBtn.TabIndex = 5;
            SelectFlagBtn.TextOffset = new Point(0, 0);
            SelectFlagBtn.Click += cuiButton1_Click;
            // 
            // OKBtn
            // 
            OKBtn.CheckButton = false;
            OKBtn.Checked = false;
            OKBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            OKBtn.CheckedForeColor = Color.White;
            OKBtn.CheckedImageTint = Color.White;
            OKBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            OKBtn.Content = "OK";
            OKBtn.DialogResult = DialogResult.None;
            OKBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            OKBtn.ForeColor = Color.White;
            OKBtn.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            OKBtn.HoveredImageTint = Color.White;
            OKBtn.HoverForeColor = Color.White;
            OKBtn.HoverOutline = Color.Empty;
            OKBtn.Image = null;
            OKBtn.ImageAutoCenter = true;
            OKBtn.ImageExpand = new Point(0, 0);
            OKBtn.ImageOffset = new Point(0, 0);
            OKBtn.ImageTint = Color.White;
            OKBtn.Location = new Point(134, 396);
            OKBtn.Name = "OKBtn";
            OKBtn.NormalBackground = Color.FromArgb(255, 106, 0);
            OKBtn.NormalOutline = Color.Empty;
            OKBtn.OutlineThickness = 1.6F;
            OKBtn.PressedBackground = Color.FromArgb(255, 106, 0);
            OKBtn.PressedForeColor = Color.White;
            OKBtn.PressedImageTint = Color.White;
            OKBtn.PressedOutline = Color.Empty;
            OKBtn.Rounding = new Padding(8);
            OKBtn.Size = new Size(101, 42);
            OKBtn.TabIndex = 6;
            OKBtn.TextOffset = new Point(0, 0);
            OKBtn.Click += OKBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.CheckButton = false;
            CancelBtn.Checked = false;
            CancelBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            CancelBtn.CheckedForeColor = Color.White;
            CancelBtn.CheckedImageTint = Color.White;
            CancelBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            CancelBtn.Content = "Cancel";
            CancelBtn.DialogResult = DialogResult.None;
            CancelBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            CancelBtn.HoveredImageTint = Color.White;
            CancelBtn.HoverForeColor = Color.White;
            CancelBtn.HoverOutline = Color.Empty;
            CancelBtn.Image = null;
            CancelBtn.ImageAutoCenter = true;
            CancelBtn.ImageExpand = new Point(0, 0);
            CancelBtn.ImageOffset = new Point(0, 0);
            CancelBtn.ImageTint = Color.White;
            CancelBtn.Location = new Point(12, 396);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.NormalBackground = Color.FromArgb(255, 106, 0);
            CancelBtn.NormalOutline = Color.Empty;
            CancelBtn.OutlineThickness = 1.6F;
            CancelBtn.PressedBackground = Color.FromArgb(255, 106, 0);
            CancelBtn.PressedForeColor = Color.White;
            CancelBtn.PressedImageTint = Color.White;
            CancelBtn.PressedOutline = Color.Empty;
            CancelBtn.Rounding = new Padding(8);
            CancelBtn.Size = new Size(101, 42);
            CancelBtn.TabIndex = 7;
            CancelBtn.TextOffset = new Point(0, 0);
            CancelBtn.Click += CancelBtn_Click;
            // 
            // PopulationNum
            // 
            PopulationNum.BackColor = Color.Transparent;
            PopulationNum.CustomizableEdges = customizableEdges3;
            PopulationNum.Font = new Font("Malgun Gothic", 11F);
            PopulationNum.Location = new Point(26, 223);
            PopulationNum.Margin = new Padding(3, 4, 3, 4);
            PopulationNum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            PopulationNum.Name = "PopulationNum";
            PopulationNum.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PopulationNum.Size = new Size(209, 25);
            PopulationNum.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 11F);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 12;
            label1.Text = "Government Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 11F);
            label2.Location = new Point(26, 194);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 12;
            label2.Text = "Number of Inhabitants";
            // 
            // AddEditCountryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PopulationNum);
            Controls.Add(CancelBtn);
            Controls.Add(OKBtn);
            Controls.Add(SelectFlagBtn);
            Controls.Add(FlagPathTxtBox);
            Controls.Add(CapitalTxtBox);
            Controls.Add(NameTxtBox);
            Controls.Add(GovernmentType);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddEditCountryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add-Edit Country";
            ((System.ComponentModel.ISupportInitialize)PopulationNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox GovernmentType;
        private TextBox NameTxtBox;
        private TextBox CapitalTxtBox;
        private TextBox FlagPathTxtBox;
        private CuoreUI.Controls.cuiButton SelectFlagBtn;
        private CuoreUI.Controls.cuiButton OKBtn;
        private CuoreUI.Controls.cuiButton CancelBtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown PopulationNum;
        private Label label1;
        private Label label2;
    }
}