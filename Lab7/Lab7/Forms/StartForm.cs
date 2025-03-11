using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            SetupSetings();
        }

        private void SetupSetings()
        {
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void ArrayFormButton_Click(object sender, EventArgs e)
        {
            ArrayForm arrayForm = new ArrayForm();
            this.Hide();
            arrayForm.Show();
        }

        private void MatrixFormButton_Click(object sender, EventArgs e)
        {
            MatrixForm matrixForm = new MatrixForm();
            this.Hide();
            matrixForm.Show();
        }
    }
}
