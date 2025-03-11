using Lab7.Calculations;
using System.ComponentModel.DataAnnotations;
using System.Globalization; // Äëÿ CultureInfo

namespace Lab7
{
    public partial class ArrayForm : Form
    {
        private float[] Array;
        private bool InputFlag;
        Validator validator = new Validator();
        ArrayCalculations calc = new ArrayCalculations();

        public ArrayForm()
        {
            InitializeComponent();
            FormSetings();
        }

        private void FormSetings()
        {
            StartForm startForm = new StartForm();
            this.FormClosed += (s, e) => startForm.Show();
        }

        private void InputTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validator.ValidateArrayInput(InputTextBox, errorProvider, e, out Array);
            InputFlag = !e.Cancel;
        }

        private void DisplayArray()
        {
            OutputTextBox.Text = string.Join(", ", Array.Select(x => x.ToString(CultureInfo.InvariantCulture)));
        }

        private void FillArrayButton_Click(object sender, EventArgs e)
        {
            if (InputFlag && Array != null)
            {
                DisplayArray();
                AddButton.Enabled = true;
                FindButton.Enabled = true;
            }
            else
            {
                errorProvider.SetError(InputTextBox, "Please enter and validate numbers first");
            }
        }

        private void AddTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validator.ValidateSingleNumberInput(AddTextBox, errorProvider, e, out _);
        }

        private void FindTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validator.ValidateSingleNumberInput(FindTextBox, errorProvider, e, out _);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (InputFlag && Array != null && Array.Length > 0)
            {
                SumLabel.Text = calc.SumOfElements(Array).ToString();
                MinLabel.Text = calc.MinElement(Array).ToString();
                CountOfZerosLabel.Text = calc.CountOfZeros(Array).ToString();
                CountOfPosLabel.Text = calc.CountOfPositive(Array).ToString();
                CountOfNegLabel.Text = calc.CountOfNegative(Array).ToString();
            }
            else
            {
                errorProvider.SetError(InputTextBox, "Please enter and validate array first");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Array = calc.AddElement(Array, float.Parse(AddTextBox.Text));
            DisplayArray();
            MessageBox.Show(
                "Element added successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int index = calc.FindElement(Array, float.Parse(FindTextBox.Text));

            if (index == -1)
            {
                MessageBox.Show(
                "Element not found",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }

            MessageBox.Show(
                $"Element found successfully!\nIndex of element in array: {index}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}