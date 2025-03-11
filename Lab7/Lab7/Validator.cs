using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    internal class Validator
    {
        public Validator() { }

        public bool ValidateArrayInput(TextBox inputTextBox, ErrorProvider errorProvider, CancelEventArgs e, out float[] array)
        {
            array = null;
            string input = inputTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                errorProvider.SetError(inputTextBox, "Please enter a value");
                return false;
            }

            if (!Regex.IsMatch(input, @"^(-?\d*\.?\d+(?:[ ,]+-?\d*\.?\d+)*)?$"))
            {
                errorProvider.SetError(inputTextBox, "Enter numbers separated by commas or spaces (e.g., 1, 2.5, -3 or 1 2.5 -3)");
                return false;
            }

            try
            {
                array = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => float.Parse(s, CultureInfo.InvariantCulture))
                    .ToArray();
                errorProvider.SetError(inputTextBox, null);
                return true;
            }
            catch (FormatException)
            {
                errorProvider.SetError(inputTextBox, "Invalid number format (use '.' for decimal point)");
                return false;
            }
        }

        public bool ValidateSingleNumberInput(TextBox inputTextBox, ErrorProvider errorProvider, CancelEventArgs e, out float number)
        {
            number = 0;
            string input = inputTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                errorProvider.SetError(inputTextBox, "Please enter a value");
                return false;
            }

            if (!Regex.IsMatch(input, @"^-?\d*\.?\d+$"))
            {
                errorProvider.SetError(inputTextBox, "Enter a valid number (e.g., 1, -2.5)");
                return false;
            }

            try
            {
                number = float.Parse(input, CultureInfo.InvariantCulture);
                errorProvider.SetError(inputTextBox, null);
                return true;
            }
            catch (FormatException)
            {
                errorProvider.SetError(inputTextBox, "Invalid number format (use '.' for decimal point)");
                return false;
            }
        }

        public bool ValidateMatrixInput(TextBox inputTextBox, ErrorProvider errorProvider, CancelEventArgs e, int n, int m, out float[,] matrix)
        {
            matrix = null;
            string input = inputTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                errorProvider.SetError(inputTextBox, "Please enter a value");
                return false;
            }

            string[] elements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (elements.Length != n * m)
            {
                errorProvider.SetError(inputTextBox, $"Expected {n * m} numbers, but got {elements.Length}");
                return false;
            }

            try
            {
                matrix = new float[n, m];
                int index = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = float.Parse(elements[index++], CultureInfo.InvariantCulture);
                    }
                }
                errorProvider.SetError(inputTextBox, null);
                return true;
            }
            catch (FormatException)
            {
                errorProvider.SetError(inputTextBox, "Invalid number format (use '.' for decimal point)");
                return false;
            }
        }

        public bool ValidatePositiveIntegerInput(TextBox inputTextBox, ErrorProvider errorProvider, CancelEventArgs e, out int value)
        {
            value = 0;
            if (!int.TryParse(inputTextBox.Text, out value) || value <= 0)
            {
                errorProvider.SetError(inputTextBox, "Enter a positive integer!");
                return false;
            }
            errorProvider.SetError(inputTextBox, null); // Очищаем ошибку
            return true;
        }

        public bool ValidateAddColumnInput(TextBox textBox, ErrorProvider errorProvider, CancelEventArgs e, int expectedRows, out float[] column)
        {
            column = null;
            string input = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                errorProvider.SetError(textBox, "Input cannot be empty!");
                return false;
            }

            string[] elements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (elements.Length != expectedRows)
            {
                errorProvider.SetError(textBox, $"Column must contain exactly {expectedRows} values!");
                return false;
            }

            try
            {
                column = elements.Select(s => float.Parse(s, CultureInfo.InvariantCulture)).ToArray();
                errorProvider.SetError(textBox, null); // Очистка ошибки, если всё в порядке
                return true;
            }
            catch (FormatException)
            {
                errorProvider.SetError(textBox, "Invalid number format! Use '.' for decimal separator.");
                return false;
            }
        }
    }
}