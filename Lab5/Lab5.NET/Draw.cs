using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.NET
{
    internal class Draw
    {
        public Draw() { }

        public void DrawCircle(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float diameter = 100;
            float x = (panel.Width - diameter) / 2;
            float y = (panel.Height - diameter) / 2;
            g.FillEllipse(Brushes.LightBlue, x, y, diameter, diameter);
            g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
        }

        public void DrawTriangle(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            float size = 100;
            float xCenter = panel.Width / 2;
            float yCenter = panel.Height / 2;
            PointF[] points = new PointF[3]
            {
                new PointF(xCenter, yCenter - size / 2),       // Вершина
                new PointF(xCenter - size / 2, yCenter + size / 2),  // Левая нижняя
                new PointF(xCenter + size / 2, yCenter + size / 2)   // Правая нижняя
            };
            g.FillPolygon(Brushes.LightGreen, points);
            g.DrawPolygon(Pens.Black, points);
        }

        public void DrawSquare(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            float side = 100;
            float x = (panel.Width - side) / 2;
            float y = (panel.Height - side) / 2;
            g.FillRectangle(Brushes.LightYellow, x, y, side, side);
            g.DrawRectangle(Pens.Black, x, y, side, side);
        }

        public void DrawRectangle(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            float width = 150;
            float height = 100;
            float x = (panel.Width - width) / 2;
            float y = (panel.Height - height) / 2;
            g.FillRectangle(Brushes.LightCoral, x, y, width, height);
            g.DrawRectangle(Pens.Black, x, y, width, height);
        }

        public void DrawParallelogram(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            float baseLength = 100;
            float height = 100;
            float shift = 50;
            float xCenter = (panel.Width - baseLength - shift) / 2;
            float yCenter = (panel.Height - height) / 2;
            PointF[] points = new PointF[4]
            {
                new PointF(xCenter, yCenter + height),
                new PointF(xCenter + baseLength, yCenter + height),
                new PointF(xCenter + baseLength + shift, yCenter),
                new PointF(xCenter + shift, yCenter)
            };
            g.FillPolygon(Brushes.LightPink, points);
            g.DrawPolygon(Pens.Black, points);
        }

        public void DrawBall(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float diameter = 120;
            float x = (panel.Width - diameter) / 2;
            float y = (panel.Height - diameter) / 2;
            g.FillEllipse(Brushes.LightSteelBlue, x, y, diameter, diameter);
            g.DrawEllipse(Pens.Black, x, y, diameter, diameter);
        }

        public void DrawPyramid(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            float baseSize = 100;
            float height = 100;
            float xCenter = panel.Width / 2;
            float yCenter = panel.Height / 2;
            PointF[] basePoints = new PointF[4]
            {
                new PointF(xCenter - baseSize / 2, yCenter + baseSize / 2),
                new PointF(xCenter + baseSize / 2, yCenter + baseSize / 2),
                new PointF(xCenter + baseSize / 2, yCenter),
                new PointF(xCenter - baseSize / 2, yCenter)
            };
            PointF apex = new PointF(xCenter, yCenter - height / 2);

            g.FillPolygon(Brushes.LightGoldenrodYellow, basePoints);
            g.DrawPolygon(Pens.Black, basePoints);
            g.DrawLine(Pens.Black, apex, basePoints[0]);
            g.DrawLine(Pens.Black, apex, basePoints[1]);
            g.DrawLine(Pens.Black, apex, basePoints[2]);
            g.DrawLine(Pens.Black, apex, basePoints[3]);
        }

        public void DrawCube(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            float side = 100;
            float offset = 50;
            float xCenter = (panel.Width - side - offset) / 2;
            float yCenter = (panel.Height - side - offset) / 2;
            PointF[] frontFace = new PointF[4]
            {
                new PointF(xCenter, yCenter + side),
                new PointF(xCenter + side, yCenter + side),
                new PointF(xCenter + side, yCenter),
                new PointF(xCenter, yCenter)
            };
            PointF[] backFace = new PointF[4]
            {
                new PointF(xCenter + offset, yCenter + side + offset),
                new PointF(xCenter + side + offset, yCenter + side + offset),
                new PointF(xCenter + side + offset, yCenter + offset),
                new PointF(xCenter + offset, yCenter + offset)
            };

            g.FillPolygon(Brushes.LightGray, frontFace);
            g.FillPolygon(Brushes.DarkGray, backFace);
            g.DrawPolygon(Pens.Black, frontFace);
            g.DrawPolygon(Pens.Black, backFace);
            g.DrawLine(Pens.Black, frontFace[0], backFace[0]);
            g.DrawLine(Pens.Black, frontFace[1], backFace[1]);
            g.DrawLine(Pens.Black, frontFace[2], backFace[2]);
            g.DrawLine(Pens.Black, frontFace[3], backFace[3]);
        }

        public void DrawParallelepiped(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            float width = 150;
            float height = 100;
            float depth = 50;
            float xCenter = (panel.Width - width - depth) / 2;
            float yCenter = (panel.Height - height - depth) / 2;
            PointF[] frontFace = new PointF[4]
            {
                new PointF(xCenter, yCenter + height),
                new PointF(xCenter + width, yCenter + height),
                new PointF(xCenter + width, yCenter),
                new PointF(xCenter, yCenter)
            };
            PointF[] backFace = new PointF[4]
            {
                new PointF(xCenter + depth, yCenter + height + depth),
                new PointF(xCenter + width + depth, yCenter + height + depth),
                new PointF(xCenter + width + depth, yCenter + depth),
                new PointF(xCenter + depth, yCenter + depth)
            };

            g.FillPolygon(Brushes.LightSalmon, frontFace);
            g.FillPolygon(Brushes.Salmon, backFace);
            g.DrawPolygon(Pens.Black, frontFace);
            g.DrawPolygon(Pens.Black, backFace);
            g.DrawLine(Pens.Black, frontFace[0], backFace[0]);
            g.DrawLine(Pens.Black, frontFace[1], backFace[1]);
            g.DrawLine(Pens.Black, frontFace[2], backFace[2]);
            g.DrawLine(Pens.Black, frontFace[3], backFace[3]);
        }

        public void DrawPrism(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(Color.White);
            float baseSize = 100;
            float height = 50;
            float xCenter = panel.Width / 2;
            float yCenter = panel.Height / 2;
            PointF[] baseBottom = new PointF[3]
            {
                new PointF(xCenter - baseSize / 2, yCenter + baseSize / 2),
                new PointF(xCenter + baseSize / 2, yCenter + baseSize / 2),
                new PointF(xCenter, yCenter)
            };
            PointF[] baseTop = new PointF[3]
            {
                new PointF(xCenter - baseSize / 2, yCenter),
                new PointF(xCenter + baseSize / 2, yCenter),
                new PointF(xCenter, yCenter - height)
            };

            g.FillPolygon(Brushes.LightSeaGreen, baseBottom);
            g.FillPolygon(Brushes.SeaGreen, baseTop);
            g.DrawPolygon(Pens.Black, baseBottom);
            g.DrawPolygon(Pens.Black, baseTop);
            g.DrawLine(Pens.Black, baseBottom[0], baseTop[0]);
            g.DrawLine(Pens.Black, baseBottom[1], baseTop[1]);
            g.DrawLine(Pens.Black, baseBottom[2], baseTop[2]);
        }
    }
}
