using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveChartsCore;              // �������� namespace ��� ������ � LiveChartsCore
using LiveChartsCore.SkiaSharpView; // Namespace ��� ��������� ��������
using LiveChartsCore.SkiaSharpView.WinForms; // Namespace ��� ��������� ���������� WinForms

namespace LiveChartsShow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load; // ���������� ���������� �������� �����
        }

        // ���������� ������� �������� �����
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupLineChart();    // ��������� �������� ���������
            SetupBarChart();     // ��������� ���������� ���������
            SetupScatterChart(); // ��������� �������� ���������
            SetupPieChart();     // ��������� �������� ���������
        }

        // ��������� �������� ��������� (����������� �� ���� ������)
        private void SetupLineChart()
        {
            // �������� ������: ������� ����������� �� ���� ������ (� �������� �������)
            var lineData = new double[] { 15, 17, 20, 19, 18, 16, 14 };

            // ������ ����� ��� �������� ���������
            var lineSeries = new LineSeries<double>
            {
                Values = lineData,      // ������������� ������
                Name = "�����������",   // �������� ����� ��� �������
            };

            // ����������� ����� � ���������
            cartesianChartLine.Series = new ISeries[] { lineSeries };

            // ����������� ��� X � ������� ���� ������
            cartesianChartLine.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = new string[] { "��", "��", "��", "��", "��", "��", "��" }
                }
            };
        }

        // ��������� ���������� ��������� (������ �� �������)
        private void SetupBarChart()
        {
            // �������� ������: ������ �������� �� ������� (� ������� ������)
            var barData = new double[] { 120, 150, 180, 200, 170, 160 };

            // ������ ����� ��� ���������� ���������
            var barSeries = new ColumnSeries<double>
            {
                Values = barData,         // ������������� ������
                Name = "������",          // �������� ����� ��� �������
            };

            // ����������� ����� � ���������
            cartesianChartBar.Series = new ISeries[] { barSeries };

            // ����������� ��� X � ������� �������
            cartesianChartBar.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = new string[] { "���", "���", "���", "���", "���", "���" }
                }
            };
        }

        // ��������� �������� ��������� (���� � ��� �����)
        private void SetupScatterChart()
        {
            // �������� ������: ���� (X, � ��) � ��� (Y, � ��) ��� 8 �������
            var scatterData = new List<double[]>
            {
                new double[] { 165, 60 },  // ������� 1
                new double[] { 170, 70 },  // ������� 2
                new double[] { 155, 50 },  // ������� 3
                new double[] { 180, 85 },  // ������� 4
                new double[] { 175, 75 },  // ������� 5
                new double[] { 160, 55 },  // ������� 6
                new double[] { 185, 90 },  // ������� 7
                new double[] { 168, 65 }   // ������� 8
            };

            // ������ ����� ��� �������� ���������
            var scatterSeries = new ScatterSeries<double[]>
            {
                Values = scatterData,          // ������������� ������
                Mapping = (point, index) => new(point[0], point[1]), // ��������� X (����) � Y (���)
                Name = "���� � ���",           // �������� ����� ��� �������
            };

            // ����������� ����� � ���������
            cartesianChartScatter.Series = new ISeries[] { scatterSeries };

            // ����������� ���
            cartesianChartScatter.XAxes = new List<Axis> { new Axis { Name = "���� (��)" } };
            cartesianChartScatter.YAxes = new List<Axis> { new Axis { Name = "��� (��)" } };
        }

        // ��������� �������� ��������� (������������� �������)
        private void SetupPieChart()
        {
            // �������� ������: ������������� ������� (� ���������)
            var pieData = new double[] { 50, 30, 15, 5 };

            // ������ ����� ��� �������� ���������
            var pieSeries = new PieSeries<double>[]
            {
                new PieSeries<double>
                {
                    Values = new double[] { pieData[0] },
                    Name = "���",
                },
                new PieSeries<double>
                {
                    Values = new double[] { pieData[1] },
                    Name = "�����",
                },
                new PieSeries<double>
                {
                    Values = new double[] { pieData[2] },
                    Name = "���������",
                },
                new PieSeries<double>
                {
                    Values = new double[] { pieData[3] },
                    Name = "�����������",
                }
            };

            // ����������� ����� � ���������
            pieChart.Series = pieSeries;
        }
    }
}