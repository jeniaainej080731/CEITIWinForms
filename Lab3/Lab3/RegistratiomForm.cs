using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Properties;
using Guna.UI2.WinForms;

namespace Lab3
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            AutorisationForm form = new AutorisationForm();
            this.FormClosed += (s, args) => form.Show();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            LoginTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            FullnameTextBox.Text = string.Empty;
            SexComboBox.SelectedIndex = -1;
            BirthdayTimePicker.TabIndex = 0;
            LangTextBox.Text = string.Empty;
            ForeignlangTextBox.Text = string.Empty;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            InitShowPassButton();
            InitSexComboBox();

            ForeignlangTextBox.ScrollBars = ScrollBars.Vertical;
        }

        private void InitSexComboBox()
        {
            SexComboBox.Items.Add("Male");
            SexComboBox.Items.Add("Female");
            SexComboBox.Items.Add("Other");
        }

        private void InitShowPassButton()
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            ShowpassButton.Image = Image.FromFile("../../Images/showPass.ico");
        }

        private void ShowpassButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;
            ShowpassButton.Image = Image.FromFile(PasswordTextBox.UseSystemPasswordChar ? "../../Images/showPass.ico" : "../../Images/hidePass.ico");
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            string validationMessage = ValidateInputs();

            if (SexComboBox.SelectedItem.ToString() == "Other")
            {
                MessageBox.Show(
                    "Trump said there are ONLY TWO genders!",
                    "FOOL!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(
                    "Registration successfully!", 
                    "Success!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Asterisk);
                AutorisationForm autorisationForm = new AutorisationForm();
                autorisationForm.Show();
                autorisationForm.SetRegInfo(GetLogin(), GetPassword());
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    validationMessage, 
                    "Error!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private string ValidateInputs() // идею валидации придумал я, исправил ошибки уже чат -_-
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text)) return "Login cannot be empty.";
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text) || PasswordTextBox.Text.Length < 4) return "Password must be at least 4 characters long.";
            if (!Regex.IsMatch(EmailTextBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) return "Invalid email format.";
            if (string.IsNullOrWhiteSpace(FullnameTextBox.Text)) return "Full name cannot be empty.";
            if (SexComboBox.SelectedIndex == -1) return "Please select your gender.";
            if (BirthdayTimePicker.Value > DateTime.Today.AddYears(-18)) return "You must be at least 18 years old.";
            if (string.IsNullOrWhiteSpace(LangTextBox.Text)) return "Native language cannot be empty.";
            if (string.IsNullOrWhiteSpace(ForeignlangTextBox.Text)) return "Foreign language cannot be empty.";
            return string.Empty;
        }

        public string GetLogin()
        {
            return LoginTextBox.Text;
        }

        public string GetPassword()
        {
            return PasswordTextBox.Text;
        }
    }
}