using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Lab6WPF
{
    public partial class PointsWindow : Window
    {
        private List<Point> points = new List<Point>();
        private Rectangle rectangle;

        public PointsWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point clickPoint = e.GetPosition(canvas);
            points.Add(clickPoint);
            DrawPoint(clickPoint.X, clickPoint.Y);
        }

        private void DrawPoint(double x, double y)
        {
            Ellipse point = new Ellipse { Width = 5, Height = 5, Fill = Brushes.Black };
            Canvas.SetLeft(point, x - 2.5);
            Canvas.SetTop(point, y - 2.5);
            canvas.Children.Add(point);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            points.Clear();
            rectangle = null;
        }

        private void DrawRectButton_Click(object sender, RoutedEventArgs e)
        {
            if (points.Count == 0) return;

            if (rectangle != null) canvas.Children.Remove(rectangle);

            double minX = points[0].X, maxX = points[0].X;
            double minY = points[0].Y, maxY = points[0].Y;

            foreach (var p in points)
            {
                minX = Math.Min(minX, p.X);
                maxX = Math.Max(maxX, p.X);
                minY = Math.Min(minY, p.Y);
                maxY = Math.Max(maxY, p.Y);
            }

            rectangle = new Rectangle
            {
                Width = maxX - minX,
                Height = maxY - minY,
                Stroke = Brushes.Red,
                StrokeThickness = 2
            };
            Canvas.SetLeft(rectangle, minX);
            Canvas.SetTop(rectangle, minY);
            canvas.Children.Add(rectangle);
        }
    }
}