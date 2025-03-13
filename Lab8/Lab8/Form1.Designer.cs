namespace Lab8
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
            OpenFileDialog = new OpenFileDialog();
            dataGridViewData = new DataGridView();
            txtOperator = new TextBox();
            txtExtra98 = new TextBox();
            txtPremium95 = new TextBox();
            txtDiesel = new TextBox();
            txtGaz = new TextBox();
            comboFuelType = new ComboBox();
            btnShowChart = new Button();
            chartFuelPrices = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            menuStrip1 = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "../../Resources/lab8.txt";
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewData.BackgroundColor = Color.WhiteSmoke;
            dataGridViewData.ColumnHeadersHeight = 29;
            dataGridViewData.Location = new Point(196, 87);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewData.Size = new Size(784, 250);
            dataGridViewData.TabIndex = 0;
            dataGridViewData.SelectionChanged += dataGridViewData_SelectionChanged;
            // 
            // txtOperator
            // 
            txtOperator.Font = new Font("Segoe UI", 12F);
            txtOperator.Location = new Point(17, 110);
            txtOperator.Name = "txtOperator";
            txtOperator.PlaceholderText = "Operator";
            txtOperator.Size = new Size(163, 34);
            txtOperator.TabIndex = 1;
            // 
            // txtExtra98
            // 
            txtExtra98.Font = new Font("Segoe UI", 12F);
            txtExtra98.Location = new Point(17, 150);
            txtExtra98.Name = "txtExtra98";
            txtExtra98.PlaceholderText = "Extra98 Price";
            txtExtra98.Size = new Size(163, 34);
            txtExtra98.TabIndex = 2;
            // 
            // txtPremium95
            // 
            txtPremium95.Font = new Font("Segoe UI", 12F);
            txtPremium95.Location = new Point(17, 190);
            txtPremium95.Name = "txtPremium95";
            txtPremium95.PlaceholderText = "Premium95 Price";
            txtPremium95.Size = new Size(163, 34);
            txtPremium95.TabIndex = 3;
            // 
            // txtDiesel
            // 
            txtDiesel.Font = new Font("Segoe UI", 12F);
            txtDiesel.Location = new Point(17, 230);
            txtDiesel.Name = "txtDiesel";
            txtDiesel.PlaceholderText = "Diesel Price";
            txtDiesel.Size = new Size(163, 34);
            txtDiesel.TabIndex = 4;
            // 
            // txtGaz
            // 
            txtGaz.Font = new Font("Segoe UI", 12F);
            txtGaz.Location = new Point(17, 270);
            txtGaz.Name = "txtGaz";
            txtGaz.PlaceholderText = "Gaz Price";
            txtGaz.Size = new Size(163, 34);
            txtGaz.TabIndex = 5;
            // 
            // comboFuelType
            // 
            comboFuelType.FormattingEnabled = true;
            comboFuelType.Location = new Point(17, 502);
            comboFuelType.Name = "comboFuelType";
            comboFuelType.Size = new Size(151, 28);
            comboFuelType.TabIndex = 3;
            // 
            // btnShowChart
            // 
            btnShowChart.Location = new Point(48, 536);
            btnShowChart.Name = "btnShowChart";
            btnShowChart.Size = new Size(94, 29);
            btnShowChart.TabIndex = 2;
            btnShowChart.Text = "Show Chart";
            btnShowChart.UseVisualStyleBackColor = true;
            btnShowChart.Click += btnShowChart_Click;
            // 
            // chartFuelPrices
            // 
            chartFuelPrices.Location = new Point(196, 375);
            chartFuelPrices.MatchAxesScreenDataRatio = false;
            chartFuelPrices.Name = "chartFuelPrices";
            chartFuelPrices.Size = new Size(784, 380);
            chartFuelPrices.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem, addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(992, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(56, 24);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(51, 24);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(67, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 767);
            Controls.Add(chartFuelPrices);
            Controls.Add(comboFuelType);
            Controls.Add(btnShowChart);
            Controls.Add(txtGaz);
            Controls.Add(txtDiesel);
            Controls.Add(txtPremium95);
            Controls.Add(txtExtra98);
            Controls.Add(txtOperator);
            Controls.Add(dataGridViewData);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fuel Diagram";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog OpenFileDialog;
        private DataGridView dataGridViewData;
        private TextBox txtOperator;
        private TextBox txtExtra98;
        private TextBox txtPremium95;
        private TextBox txtDiesel;
        private TextBox txtGaz;
        private ComboBox comboFuelType;
        private Button btnShowChart;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartFuelPrices;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
