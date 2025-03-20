using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab9
{
    public partial class AddEditCountryForm : Form
    {
        public Country Country { get; private set; }
        public AddEditCountryForm(Country country = null)
        {
            InitializeComponent();
            GovernmentType.Items.AddRange(new[] { "Republic", "Monarchy", "Federation" });
            GovernmentType.SelectedIndex = 0;

            if (country != null)
            {
                NameTxtBox.Text = country.Name;
                CapitalTxtBox.Text = country.Capital;
                PopulationNum.Text = country.Population.ToString(); 
                GovernmentType.SelectedItem = country.GovernmentType;
                FlagPathTxtBox.Text = country.FlagPath;
                Country = country;
            }
            else
            {
                Country = new Country
                {
                    Name = string.Empty,
                    Capital = string.Empty,
                    Population = 0,
                    GovernmentType = string.Empty,
                    FlagPath = string.Empty
                };
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog { Filter = "Image files (*.png;*.jpg)|*.png;*.jpg" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    FlagPathTxtBox.Text = dialog.FileName;
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Country.Name = NameTxtBox.Text;
                Country.Capital = CapitalTxtBox.Text;
                Country.Population = int.Parse(PopulationNum.Text);
                Country.GovernmentType = GovernmentType.SelectedItem.ToString();
                Country.FlagPath = FlagPathTxtBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                MessageBox.Show("Уверены, что хотите выйти?",
                    "Are you sure?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes) Close();
                else return;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(NameTxtBox.Text) ||
                string.IsNullOrWhiteSpace(CapitalTxtBox.Text) ||
                !int.TryParse(PopulationNum.Text, out int pop) || pop < 0 ||
                GovernmentType.SelectedItem == null ||
                string.IsNullOrWhiteSpace(FlagPathTxtBox.Text))
            {
                MessageBox.Show("Заполните все поля корректно!");
                return false;
            }
            return true;
        }

        
    }
}
