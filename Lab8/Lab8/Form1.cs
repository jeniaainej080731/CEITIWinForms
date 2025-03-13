
using System.Data;
using Lab8;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;

namespace Lab8
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        private List<FuelPrice> fuelPrices = new List<FuelPrice>();

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitMatrixView();
        }

        private void InitMatrixView()
        {
            dataGridViewData.VirtualMode = true;
            dataGridViewData.EnableHeadersVisualStyles = false;

            dataGridViewData.EnableHeadersVisualStyles = false;

            dataGridViewData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewData.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.AllowUserToResizeColumns = false;
            dataGridViewData.AllowUserToResizeRows = false;
            dataGridViewData.ReadOnly = true;

            dataGridViewData.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            dataGridViewData.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            dataGridViewData.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);

            dataGridViewData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewData.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
            dataGridViewData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            dataGridViewData.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Firebrick;
            dataGridViewData.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewData.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewData.RowHeadersDefaultCellStyle.BackColor = Color.Wheat;
            dataGridViewData.RowHeadersDefaultCellStyle.ForeColor = Color.Olive;
            dataGridViewData.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Orange;
            dataGridViewData.RowHeadersDefaultCellStyle.SelectionForeColor = Color.SaddleBrown;

            dataGridViewData.RowHeadersWidth = 35;
            dataGridViewData.ColumnHeadersHeight = 60;
        }

        private void InitializeComboBox()
        {
            comboFuelType.Items.AddRange(new string[] { "Extra-98", "Premium-95", "Diesel", "Gaz" });
            comboFuelType.SelectedIndex = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл с данными о ценах на топливо";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    fuelPrices.Clear();

                    var lines = File.ReadAllLines(currentFilePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(' ');
                        fuelPrices.Add(new FuelPrice
                        {
                            Operator = parts[0],
                            Extra98 = double.Parse(parts[1]),
                            Premium95 = double.Parse(parts[2]),
                            Diesel = double.Parse(parts[3]),
                            Gaz = double.Parse(parts[4])
                        });
                    }
                    dataGridViewData.DataSource = null;
                    dataGridViewData.DataSource = fuelPrices;
                    MessageBox.Show("Данные успешно загружены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOperator.Text) ||
                !double.TryParse(txtExtra98.Text, out double extra98) ||
                !double.TryParse(txtPremium95.Text, out double premium95) ||
                !double.TryParse(txtDiesel.Text, out double diesel) ||
                !double.TryParse(txtGaz.Text, out double gaz))
            {
                MessageBox.Show("Пожалуйста, введите корректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fuelPrices.Any(fp => fp.Operator == txtOperator.Text))
            {
                MessageBox.Show("Данные для этого оператора уже существуют!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPrice = new FuelPrice
            {
                Operator = txtOperator.Text,
                Extra98 = extra98,
                Premium95 = premium95,
                Diesel = diesel,
                Gaz = gaz
            };
            fuelPrices.Add(newPrice);
            RefreshDataGridView();
            SaveToFile();
            ClearInputs();
            MessageBox.Show("Данные добавлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count > 0)
            {
                int index = dataGridViewData.SelectedRows[0].Index;
                fuelPrices[index] = new FuelPrice
                {
                    Operator = txtOperator.Text,
                    Extra98 = double.Parse(txtExtra98.Text),
                    Premium95 = double.Parse(txtPremium95.Text),
                    Diesel = double.Parse(txtDiesel.Text),
                    Gaz = double.Parse(txtGaz.Text)
                };
                RefreshDataGridView();
                SaveToFile();
                ClearInputs();
                MessageBox.Show("Данные отредактированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить данные?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dataGridViewData.SelectedRows.Count > 0 && result == DialogResult.Yes)
            {
                int index = dataGridViewData.SelectedRows[0].Index;
                fuelPrices.RemoveAt(index);
                RefreshDataGridView();
                SaveToFile();
                ClearInputs();
                MessageBox.Show("Данные удалены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            var values = new List<double>();
            var labels = new List<string>();

            foreach (var price in fuelPrices)
            {
                labels.Add(price.Operator);
                switch (comboFuelType.SelectedIndex)
                {
                    case 0: values.Add(price.Extra98); break;
                    case 1: values.Add(price.Premium95); break;
                    case 2: values.Add(price.Diesel); break;
                    case 3: values.Add(price.Gaz); break;
                }
            }

            chartFuelPrices.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Name = comboFuelType.SelectedItem.ToString(),
                    Values = values
                }
            };

            chartFuelPrices.XAxes = new List<Axis>
            {
                new Axis { Labels = labels }
            };

            chartFuelPrices.YAxes = new List<Axis>
            {
                new Axis { Name = "Цена" }
            };
        }

        private void SaveToFile()
        {
            var lines = new List<string>();
            foreach (var price in fuelPrices)
            {
                lines.Add($"{price.Operator} {price.Extra98} {price.Premium95} {price.Diesel} {price.Gaz}");
            }
            File.WriteAllLines(currentFilePath, lines);
        }

        private void ClearInputs()
        {
            txtOperator.Clear();
            txtExtra98.Clear();
            txtPremium95.Clear();
            txtDiesel.Clear();
            txtGaz.Clear();
        }

        private void RefreshDataGridView()
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = fuelPrices;
        }

        private void dataGridViewData_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count > 0)
            {
                var selectedPrice = (FuelPrice)dataGridViewData.SelectedRows[0].DataBoundItem;
                txtOperator.Text = selectedPrice.Operator;
                txtExtra98.Text = selectedPrice.Extra98.ToString();
                txtPremium95.Text = selectedPrice.Premium95.ToString();
                txtDiesel.Text = selectedPrice.Diesel.ToString();
                txtGaz.Text = selectedPrice.Gaz.ToString();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл с данными о ценах на топливо";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    fuelPrices.Clear();

                    var lines = File.ReadAllLines(currentFilePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(' ');
                        fuelPrices.Add(new FuelPrice
                        {
                            Operator = parts[0],
                            Extra98 = double.Parse(parts[1]),
                            Premium95 = double.Parse(parts[2]),
                            Diesel = double.Parse(parts[3]),
                            Gaz = double.Parse(parts[4])
                        });
                    }
                    dataGridViewData.DataSource = null;
                    dataGridViewData.DataSource = fuelPrices;
                    MessageBox.Show("Данные успешно загружены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOperator.Text) ||
                !double.TryParse(txtExtra98.Text, out double extra98) ||
                !double.TryParse(txtPremium95.Text, out double premium95) ||
                !double.TryParse(txtDiesel.Text, out double diesel) ||
                !double.TryParse(txtGaz.Text, out double gaz))
            {
                MessageBox.Show("Пожалуйста, введите корректные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fuelPrices.Any(fp => fp.Operator == txtOperator.Text))
            {
                MessageBox.Show("Данные для этого оператора уже существуют!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPrice = new FuelPrice
            {
                Operator = txtOperator.Text,
                Extra98 = extra98,
                Premium95 = premium95,
                Diesel = diesel,
                Gaz = gaz
            };
            fuelPrices.Add(newPrice);
            RefreshDataGridView();
            SaveToFile();
            ClearInputs();
            MessageBox.Show("Данные добавлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count > 0)
            {
                int index = dataGridViewData.SelectedRows[0].Index;
                fuelPrices[index] = new FuelPrice
                {
                    Operator = txtOperator.Text,
                    Extra98 = double.Parse(txtExtra98.Text),
                    Premium95 = double.Parse(txtPremium95.Text),
                    Diesel = double.Parse(txtDiesel.Text),
                    Gaz = double.Parse(txtGaz.Text)
                };
                RefreshDataGridView();
                SaveToFile();
                ClearInputs();
                MessageBox.Show("Данные отредактированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить данные?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show(
                    "Удаление отменено!",
                    "Мяумяумяумяу",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (dataGridViewData.SelectedRows.Count > 0 && result == DialogResult.Yes)
            {
                int index = dataGridViewData.SelectedRows[0].Index;
                fuelPrices.RemoveAt(index);
                RefreshDataGridView();
                SaveToFile();
                ClearInputs();
                MessageBox.Show("Данные удалены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
