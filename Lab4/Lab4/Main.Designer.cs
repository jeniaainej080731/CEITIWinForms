namespace Lab4
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            MainTextRichTextBox = new RichTextBox();
            InputTextBox = new TextBox();
            DeleteRadioButton = new RadioButton();
            MirrorRadioButton = new RadioButton();
            FindRepeatsRadioButton = new RadioButton();
            CodingCheckBox = new CheckBox();
            OptionsGroupBox = new GroupBox();
            InfoToolTip = new ToolTip(components);
            DeletingSpacesCheckBox = new CheckBox();
            DeleteSpacesButton = new Guna.UI2.WinForms.Guna2CircleButton();
            DeleteSpacesLabel = new Label();
            MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            CountOfWordsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            FormattingButton = new Guna.UI2.WinForms.Guna2Button();
            CalculateButton = new Guna.UI2.WinForms.Guna2Button();
            OptionsGroupBox.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainTextRichTextBox
            // 
            MainTextRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainTextRichTextBox.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainTextRichTextBox.Location = new Point(12, 12);
            MainTextRichTextBox.Name = "MainTextRichTextBox";
            MainTextRichTextBox.Size = new Size(776, 264);
            MainTextRichTextBox.TabIndex = 0;
            MainTextRichTextBox.Text = "";
            // 
            // InputTextBox
            // 
            InputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InputTextBox.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            InputTextBox.ForeColor = SystemColors.GrayText;
            InputTextBox.Location = new Point(301, 377);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.PlaceholderText = "Input word";
            InputTextBox.Size = new Size(184, 29);
            InputTextBox.TabIndex = 1;
            InputTextBox.TextChanged += InputTextBox_TextChanged;
            // 
            // DeleteRadioButton
            // 
            DeleteRadioButton.AutoSize = true;
            DeleteRadioButton.Location = new Point(22, 28);
            DeleteRadioButton.Name = "DeleteRadioButton";
            DeleteRadioButton.Size = new Size(114, 24);
            DeleteRadioButton.TabIndex = 3;
            DeleteRadioButton.TabStop = true;
            DeleteRadioButton.Text = "Deleting ";
            DeleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // MirrorRadioButton
            // 
            MirrorRadioButton.AutoSize = true;
            MirrorRadioButton.Location = new Point(142, 28);
            MirrorRadioButton.Name = "MirrorRadioButton";
            MirrorRadioButton.Size = new Size(89, 24);
            MirrorRadioButton.TabIndex = 4;
            MirrorRadioButton.TabStop = true;
            MirrorRadioButton.Text = "Mirror";
            MirrorRadioButton.UseVisualStyleBackColor = true;
            // 
            // FindRepeatsRadioButton
            // 
            FindRepeatsRadioButton.AutoSize = true;
            FindRepeatsRadioButton.Location = new Point(253, 28);
            FindRepeatsRadioButton.Name = "FindRepeatsRadioButton";
            FindRepeatsRadioButton.Size = new Size(151, 24);
            FindRepeatsRadioButton.TabIndex = 5;
            FindRepeatsRadioButton.TabStop = true;
            FindRepeatsRadioButton.Text = "Find Repeats";
            FindRepeatsRadioButton.UseVisualStyleBackColor = true;
            // 
            // CodingCheckBox
            // 
            CodingCheckBox.AutoSize = true;
            CodingCheckBox.BackColor = Color.FromArgb(148, 250, 237);
            CodingCheckBox.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            CodingCheckBox.ForeColor = Color.FromArgb(24, 78, 63);
            CodingCheckBox.Location = new Point(25, 357);
            CodingCheckBox.Name = "CodingCheckBox";
            CodingCheckBox.Size = new Size(129, 24);
            CodingCheckBox.TabIndex = 8;
            CodingCheckBox.Text = "Code Text";
            CodingCheckBox.UseVisualStyleBackColor = false;
            CodingCheckBox.CheckedChanged += CodingCheckBox_CheckedChanged;
            // 
            // OptionsGroupBox
            // 
            OptionsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OptionsGroupBox.BackColor = Color.FromArgb(148, 250, 237);
            OptionsGroupBox.BackgroundImageLayout = ImageLayout.None;
            OptionsGroupBox.Controls.Add(DeleteRadioButton);
            OptionsGroupBox.Controls.Add(MirrorRadioButton);
            OptionsGroupBox.Controls.Add(FindRepeatsRadioButton);
            OptionsGroupBox.FlatStyle = FlatStyle.Flat;
            OptionsGroupBox.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OptionsGroupBox.ForeColor = Color.FromArgb(24, 78, 63);
            OptionsGroupBox.Location = new Point(12, 282);
            OptionsGroupBox.Name = "OptionsGroupBox";
            OptionsGroupBox.Size = new Size(413, 69);
            OptionsGroupBox.TabIndex = 9;
            OptionsGroupBox.TabStop = false;
            OptionsGroupBox.Text = "Options";
            // 
            // DeletingSpacesCheckBox
            // 
            DeletingSpacesCheckBox.AutoSize = true;
            DeletingSpacesCheckBox.BackColor = Color.FromArgb(148, 250, 237);
            DeletingSpacesCheckBox.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            DeletingSpacesCheckBox.ForeColor = Color.FromArgb(24, 78, 63);
            DeletingSpacesCheckBox.Location = new Point(25, 387);
            DeletingSpacesCheckBox.Name = "DeletingSpacesCheckBox";
            DeletingSpacesCheckBox.Size = new Size(211, 24);
            DeletingSpacesCheckBox.TabIndex = 10;
            DeletingSpacesCheckBox.Text = "Deleting All Spaces";
            DeletingSpacesCheckBox.UseVisualStyleBackColor = false;
            DeletingSpacesCheckBox.CheckedChanged += DeletingSpacesCheckBox_CheckedChanged;
            // 
            // DeleteSpacesButton
            // 
            DeleteSpacesButton.BackColor = Color.FromArgb(148, 250, 237);
            DeleteSpacesButton.DisabledState.BorderColor = Color.DarkGray;
            DeleteSpacesButton.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteSpacesButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteSpacesButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteSpacesButton.FillColor = Color.Transparent;
            DeleteSpacesButton.Font = new Font("Segoe UI", 9F);
            DeleteSpacesButton.ForeColor = Color.White;
            DeleteSpacesButton.Image = (Image)resources.GetObject("DeleteSpacesButton.Image");
            DeleteSpacesButton.ImageSize = new Size(32, 32);
            DeleteSpacesButton.Location = new Point(16, 411);
            DeleteSpacesButton.Name = "DeleteSpacesButton";
            DeleteSpacesButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            DeleteSpacesButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            DeleteSpacesButton.Size = new Size(32, 33);
            DeleteSpacesButton.TabIndex = 15;
            DeleteSpacesButton.Click += DeleteSpacesButton_Click;
            // 
            // DeleteSpacesLabel
            // 
            DeleteSpacesLabel.AutoSize = true;
            DeleteSpacesLabel.BackColor = Color.FromArgb(148, 250, 237);
            DeleteSpacesLabel.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            DeleteSpacesLabel.ForeColor = Color.FromArgb(24, 78, 63);
            DeleteSpacesLabel.Location = new Point(43, 416);
            DeleteSpacesLabel.Name = "DeleteSpacesLabel";
            DeleteSpacesLabel.Size = new Size(212, 20);
            DeleteSpacesLabel.TabIndex = 16;
            DeleteSpacesLabel.Text = "Delete Double-Spaces";
            DeleteSpacesLabel.Click += DeleteSpacesLabel_Click;
            // 
            // MainPanel
            // 
            MainPanel.AutoSize = true;
            MainPanel.Controls.Add(CountOfWordsLabel);
            MainPanel.Controls.Add(FormattingButton);
            MainPanel.Controls.Add(CalculateButton);
            MainPanel.Controls.Add(DeleteSpacesLabel);
            MainPanel.Controls.Add(MainTextRichTextBox);
            MainPanel.Controls.Add(DeleteSpacesButton);
            MainPanel.Controls.Add(InputTextBox);
            MainPanel.Controls.Add(DeletingSpacesCheckBox);
            MainPanel.Controls.Add(CodingCheckBox);
            MainPanel.Controls.Add(OptionsGroupBox);
            MainPanel.CustomizableEdges = customizableEdges6;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.FillColor = Color.FromArgb(148, 250, 237);
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.ShadowDecoration.CustomizableEdges = customizableEdges7;
            MainPanel.Size = new Size(800, 455);
            MainPanel.TabIndex = 17;
            // 
            // CountOfWordsLabel
            // 
            CountOfWordsLabel.BackColor = Color.Transparent;
            CountOfWordsLabel.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            CountOfWordsLabel.ForeColor = Color.FromArgb(24, 78, 63);
            CountOfWordsLabel.Location = new Point(570, 309);
            CountOfWordsLabel.Name = "CountOfWordsLabel";
            CountOfWordsLabel.Size = new Size(8, 22);
            CountOfWordsLabel.TabIndex = 18;
            CountOfWordsLabel.Text = "-";
            // 
            // FormattingButton
            // 
            FormattingButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FormattingButton.Animated = true;
            FormattingButton.AutoRoundedCorners = true;
            FormattingButton.BackColor = Color.FromArgb(148, 250, 237);
            FormattingButton.BorderRadius = 19;
            FormattingButton.CustomizableEdges = customizableEdges2;
            FormattingButton.DisabledState.BorderColor = Color.DarkGray;
            FormattingButton.DisabledState.CustomBorderColor = Color.DarkGray;
            FormattingButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            FormattingButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            FormattingButton.FillColor = Color.FromArgb(24, 78, 63);
            FormattingButton.FocusedColor = Color.FromArgb(37, 120, 98);
            FormattingButton.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            FormattingButton.ForeColor = Color.FromArgb(148, 250, 237);
            FormattingButton.Location = new Point(340, 410);
            FormattingButton.Name = "FormattingButton";
            FormattingButton.PressedColor = Color.FromArgb(22, 71, 57);
            FormattingButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            FormattingButton.Size = new Size(104, 41);
            FormattingButton.TabIndex = 17;
            FormattingButton.Text = "Format";
            FormattingButton.Click += FormattingButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CalculateButton.Animated = true;
            CalculateButton.AutoRoundedCorners = true;
            CalculateButton.BackColor = Color.FromArgb(148, 250, 237);
            CalculateButton.BorderRadius = 19;
            CalculateButton.CustomizableEdges = customizableEdges4;
            CalculateButton.DisabledState.BorderColor = Color.DarkGray;
            CalculateButton.DisabledState.CustomBorderColor = Color.DarkGray;
            CalculateButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CalculateButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CalculateButton.FillColor = Color.FromArgb(24, 78, 63);
            CalculateButton.FocusedColor = Color.FromArgb(37, 120, 98);
            CalculateButton.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            CalculateButton.ForeColor = Color.FromArgb(148, 250, 237);
            CalculateButton.Location = new Point(434, 301);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.PressedColor = Color.FromArgb(22, 71, 57);
            CalculateButton.ShadowDecoration.CustomizableEdges = customizableEdges5;
            CalculateButton.Size = new Size(124, 41);
            CalculateButton.TabIndex = 17;
            CalculateButton.Text = "Calculate";
            CalculateButton.Click += CalculateButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text Formatting";
            Load += Main_Load;
            OptionsGroupBox.ResumeLayout(false);
            OptionsGroupBox.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox MainTextRichTextBox;
        private TextBox InputTextBox;
        private RadioButton DeleteRadioButton;
        private RadioButton MirrorRadioButton;
        private RadioButton FindRepeatsRadioButton;
        private CheckBox CodingCheckBox;
        private GroupBox OptionsGroupBox;
        private ToolTip InfoToolTip;
        private CheckBox DeletingSpacesCheckBox;
        private Guna.UI2.WinForms.Guna2CircleButton DeleteSpacesButton;
        private Label DeleteSpacesLabel;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button CalculateButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel CountOfWordsLabel;
        private Guna.UI2.WinForms.Guna2Button FormattingButton;
    }
}
