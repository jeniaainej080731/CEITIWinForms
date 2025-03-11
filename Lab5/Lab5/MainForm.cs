using Microsoft.VisualBasic;

namespace Lab5
{
    public partial class MainForm : System.Windows.Forms.Form
    {
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
            // open input dialog for figures sizes
            string input;
        }
    }
}
