using Guna.UI2.WinForms;
using Lab7.Calculations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class MatrixForm : Form
    {
        private bool InputFlag;
        int n, m;
        float[,] Matrix;
        Validator validator = new Validator();
        MatrixCalculations calc = new MatrixCalculations();
        public MatrixForm()
        {
            InitializeComponent();
            FormSetings();
            InitMatrixView();
            InitContextMenu();
        }

        private void FormSetings()
        {
            StartForm startForm = new StartForm();
            this.FormClosed += (s, e) => startForm.Show();
        }

        private void InitContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Random fill", null, (s, e) =>
            {
                Matrix = calc.FillMatrixRandom(n, m);
                DisplayMatrix();
                EnableUI();
            });

            FillMatrixButton.ContextMenuStrip = contextMenu;
            FillMatrixButton.MouseUp += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenu.Show(FillMatrixButton, e.Location);
                }
            };
        }

        private void InitMatrixView()
        {
            MatrixView.VirtualMode = true;
            MatrixView.EnableHeadersVisualStyles = false;

            MatrixView.EnableHeadersVisualStyles = false;

            MatrixView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            MatrixView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MatrixView.DefaultCellStyle.Font = new Font("Arial", 10);
            MatrixView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MatrixView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            MatrixView.AllowUserToAddRows = false;
            MatrixView.AllowUserToDeleteRows = false;
            MatrixView.AllowUserToResizeColumns = false;
            MatrixView.AllowUserToResizeRows = false;
            MatrixView.ReadOnly = true;

            MatrixView.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            MatrixView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            MatrixView.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);

            MatrixView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MatrixView.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
            MatrixView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            MatrixView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Firebrick;
            MatrixView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            MatrixView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            MatrixView.RowHeadersDefaultCellStyle.BackColor = Color.Wheat;
            MatrixView.RowHeadersDefaultCellStyle.ForeColor = Color.Olive;
            MatrixView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Orange;
            MatrixView.RowHeadersDefaultCellStyle.SelectionForeColor = Color.SaddleBrown;
        }

        private void MatrixView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (Matrix != null && e.RowIndex < n && e.ColumnIndex < m)
            {
                e.Value = Matrix[e.RowIndex, e.ColumnIndex];
            }
        }

        private void MatrixView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Ignore header clicks

            // Clear previous selection
            foreach (DataGridViewRow row in MatrixView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Reset the background color of all cells
                    cell.Style.BackColor = MatrixView.DefaultCellStyle.BackColor;
                }
            }

            foreach (DataGridViewColumn col in MatrixView.Columns)
            {
                // Reset the background color of all column cells
                foreach (DataGridViewRow row in MatrixView.Rows)
                {
                    row.Cells[col.Index].Style.BackColor = MatrixView.DefaultCellStyle.BackColor;
                }
            }

            // Highlight the selected row
            foreach (DataGridViewCell cell in MatrixView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.LightBlue;
            }

            // Highlight the selected column
            foreach (DataGridViewRow row in MatrixView.Rows)
            {
                row.Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
            }

            // Highlight the selected cell
            MatrixView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightCoral;
        }


        private void InitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CountRowsTextBox.Text) || string.IsNullOrWhiteSpace(CountColumnsTextBox.Text))
            {
                MessageBox.Show("Please enter the number of rows and columns");
                return;
            }

            try
            {
                n = int.Parse(CountRowsTextBox.Text);
                m = int.Parse(CountColumnsTextBox.Text);

                if (n <= 0 || m <= 0)
                {
                    MessageBox.Show("Number of rows and columns must be positive");
                    return;
                }

                Matrix = new float[n, m];
                FillMatrixButton.Enabled = true;
                InputTextBox.Enabled = true;
                errorProvider.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer numbers for rows and columns");
            }
        }

        private void DisplayMatrix()
        {
            if (Matrix == null) return;

            if (MatrixView.ColumnCount != m)
            {
                MatrixView.Columns.Clear();
                for (int j = 0; j < m; j++)
                {
                    MatrixView.Columns.Add($"Col{j}", $"Col {j + 1}");
                    MatrixView.Columns[j].Width = 60; 
                }
            }

            if (MatrixView.RowCount != n)
            {
                MatrixView.RowCount = n;
            }

            for (int i = 0; i < n; i++)
            {
                MatrixView.Rows[i].HeaderCell.Value = $"Row {i + 1}";
            }
            MatrixView.RowHeadersWidth = 100; 
            MatrixView.ColumnHeadersHeight = 60; 
            MatrixView.Refresh(); 
        }

        private void EnableUI()
        {
            DeleteRowTextBox.Enabled = true;
            AddColumnTextBox.Enabled = true;
            CalculateButton.Enabled = true;
            SortGroupBox.Enabled = true;
            AddButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void FillMatrixButton_Click(object sender, EventArgs e)
        {
            if (InputFlag && Matrix != null)
            {
                try
                {
                    string[] elements = InputTextBox.Text.Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (elements.Length != n * m)
                    {
                        errorProvider.SetError(InputTextBox, $"Expected {n * m} numbers, but got {elements.Length}");
                        return;
                    }

                    int index = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Matrix[i, j] = float.Parse(elements[index++], CultureInfo.InvariantCulture);
                        }
                    }

                    DisplayMatrix();
                    EnableUI();
                    errorProvider.SetError(InputTextBox, null);
                }
                catch (FormatException)
                {
                    errorProvider.SetError(InputTextBox, "Invalid number format (use '.' for decimal point)");
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(InputTextBox, "Error filling matrix: " + ex.Message);
                }
            }
            else
            {
                errorProvider.SetError(InputTextBox, "Please validate the input first");
            }
        }

        private void InputTextBox_Validating(object sender, CancelEventArgs e)
        {
            validator.ValidateMatrixInput(InputTextBox, errorProvider, e, n, m, out Matrix);
            InputFlag = !e.Cancel;
        }

        private void DeleteRowTextBox_Validating(object sender, CancelEventArgs e)
        {
            validator.ValidatePositiveIntegerInput(DeleteRowTextBox, errorProvider, e, out _);
        }

        private void AddColumnTextBox_Validating(object sender, CancelEventArgs e)
        {
            validator.ValidateAddColumnInput(AddColumnTextBox, errorProvider, e, Matrix.GetLength(0), out _);
        }

        private void CountRowsTextBox_Validating(object sender, CancelEventArgs e)
        {
            validator.ValidatePositiveIntegerInput(CountRowsTextBox, errorProvider, e, out _);
        }

        private void CountColumnsTextBox_Validating(object sender, CancelEventArgs e)
        {
            validator.ValidatePositiveIntegerInput(CountColumnsTextBox, errorProvider, e, out _);
        }

        // очень долго не вдуплял, как реализовать вызов методов AddColumn и DeleteRow
        // поэтому кинул чату
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Matrix == null || Matrix.GetLength(0) == 0)
            {
                MessageBox.Show("The matrix is ​​already empty!");
                return;
            }

            DialogResult answ = 
                MessageBox.Show(
                    "Are you sure?",
                    "Deleting!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

            if (answ == DialogResult.Yes)
            {
                try
                {
                    int rowToDelete = int.Parse(DeleteRowTextBox.Text);
                    if (rowToDelete < 1 || rowToDelete > Matrix.GetLength(0))
                    {
                        MessageBox.Show("Invalid row index!");
                        return;
                    }

                    Matrix = calc.DeleteRow(Matrix, rowToDelete - 1); // Индексация с 0!
                    n--;  // Обновляем количество строк
                    DisplayMatrix();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid line number!");
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Matrix == null)
            {
                MessageBox.Show("Matrix is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (n <= 0)
            {
                MessageBox.Show(
                    "Matrix don't have rows!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string[] elements = AddColumnTextBox.Text.Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (elements.Length != Matrix.GetLength(0) || n > 0)
            {
                MessageBox.Show($"Expected {Matrix.GetLength(0)} numbers, but got {elements.Length}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float[] newColumn = new float[Matrix.GetLength(0)];
            for (int i = 0; i < elements.Length; i++)
            {
                if (!float.TryParse(elements[i], NumberStyles.Float, CultureInfo.InvariantCulture, out newColumn[i]))
                {
                    MessageBox.Show($"Invalid input at position {i + 1}! Enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                Matrix = calc.AddColumn(Matrix, newColumn); // Add the new column
                m++; // Increase the number of columns
                DisplayMatrix(); // Redraw the table
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding column: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AscSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Matrix = calc.SortMatrixRow(Matrix, true);
            DisplayMatrix();
        }

        private void DescSortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Matrix = calc.SortMatrixRow(Matrix, false);
            DisplayMatrix();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string multiplyResult = calc.MultiplyElements(Matrix).ToString();
            string maxResult = calc.FindMaxInRows(Matrix);
            string countOfEvensResult = calc.CountEvens(Matrix);
            string countOfOddsResult = calc.CountOddsInColumns(Matrix);

            DisplayResultInTextBox(MultiplyLabel, multiplyResult);
            DisplayResultInTextBox(MaxLabel, maxResult);
            DisplayResultInTextBox(CountOfEvensLabel, countOfEvensResult);
            DisplayResultInTextBox(CountOfOddsLabel, countOfOddsResult);
        }

        //я устал, кастомизацию доверяю чату
        private void DisplayResultInTextBox(Guna2HtmlLabel textBox, string result)
        {
            string truncatedResult = result.Length > 6 ? result.Substring(0, 6) + "..." : result;

            textBox.Text = truncatedResult;

            ToolTip toolTip = new ToolTip();
            toolTip.OwnerDraw = true;
            toolTip.Draw += (s, e) =>
            {
                e.DrawBackground();
                e.DrawBorder();
                e.Graphics.DrawString(result, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(2, 2));
            };
            toolTip.Popup += (s, e) =>
            {
                Size textSize = TextRenderer.MeasureText(result, new Font("Arial", 14, FontStyle.Bold));
                e.ToolTipSize = new Size(textSize.Width + 4, textSize.Height + 4);
            };
            toolTip.SetToolTip(textBox, result);
        }

    }
}
