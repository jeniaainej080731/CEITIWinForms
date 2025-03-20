namespace Lab9
{
    partial class DiagramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagramForm));
            pieChart = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            SuspendLayout();
            // 
            // pieChart
            // 
            pieChart.Dock = DockStyle.Fill;
            pieChart.InitialRotation = 0D;
            pieChart.IsClockwise = true;
            pieChart.Location = new Point(0, 0);
            pieChart.MaxAngle = 360D;
            pieChart.MaxValue = double.NaN;
            pieChart.MinValue = 0D;
            pieChart.Name = "pieChart";
            pieChart.Size = new Size(800, 450);
            pieChart.TabIndex = 0;
            // 
            // DiagramForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pieChart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DiagramForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diagram";
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart;
    }
}