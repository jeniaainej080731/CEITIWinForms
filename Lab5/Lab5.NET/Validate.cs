﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.NET
{
    internal class Validate
    {
        public Validate() { }

        public bool ValidateInput(string input, out float value)
        {
            if (string.IsNullOrWhiteSpace(input) || !float.TryParse(input, out value) || value <= 0)
            {
                MessageBox.Show("Please enter a valid numeric value greater than 0!", "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                value = 0;
                return false;
            }
            return true;
        }

        public bool ValidatePairInput(string input, out float[] values)
        {
            values = new float[2];
            string[] parts = input.Split(',');
            if (parts.Length != 2 || !float.TryParse(parts[0], out values[0]) || !float.TryParse(parts[1], out values[1]) || values[0] <= 0 || values[1] <= 0)
            {
                MessageBox.Show("Please enter two valid numeric values ​​separated by commas, greater than 0!", "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateTripleInput(string input, out float[] values)
        {
            values = new float[3];
            string[] parts = input.Split(',');
            if (parts.Length != 3 || !float.TryParse(parts[0], out values[0]) || !float.TryParse(parts[1], out values[1]) ||
                !float.TryParse(parts[2], out values[2]) || values[0] <= 0 || values[1] <= 0 || values[2] <= 0)
            {
                MessageBox.Show("Please enter three valid numeric values ​​separated by commas, greater than 0!", "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateTriangleInput(string input, out float[] sides)
        {
            sides = new float[3];
            string[] parts = input.Split(',');
            if (parts.Length != 3 || !float.TryParse(parts[0], out sides[0]) || !float.TryParse(parts[1], out sides[1]) ||
                !float.TryParse(parts[2], out sides[2]) || sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0)
            {
                MessageBox.Show("Please enter three valid numeric values ​​separated by commas, greater than 0!", "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (sides[0] + sides[1] <= sides[2] || sides[1] + sides[2] <= sides[0] || sides[0] + sides[2] <= sides[1])
            {
                MessageBox.Show("A triangle with such sides does not exist!", "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
