using System.Diagnostics.Eventing.Reader;

namespace Lab3
{
    public partial class AutorisationForm : Form
    {
        const string login = "root";
        const string password = "root";
        bool flag = false;

        public AutorisationForm()
        {
            InitializeComponent();

            this.FormClosed += (s, args) => Application.Exit();
        }

        private void AutorisationForm_Load(object sender, EventArgs e)
        {
            InitShowPassButton();
        }

        private void InitShowPassButton()
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            ShowpassButton.Image = Image.FromFile("../../Images/showPass.ico");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (flag ||
                (LoginTextBox.Text == login &&
                PasswordTextBox.Text == password))
            {
                MessageBox.Show(
                    "Autorisation successfully!",
                    "Success!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);

                SuccessLoginForm form = new SuccessLoginForm();
                form.FormClosed += (s, args) => Application.Exit(); // дл€ закрыти€ всей программы
                form.Show();
                this.Hide(); // Hide() только пр€чет форму, а не закрывает ее
            }
            else
            {
                MessageBox.Show(
                    "Please enter login and password",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            LoginTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        private void SignupLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            this.Hide();
        }

        private void ShowpassButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                ShowpassButton.Image = Image.FromFile("../../Images/hidePass.ico");
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                ShowpassButton.Image = Image.FromFile("../../Images/showPass.ico");
            }
            ShowpassButton.ImageAlign = ContentAlignment.MiddleCenter;
            ShowpassButton.AutoSizeMode = (AutoSizeMode)PictureBoxSizeMode.StretchImage;
        }

        public void SetRegInfo(string Login, string Pass)
        {
            if (!string.IsNullOrEmpty(Login) &&
                !string.IsNullOrEmpty(Pass))
            {
                LoginTextBox.Text = Login;
                PasswordTextBox.Text = Pass;
                flag = true;
            }
        }
    }
}
