using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class FlagForm : Form
    {
        public FlagForm(string flagPath)
        {
            InitializeComponent();
            this.Text = "Flag";
            this.Size = new Size(300, 300);
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = File.Exists(flagPath) ? Image.FromFile(flagPath) : null,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            this.Controls.Add(pictureBox);
        }
    }
}
