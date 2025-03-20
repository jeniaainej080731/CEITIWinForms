namespace Lab9
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
            dataGridView1 = new DataGridView();
            parrotFlatMenuStrip1 = new ReaLTaiizor.Controls.ParrotFlatMenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            showDiagramToolStripMenuItem = new ToolStripMenuItem();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            setTextColorToolStripMenuItem = new ToolStripMenuItem();
            setBackgroundToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            showStatisticsToolStripMenuItem = new ToolStripMenuItem();
            lblMaxPopulation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblMinPopulation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            parrotFlatMenuStrip1.SuspendLayout();
            guna2ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(791, 305);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // parrotFlatMenuStrip1
            // 
            parrotFlatMenuStrip1.BackColor = Color.DodgerBlue;
            parrotFlatMenuStrip1.HoverBackColor = Color.RoyalBlue;
            parrotFlatMenuStrip1.HoverTextColor = Color.White;
            parrotFlatMenuStrip1.ImageScalingSize = new Size(20, 20);
            parrotFlatMenuStrip1.ItemBackColor = Color.DodgerBlue;
            parrotFlatMenuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, showDiagramToolStripMenuItem });
            parrotFlatMenuStrip1.Location = new Point(0, 0);
            parrotFlatMenuStrip1.Name = "parrotFlatMenuStrip1";
            parrotFlatMenuStrip1.SelectedBackColor = Color.DarkOrchid;
            parrotFlatMenuStrip1.SelectedTextColor = Color.White;
            parrotFlatMenuStrip1.SeparatorColor = Color.White;
            parrotFlatMenuStrip1.Size = new Size(800, 28);
            parrotFlatMenuStrip1.TabIndex = 1;
            parrotFlatMenuStrip1.Text = "parrotFlatMenuStrip1";
            parrotFlatMenuStrip1.TextColor = Color.White;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.ForeColor = Color.White;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.ForeColor = Color.White;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(141, 26);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.ForeColor = Color.White;
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(141, 26);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = Color.White;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(141, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // showDiagramToolStripMenuItem
            // 
            showDiagramToolStripMenuItem.ForeColor = Color.White;
            showDiagramToolStripMenuItem.Name = "showDiagramToolStripMenuItem";
            showDiagramToolStripMenuItem.Size = new Size(121, 24);
            showDiagramToolStripMenuItem.Text = "Show Diagram";
            showDiagramToolStripMenuItem.Click += showDiagramToolStripMenuItem_Click;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { setTextColorToolStripMenuItem, setBackgroundToolStripMenuItem, showStatisticsToolStripMenuItem });
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(183, 76);
            // 
            // setTextColorToolStripMenuItem
            // 
            setTextColorToolStripMenuItem.Name = "setTextColorToolStripMenuItem";
            setTextColorToolStripMenuItem.Size = new Size(182, 24);
            setTextColorToolStripMenuItem.Text = "Set Text Color";
            setTextColorToolStripMenuItem.Click += setTextColorToolStripMenuItem_Click;
            // 
            // setBackgroundToolStripMenuItem
            // 
            setBackgroundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, imageToolStripMenuItem });
            setBackgroundToolStripMenuItem.Name = "setBackgroundToolStripMenuItem";
            setBackgroundToolStripMenuItem.Size = new Size(182, 24);
            setBackgroundToolStripMenuItem.Text = "Set Background";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(134, 26);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(134, 26);
            imageToolStripMenuItem.Text = "Image";
            imageToolStripMenuItem.Click += imageToolStripMenuItem_Click;
            // 
            // showStatisticsToolStripMenuItem
            // 
            showStatisticsToolStripMenuItem.Name = "showStatisticsToolStripMenuItem";
            showStatisticsToolStripMenuItem.Size = new Size(182, 24);
            showStatisticsToolStripMenuItem.Text = "Show Statistics";
            showStatisticsToolStripMenuItem.Click += showStatisticsToolStripMenuItem_Click;
            // 
            // lblMaxPopulation
            // 
            lblMaxPopulation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMaxPopulation.AutoSize = false;
            lblMaxPopulation.BackColor = Color.FromArgb(42, 42, 42);
            lblMaxPopulation.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMaxPopulation.ForeColor = Color.White;
            lblMaxPopulation.Location = new Point(5, 342);
            lblMaxPopulation.Name = "lblMaxPopulation";
            lblMaxPopulation.Size = new Size(323, 43);
            lblMaxPopulation.TabIndex = 3;
            lblMaxPopulation.Text = "~Max Population~";
            lblMaxPopulation.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblMinPopulation
            // 
            lblMinPopulation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMinPopulation.AutoSize = false;
            lblMinPopulation.BackColor = Color.FromArgb(42, 42, 42);
            lblMinPopulation.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMinPopulation.ForeColor = Color.White;
            lblMinPopulation.Location = new Point(5, 395);
            lblMinPopulation.Name = "lblMinPopulation";
            lblMinPopulation.Size = new Size(323, 43);
            lblMinPopulation.TabIndex = 3;
            lblMinPopulation.Text = "~Min Population~";
            lblMinPopulation.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = guna2ContextMenuStrip1;
            Controls.Add(lblMinPopulation);
            Controls.Add(lblMaxPopulation);
            Controls.Add(dataGridView1);
            Controls.Add(parrotFlatMenuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Countries List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            parrotFlatMenuStrip1.ResumeLayout(false);
            parrotFlatMenuStrip1.PerformLayout();
            guna2ContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.ParrotFlatMenuStrip parrotFlatMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem setTextColorToolStripMenuItem;
        private ToolStripMenuItem setBackgroundToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem showStatisticsToolStripMenuItem;
        private ToolStripMenuItem showDiagramToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaxPopulation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMinPopulation;
    }
}
