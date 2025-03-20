using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace Lab9
{
    public partial class DiagramForm : Form
    {
        private BindingList<Country> countries;

        public DiagramForm(BindingList<Country> countries)
        {
            InitializeComponent();
            this.countries = countries;
            this.countries.ListChanged += Countries_ListChanged;
            UpdateChart();

            // Настройки формы
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            pieChart.Dock = DockStyle.Fill; // Диаграмма растягивается на всю форму
        }

        private void Countries_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateChart();
        }

        private void UpdateChart()
        {
            var republicCount = countries.Count(c => c.GovernmentType == "Republic");
            var monarchyCount = countries.Count(c => c.GovernmentType == "Monarchy");
            var federationCount = countries.Count(c => c.GovernmentType == "Federation");

            pieChart.Series = new ISeries[]
            {
                new PieSeries<double> { Values = new double[] { republicCount }, Name = "Республики" },
                new PieSeries<double> { Values = new double[] { monarchyCount }, Name = "Монархии" },
                new PieSeries<double> { Values = new double[] { federationCount }, Name = "Федерации" }
            };

            // Включение легенды
            pieChart.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right; // Положение легенды справа
        }
    }
}