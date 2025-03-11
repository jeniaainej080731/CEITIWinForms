using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class SuccessLoginForm : Form
    {
        public SuccessLoginForm()
        {
            InitializeComponent();
        }

        private void SuccessLoginForm_Load(object sender, EventArgs e)
        {
            InitGifBackground();
            LabelBackTransparent(label1);
            ButtonBackTransparent(button1);
        }

        private void InitGifBackground()
        {
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = Image.FromFile("../../Images/back.gif"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            this.Controls.Add(pictureBox);
            pictureBox.SendToBack();
        }

        private void LabelBackTransparent(Label label)
        {
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.White;

            // Устанавливаем родителя label как PictureBox
            PictureBox pictureBox = this.Controls.OfType<PictureBox>().FirstOrDefault();

            if (pictureBox != null)
            {
                label.Parent = pictureBox;
                label.BringToFront();
            }
        }

        private void ButtonBackTransparent(Button button)
        {
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.White;

            PictureBox pictureBox = this.Controls.OfType<PictureBox>().FirstOrDefault();

            if (pictureBox != null)
            {
                button.Parent = pictureBox;
                button.BringToFront();
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
