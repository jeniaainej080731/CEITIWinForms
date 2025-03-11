using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class First : Form
    {
        Point point;

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

        private const int AW_SLIDE = 0X40000;
        private const int AW_HOR_POSITIVE = 0X1;
        private const int AW_HOR_NEGATIVE = 0X2;
        private const int AW_VER_POSITIVE = 0X4;
        private const int AW_VER_NEGATIVE = 0X8;
        private const int AW_CENTER = 0X10;
        private const int AW_HIDE = 0X10000;
        private const int AW_ACTIVATE = 0X20000;
        private const int AW_BLEND = 0X80000;

        public First()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            const int animationDuration = 150;
            const int animationFlags = AW_SLIDE | AW_HOR_POSITIVE | AW_HIDE;

            AnimateWindow(this.Handle, animationDuration, animationFlags);

            this.Close();
        }

        private void First_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            const int animationDuration = 150;
            const int animationFlags = AW_SLIDE | AW_HOR_POSITIVE | AW_ACTIVATE;

            AnimateWindow(this.Handle, animationDuration, animationFlags);
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            if (double.TryParse(InputTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double inputValue))
            {
                double result;
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "American Pound":
                        result = inputValue * 2.205;
                        break;
                    case "Russian Pound":
                        result = inputValue * 2.442;
                        break;
                    default:
                        result = inputValue * 16.381;
                        break;
                }

                Result.Text = Math.Round(result, 2).ToString();
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] nums = InputTextBox.Text.Split('.');

            if (InputTextBox.Text.Contains("."))
            {
                if (nums.Length > 1 && nums[1].Length > 2)
                {
                    InputTextBox.Text = nums[0] + "." + nums[1].Substring(0, 2);
                    InputTextBox.SelectionStart = InputTextBox.Text.Length;
                }
            }

            ConvertButton.Enabled = !string.IsNullOrEmpty(InputTextBox.Text);
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;

            if (!Char.IsDigit(num) && num != 8 && num != 44)
            {
                e.Handled = true;
            }

            if (num == 44)
            {
                if (InputTextBox.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point deltaPos = new Point(e.X - point.X, e.Y - point.Y);
                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }
    }
}
