using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveChartsCore;              // Основной namespace для работы с LiveChartsCore
using LiveChartsCore.SkiaSharpView; // Namespace для отрисовки графиков
using LiveChartsCore.SkiaSharpView.WinForms; // Namespace для элементов управления WinForms

namespace LiveChartsShow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load; // Подключаем обработчик загрузки формы
        }

        // Обработчик события загрузки формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupLineChart();    // Настройка линейной диаграммы
            SetupBarChart();     // Настройка столбчатой диаграммы
            SetupScatterChart(); // Настройка точечной диаграммы
            SetupPieChart();     // Настройка круговой диаграммы
        }

        // Настройка линейной диаграммы (температура по дням недели)
        private void SetupLineChart()
        {
            // Тестовые данные: средняя температура по дням недели (в градусах Цельсия)
            var lineData = new double[] { 15, 17, 20, 19, 18, 16, 14 };

            // Создаём серию для линейной диаграммы
            var lineSeries = new LineSeries<double>
            {
                Values = lineData,      // Устанавливаем данные
                Name = "Температура",   // Название серии для легенды
            };

            // Привязываем серию к диаграмме
            cartesianChartLine.Series = new ISeries[] { lineSeries };

            // Настраиваем ось X с метками дней недели
            cartesianChartLine.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" }
                }
            };
        }

        // Настройка столбчатой диаграммы (доходы по месяцам)
        private void SetupBarChart()
        {
            // Тестовые данные: доходы компании по месяцам (в тысячах рублей)
            var barData = new double[] { 120, 150, 180, 200, 170, 160 };

            // Создаём серию для столбчатой диаграммы
            var barSeries = new ColumnSeries<double>
            {
                Values = barData,         // Устанавливаем данные
                Name = "Доходы",          // Название серии для легенды
            };

            // Привязываем серию к диаграмме
            cartesianChartBar.Series = new ISeries[] { barSeries };

            // Настраиваем ось X с метками месяцев
            cartesianChartBar.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = new string[] { "Янв", "Фев", "Мар", "Апр", "Май", "Июн" }
                }
            };
        }

        // Настройка точечной диаграммы (рост и вес людей)
        private void SetupScatterChart()
        {
            // Тестовые данные: рост (X, в см) и вес (Y, в кг) для 8 человек
            var scatterData = new List<double[]>
            {
                new double[] { 165, 60 },  // Человек 1
                new double[] { 170, 70 },  // Человек 2
                new double[] { 155, 50 },  // Человек 3
                new double[] { 180, 85 },  // Человек 4
                new double[] { 175, 75 },  // Человек 5
                new double[] { 160, 55 },  // Человек 6
                new double[] { 185, 90 },  // Человек 7
                new double[] { 168, 65 }   // Человек 8
            };

            // Создаём серию для точечной диаграммы
            var scatterSeries = new ScatterSeries<double[]>
            {
                Values = scatterData,          // Устанавливаем данные
                Mapping = (point, index) => new(point[0], point[1]), // Указываем X (рост) и Y (вес)
                Name = "Рост и вес",           // Название серии для легенды
            };

            // Привязываем серию к диаграмме
            cartesianChartScatter.Series = new ISeries[] { scatterSeries };

            // Настраиваем оси
            cartesianChartScatter.XAxes = new List<Axis> { new Axis { Name = "Рост (см)" } };
            cartesianChartScatter.YAxes = new List<Axis> { new Axis { Name = "Вес (кг)" } };
        }

        // Настройка круговой диаграммы (распределение бюджета)
        private void SetupPieChart()
        {
            // Тестовые данные: распределение бюджета (в процентах)
            var pieData = new double[] { 50, 30, 15, 5 };

            // Создаём серии для круговой диаграммы
            var pieSeries = new PieSeries<double>[]
            {
                new PieSeries<double>
                {
                    Values = new double[] { pieData[0] },
                    Name = "Еда",
                },
                new PieSeries<double>
                {
                    Values = new double[] { pieData[1] },
                    Name = "Жильё",
                },
                new PieSeries<double>
                {
                    Values = new double[] { pieData[2] },
                    Name = "Транспорт",
                },
                new PieSeries<double>
                {
                    Values = new double[] { pieData[3] },
                    Name = "Развлечения",
                }
            };

            // Привязываем серии к диаграмме
            pieChart.Series = pieSeries;
        }
    }
}