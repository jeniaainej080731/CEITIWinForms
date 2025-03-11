using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab5.NET
{
    public partial class MainForm : Form
    {
        Calculations calculations = new Calculations();
        Draw draw = new Draw();
        Validate validate = new Validate();
        string inputs, FigureName;
        int figureCounter = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetTypes();
        }

        private void SetTypes()
        {
            FigureTypeComboBox.Items.AddRange(new string[] { "Flat", "Volumetric" });
            FigureTypeComboBox.SelectedIndex = 0;
        }

        private void SetFigures()
        {
            if (FigureTypeComboBox.SelectedIndex == 0)
            {
                FigureComboBox.Items.Clear();
                FigureComboBox.Items.AddRange(new string[] { "Circle", "Triangle", "Square", "Rectangle", "Parallelogram" });
                FigureComboBox.SelectedIndex = 0;
            }
            else if (FigureTypeComboBox.SelectedIndex == 1)
            {
                FigureComboBox.Items.Clear();
                FigureComboBox.Items.AddRange(new string[] { "Ball", "Pyramid", "Cube", "Parallelepiped", "Prism" });
                FigureComboBox.SelectedIndex = 0;
            }
        }

        private void FigureTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFigures();
        }

        private void InputSizesButton_Click(object sender, EventArgs e)
        {
            string figure = FigureComboBox.SelectedItem.ToString();
            string input = "";

            switch (figure)
            {
                case "Circle":
                    input = Interaction.InputBox("Enter radius:", "Circle", "10");
                    if (!validate.ValidateInput(input, out float radius)) return;
                    draw.DrawCircle(panel1);
                    inputs = input;
                    break;

                case "Triangle":
                    input = Interaction.InputBox("Enter three sides separated by commas (a,b,c):", "Triangle", "10,10,10");
                    if (!validate.ValidateTriangleInput(input, out float[] sides)) return;
                    draw.DrawTriangle(panel1);
                    inputs = input;
                    break;

                case "Square":
                    input = Interaction.InputBox("Enter side length:", "Square", "10");
                    if (!validate.ValidateInput(input, out float side)) return;
                    draw.DrawSquare(panel1);
                    inputs = input;
                    break;

                case "Rectangle":
                    input = Interaction.InputBox("Enter width and height separated by comma (w,h):", "Rectangle", "10,20");
                    if (!validate.ValidatePairInput(input, out float[] rectSides)) return;
                    draw.DrawRectangle(panel1);
                    inputs = input;
                    break;

                case "Parallelogram":
                    input = Interaction.InputBox("Enter base, height, and angle separated by commas (b,h,angle):", "Parallelogram", "10,20,30");
                    if (!validate.ValidateTripleInput(input, out float[] parallelogramParams)) return;
                    draw.DrawParallelogram(panel1);
                    inputs = input;
                    break;

                case "Ball":
                    input = Interaction.InputBox("Enter radius:", "Ball", "10");
                    if (!validate.ValidateInput(input, out float ballRadius)) return;
                    draw.DrawBall(panel1);
                    inputs = input;
                    break;

                case "Pyramid":
                    input = Interaction.InputBox("Enter base side and height separated by comma (side,h):", "Pyramid", "10,20");
                    if (!validate.ValidatePairInput(input, out float[] pyramidParams)) return;
                    draw.DrawPyramid(panel1);
                    inputs = input;
                    break;

                case "Cube":
                    input = Interaction.InputBox("Enter side length:", "Cube", "10");
                    if (!validate.ValidateInput(input, out float cubeSide)) return;
                    draw.DrawCube(panel1);
                    inputs = input;
                    break;

                case "Parallelepiped":
                    input = Interaction.InputBox("Enter width, height, and depth separated by commas (w,h,d):", "Parallelepiped", "10,20,30");
                    if (!validate.ValidateTripleInput(input, out float[] parallelepipedParams)) return;
                    draw.DrawParallelepiped(panel1);
                    inputs = input;
                    break;

                case "Prism":
                    input = Interaction.InputBox("Enter base side and height separated by comma (side,h):", "Prism", "10,20");
                    if (!validate.ValidatePairInput(input, out float[] prismParams)) return;
                    draw.DrawPrism(panel1);
                    inputs = input;
                    break;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputs))
            {
                MessageBox.Show("First, enter the dimensions of the figure!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string designation = AskForDesignation();
            string result;

            if (FigureTypeComboBox.SelectedIndex == 0) 
            {
                string perimeter = calculations.CalculatePerimeter(inputs, FigureComboBox.SelectedItem.ToString());
                string area = calculations.CalculateArea(inputs, FigureComboBox.SelectedItem.ToString());
                result = $"Designation: {designation}\nPerimeter: {perimeter}\nArea: {area}";
            }
            else 
            {
                string volume = calculations.CalculateVolume(inputs, FigureComboBox.SelectedItem.ToString());
                result = $"Designation: {designation}\nVolume: {volume}";
            }

            MessageBox.Show(
                result, 
                "Calculation Result", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }


        private string AskForDesignation()
        {
            if (MessageBox.Show("Do you want to specify figure designation?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string figure = FigureComboBox.SelectedItem.ToString();
                string prompt;
                string defaultValue;

                if (figure == "Circle")
                {
                    prompt = "Enter 1 capital letter:";
                    defaultValue = "C";
                }
                else if (figure == "Triangle")
                {
                    prompt = "Enter 3 capital letters:";
                    defaultValue = "ABC";
                }
                else
                {
                    prompt = "Enter 4 capital letters:";
                    defaultValue = "ABCD";
                }

                string input = Interaction.InputBox(prompt, figure, defaultValue);

                // Проверка корректности ввода обозначения
                if (figure == "Circle" && input.Length != 1) return "C";
                if (figure == "Triangle" && input.Length != 3) return "ABC";
                if (figure != "Circle" && figure != "Triangle" && input.Length != 4) return "ABCD";
                return input.ToUpper();
            }
            return $"Figure {figureCounter++}";
        }
    }
}