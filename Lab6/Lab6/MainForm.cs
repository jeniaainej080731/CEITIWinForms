using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab6
{
    public partial class MainForm : Form
    {
        private Random random = new Random();
        private Point[] snowflakes; // Массив снежинок
        private int snowflakeCount = 50; // Количество снежинок

        public MainForm()
        {
            InitializeComponent();

            // Initialize snowflakes array and set random starting positions
            snowflakes = new Point[snowflakeCount];
            for (int i = 0; i < snowflakeCount; i++)
            {
                snowflakes[i] = new Point(random.Next(0, pictureBox1.Width), random.Next(0, pictureBox1.Height));
            }
        }

        private void DrawSnowmanButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void DrawSnowman(Graphics graphics)
        {
            float centerX = pictureBox1.Width / 2;  // Центр по горизонтали
            float centerY = pictureBox1.Height / 2; // Центр по вертикали

            // Настройки для сглаживания и кисти
            Brush whiteBrush = new SolidBrush(Color.White);
            Pen blackPen = new Pen(Color.Black, 2);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush orangeBrush = new SolidBrush(Color.Orange);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush grayBrush = new SolidBrush(Color.Gray); // Для теней и шляпы

            // Нижний шар (основание) - больший размер
            float bottomRadius = 80;
            graphics.FillEllipse(whiteBrush, centerX - bottomRadius, centerY + 20, bottomRadius * 2, bottomRadius * 2);
            graphics.DrawEllipse(blackPen, centerX - bottomRadius, centerY + 20, bottomRadius * 2, bottomRadius * 2);

            // Средний шар
            float middleRadius = 60;
            graphics.FillEllipse(whiteBrush, centerX - middleRadius, centerY - 60, middleRadius * 2, middleRadius * 2);
            graphics.DrawEllipse(blackPen, centerX - middleRadius, centerY - 60, middleRadius * 2, middleRadius * 2);

            // Голова
            float headRadius = 40;
            graphics.FillEllipse(whiteBrush, centerX - headRadius, centerY - 160, headRadius * 2, headRadius * 2);
            graphics.DrawEllipse(blackPen, centerX - headRadius, centerY - 160, headRadius * 2, headRadius * 2);

            // Глаза (черные)
            graphics.FillEllipse(blackBrush, centerX - 15, centerY - 170, 10, 10); // Левый глаз
            graphics.FillEllipse(blackBrush, centerX + 5, centerY - 170, 10, 10);  // Правый глаз

            // Нос (оранжевый треугольник)
            PointF[] nose =
            {
                new PointF(centerX, centerY - 150),
                new PointF(centerX + 20, centerY - 130),
                new PointF(centerX, centerY - 130)
            };
            graphics.FillPolygon(orangeBrush, nose);

            // Пуговицы (черные)
            graphics.FillEllipse(blackBrush, centerX - 10, centerY - 40, 8, 8);  // Верхняя пуговица
            graphics.FillEllipse(blackBrush, centerX - 10, centerY, 8, 8);       // Средняя пуговица
            graphics.FillEllipse(blackBrush, centerX - 10, centerY + 40, 8, 8);  // Нижняя пуговица

            // Руки (линии)
            graphics.DrawLine(blackPen, centerX - 60, centerY - 40, centerX - 100, centerY - 80); // Левая рука
            graphics.DrawLine(blackPen, centerX + 60, centerY - 40, centerX + 100, centerY - 80); // Правая рука

            // Шляпа (черная с серой тенью)
            graphics.FillRectangle(blackBrush, centerX - 40, centerY - 220, 80, 20); // Тулья шляпы
            graphics.FillEllipse(blackBrush, centerX - 50, centerY - 240, 100, 40);  // Поля шляпы
            graphics.FillEllipse(grayBrush, centerX - 45, centerY - 235, 90, 30);    // Тень на полях

            // Шарф (красный с черной окантовкой)
            graphics.FillRectangle(redBrush, centerX - 30, centerY - 70, 60, 20);    // Основная часть шарфа
            graphics.DrawRectangle(blackPen, centerX - 30, centerY - 70, 60, 20);    // Окантовка
            graphics.DrawLine(blackPen, centerX - 30, centerY - 50, centerX - 50, centerY - 30); // Хвостик шарфа слева
            graphics.DrawLine(blackPen, centerX + 30, centerY - 50, centerX + 50, centerY - 30); // Хвостик шарфа справа
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < snowflakeCount; i++)
            {
                int x = snowflakes[i].X;
                int y = snowflakes[i].Y + random.Next(1, 4); // Снег падает вниз
                if (y > pictureBox1.Height) // Если снежинка упала ниже, вернуть наверх
                {
                    y = 0;
                    x = random.Next(0, pictureBox1.Width);
                }
                snowflakes[i] = new Point(x, y);
            }
            pictureBox1.Invalidate();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Сглаживание для плавных линий

            // Рисуем снеговика
            DrawSnowman(g);

            // Рисуем снежинки
            Brush snowBrush = new SolidBrush(Color.White);
            foreach (Point snowflake in snowflakes)
            {
                g.FillEllipse(snowBrush, snowflake.X, snowflake.Y, 5, 5); // Маленькие белые круги
            }
        }
    }
}