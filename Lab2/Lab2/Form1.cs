using Microsoft.VisualBasic.Devices;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace Lab2
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            const int animationDuration = 200;
            const int animationFlags = AW_BLEND | AW_HIDE;

            AnimateWindow(this.Handle, animationDuration, animationFlags);
            this.Close();

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int animationDuration = 200;
            const int animationFlags = AW_BLEND | AW_CENTER | AW_ACTIVATE;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);

            AnimateWindow(this.Handle, animationDuration, animationFlags);

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (s, args) =>
            {
                Random rand = new Random();
                Color startColor = this.BackColor;
                Color endColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                int steps = 35;
                for (int i = 0; i <= steps; i++)
                {
                    int r = startColor.R + (endColor.R - startColor.R) * i / steps;
                    int g = startColor.G + (endColor.G - startColor.G) * i / steps;
                    int b = startColor.B + (endColor.B - startColor.B) * i / steps;
                    this.BackColor = Color.FromArgb(r, g, b);
                    this.Invalidate();
                    this.Update();
                    System.Threading.Thread.Sleep(timer.Interval / steps);
                }
            };
            timer.Start();
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

        private void FirstForm_Click(object sender, EventArgs e)
        {
            First form = new First();
            form.ShowDialog();
        }

        private void SecondForm_Click(object sender, EventArgs e)
        {
            Second form = new Second();
            form.ShowDialog();
        }

        private void ThirdForm_Click(object sender, EventArgs e)
        {
            Third form = new Third();
            form.ShowDialog();
        }
    }
}
