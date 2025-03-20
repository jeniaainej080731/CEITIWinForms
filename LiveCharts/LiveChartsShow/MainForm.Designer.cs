namespace LiveChartsShow
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
            siticoneTabControl1 = new SiticoneNetCoreUI.SiticoneTabControl();
            tabPage1 = new TabPage();
            cartesianChartLine = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage2 = new TabPage();
            cartesianChartBar = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage3 = new TabPage();
            pieChart = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            tabPage4 = new TabPage();
            cartesianChartScatter = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            TooltipLabelFormatter = new ToolTip(components);
            siticoneTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            siticoneTabControl1.BorderColor = Color.Transparent;
            siticoneTabControl1.BorderWidth = 1;
            siticoneTabControl1.CloseButtonColor = Color.Gray;
            siticoneTabControl1.CloseButtonHoverColor = Color.Red;
            siticoneTabControl1.CloseButtonSymbolPadding = 0.25F;
            siticoneTabControl1.CloseButtonThickness = 1.8F;
            siticoneTabControl1.ContextMenuFont = new Font("Segoe UI", 10F);
            siticoneTabControl1.Controls.Add(tabPage1);
            siticoneTabControl1.Controls.Add(tabPage2);
            siticoneTabControl1.Controls.Add(tabPage3);
            siticoneTabControl1.Controls.Add(tabPage4);
            siticoneTabControl1.Dock = DockStyle.Fill;
            siticoneTabControl1.DragIndicatorColor = Color.FromArgb(25, 118, 210);
            siticoneTabControl1.EnableShadowEffects = true;
            siticoneTabControl1.Font = new Font("Segoe UI", 10F);
            siticoneTabControl1.GhostBackColor = Color.FromArgb(20, 34, 30, 65);
            siticoneTabControl1.GhostForeColor = Color.FromArgb(180, 0, 0, 0);
            siticoneTabControl1.ItemSize = new Size(160, 40);
            siticoneTabControl1.Location = new Point(0, 0);
            siticoneTabControl1.Name = "siticoneTabControl1";
            siticoneTabControl1.PinIconHoverColor = Color.DarkGray;
            siticoneTabControl1.PinnedIconColor = Color.FromArgb(30, 136, 229);
            siticoneTabControl1.RippleColor = Color.LightGray;
            siticoneTabControl1.SelectedIndex = 0;
            siticoneTabControl1.SelectedTabBackColor = Color.Transparent;
            siticoneTabControl1.SelectedTabFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            siticoneTabControl1.SelectedTabIndicatorColor = Color.FromArgb(34, 30, 65);
            siticoneTabControl1.SelectedTabIndicatorHeight = 3;
            siticoneTabControl1.SelectedTextColor = Color.FromArgb(34, 30, 65);
            siticoneTabControl1.SeparatorLineColor = Color.FromArgb(0, 0, 0);
            siticoneTabControl1.SeparatorLineOpacity = 0.4F;
            siticoneTabControl1.Size = new Size(800, 450);
            siticoneTabControl1.SizeMode = TabSizeMode.Fixed;
            siticoneTabControl1.TabIndex = 0;
            siticoneTabControl1.UnpinnedIconColor = Color.Gray;
            siticoneTabControl1.UnselectedTabColor = Color.Transparent;
            siticoneTabControl1.UnselectedTextColor = Color.Gray;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(cartesianChartLine);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 402);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Line Chart";
            // 
            // cartesianChartLine
            // 
            cartesianChartLine.Location = new Point(6, 6);
            cartesianChartLine.MatchAxesScreenDataRatio = false;
            cartesianChartLine.Name = "cartesianChartLine";
            cartesianChartLine.Size = new Size(778, 388);
            cartesianChartLine.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(cartesianChartBar);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 402);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bar Chart";
            // 
            // cartesianChartBar
            // 
            cartesianChartBar.Location = new Point(8, 6);
            cartesianChartBar.MatchAxesScreenDataRatio = false;
            cartesianChartBar.Name = "cartesianChartBar";
            cartesianChartBar.Size = new Size(776, 388);
            cartesianChartBar.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(pieChart);
            tabPage3.Location = new Point(4, 44);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 402);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Pie Chart";
            // 
            // pieChart
            // 
            pieChart.InitialRotation = 0D;
            pieChart.IsClockwise = true;
            pieChart.Location = new Point(3, 6);
            pieChart.MaxAngle = 360D;
            pieChart.MaxValue = double.NaN;
            pieChart.MinValue = 0D;
            pieChart.Name = "pieChart";
            pieChart.Size = new Size(781, 390);
            pieChart.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(cartesianChartScatter);
            tabPage4.Location = new Point(4, 44);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 402);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Scatter Plot";
            // 
            // cartesianChartScatter
            // 
            cartesianChartScatter.Location = new Point(8, 6);
            cartesianChartScatter.MatchAxesScreenDataRatio = false;
            cartesianChartScatter.Name = "cartesianChartScatter";
            cartesianChartScatter.Size = new Size(776, 388);
            cartesianChartScatter.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(siticoneTabControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Live Charts";
            siticoneTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticoneTabControl siticoneTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChartLine;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChartBar;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChartScatter;
        private ToolTip TooltipLabelFormatter;
    }
}
