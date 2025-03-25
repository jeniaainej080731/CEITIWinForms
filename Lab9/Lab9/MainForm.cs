using System.ComponentModel;

namespace Lab9
{
    public partial class MainForm : Form
    {
        // BindingList - это список, который автоматически обновляет
        // связанный элемент управления
        private BindingList<Country> countries = new BindingList<Country>();
        // BindingSource - обеспечивает простой способ связывания
        // списков с несколькими элементами управления
        private BindingSource bindingSource = new BindingSource();

        // Свойство AutoScaleMode - устанавливает режим масштабирования
        [System.ComponentModel.Browsable(false)]
        public System.Windows.Forms.AutoScaleMode AutoScaleMode { get; set; }

        private Dictionary<string, Image> flagCache = new Dictionary<string, Image>();
        public MainForm()
        {
            InitializeComponent();
            InitDataGridView();
            bindingSource.DataSource = countries;
            dataGridView1.DataSource = bindingSource;
            SetFormOptions();
        }

        private void SetFormOptions()
        {
            this.FormClosing += (s, e) =>
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    DialogResult resultSave = MessageBox.Show("Сохранить данные перед закрытием?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                    if (resultSave == DialogResult.Yes)
                    {
                        saveToolStripMenuItem_Click(s, e);
                    }
                    else if (resultSave == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                else
                {
                    e.Cancel = true;
                }

                // Установка режима масштабирования
                this.AutoScaleMode = AutoScaleMode.Font;
                this.AutoScaleDimensions = new SizeF(6F, 13F);
            };
        }

        private void InitDataGridView()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Название",
                MinimumWidth = 100
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Capital",
                DataPropertyName = "Capital",
                HeaderText = "Столица",
                MinimumWidth = 100
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Population",
                DataPropertyName = "Population",
                HeaderText = "Население",
                MinimumWidth = 80
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GovernmentType",
                DataPropertyName = "GovernmentType",
                HeaderText = "Тип правления",
                MinimumWidth = 100
            });
            var flagColumn = new DataGridViewImageColumn
            {
                Name = "Flag",
                HeaderText = "Флаг",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                MinimumWidth = 50
            };

            dataGridView1.Columns.Add(flagColumn);

            // Стили ячеек
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12); // Уменьшен размер, убрано Bold
            dataGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke; // Светлый фон
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Чёрный текст для читаемости
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue; // Мягкий цвет выделения
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Стили заголовков столбцов
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSeaGreen; // Более мягкий цвет
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Белый текст для контраста
            dataGridView1.ColumnHeadersHeight = 40; // Фиксированная высота заголовков

            // Стили заголовков строк (номеров)
            dataGridView1.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightGray; // Нейтральный фон
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray; // Тёмный текст
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Silver; // Цвет выделения
            dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            // Масштабирование
            dataGridView1.Columns[0].MinimumWidth = 100;
            dataGridView1.Columns[1].MinimumWidth = 100;
            dataGridView1.Columns[2].MinimumWidth = 80;
            dataGridView1.Columns[3].MinimumWidth = 100;
            dataGridView1.Columns[4].MinimumWidth = 50;

            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                AnchorStyles.Left | AnchorStyles.Right;
        }

        private void UpdateStatistics()
        {
            if (countries.Any())
            {
                var minCountry = countries.OrderBy(c => c.Population).First();
                var maxCountry = countries.OrderByDescending(c => c.Population).First();
                lblMinPopulation.Text = $"Мин. население: {minCountry.Name} ({FormatPopulation(minCountry.Population)})";
                lblMaxPopulation.Text = $"Макс. население: {maxCountry.Name} ({FormatPopulation(maxCountry.Population)})";
            }
            else
            {
                lblMinPopulation.Text = "Мин. население: -";
                lblMaxPopulation.Text = "Макс. население: -";
            }
        }

        private string FormatPopulation(int population)
        {
            if (population >= 1_000_000_000) // Миллиарды
                return $"{population / 1_000_000_000.0:F1} млрд.";
            else if (population >= 1_000_000) // Миллионы
                return $"{population / 1_000_000.0:F1} млн.";
            else if (population >= 1_000) // Тысячи
                return $"{population / 1_000.0:F1} тыс.";
            else
                return population.ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var country = (Country)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (country != null)
                {
                    if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                    {
                        if (!string.IsNullOrEmpty(country.FlagPath) && File.Exists(country.FlagPath))
                        {
                            if (!flagCache.ContainsKey(country.FlagPath))
                            {
                                flagCache[country.FlagPath] = Image.FromFile(country.FlagPath);
                            }
                            e.Value = flagCache[country.FlagPath];
                        }
                        else
                        {
                            e.Value = null;
                        }
                    }
                    else if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Population")
                    {
                        e.Value = FormatPopulation(country.Population);
                    }
                }
                else
                {
                    e.Value = null;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog { Filter = "Text files (*.txt)|*.txt" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var lines = File.ReadAllLines(dialog.FileName);
                        countries.Clear();
                        foreach (var line in lines)
                        {
                            var parts = line.Split(',');
                            if (parts.Length == 5)
                            {
                                countries.Add(new Country
                                {
                                    Name = parts[0].Trim(),
                                    Capital = parts[1].Trim(),
                                    Population = int.Parse(parts[2].Trim()),
                                    GovernmentType = parts[3].Trim(),
                                    FlagPath = parts[4].Trim()
                                });
                            }
                        }
                        MessageBox.Show("Данные загружены.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "Text files (*.txt)|*.txt" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var lines = countries.Select(c => $"{c.Name},{c.Capital},{c.Population},{c.GovernmentType},{c.FlagPath}");
                        File.WriteAllLines(dialog.FileName, lines);
                        MessageBox.Show("Данные сохранены.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
                    }
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditCountryForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    countries.Add(form.Country);
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var country = (Country)dataGridView1.SelectedRows[0].DataBoundItem;
                using (var form = new AddEditCountryForm(country))
                {
                    if (form.ShowDialog() == DialogResult.OK) { }
                }
            }
            else
                MessageBox.Show("Выберите страну для редактирования.");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var country = (Country)dataGridView1.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Удалить {country.Name}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    countries.Remove(country);
                }
            }
            else
                MessageBox.Show("Выберите страну для удаления.");
        }

        private void setTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    lblMaxPopulation.ForeColor = dialog.Color;
                    lblMinPopulation.ForeColor = dialog.Color;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                        column.DefaultCellStyle.ForeColor = dialog.Color;
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.BackgroundColor = dialog.Color;
                    this.BackColor = dialog.Color;
                }

            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog { Filter = "Image files (*.png;*.jpg)|*.png;*.jpg" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.BackgroundImage = Image.FromFile(dialog.FileName);
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                    }
                }
            }
        }

        private void showStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (countries.Any())
            {
                var minCountry = countries.OrderBy(c => c.Population).First();
                var maxCountry = countries.OrderByDescending(c => c.Population).First();
                UpdateStatistics();
            }
            else
                MessageBox.Show("Список стран пуст.");
        }

        private void showDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiagramForm diagramForm = new DiagramForm(countries);
            diagramForm.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var country = (Country)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (country != null && !string.IsNullOrEmpty(country.FlagPath) && File.Exists(country.FlagPath))
                {
                    FlagForm flagForm = new FlagForm(country.FlagPath);
                    flagForm.Show();
                }
            }
        }
    }
}
