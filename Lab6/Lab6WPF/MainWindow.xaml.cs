using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Lab6WPF
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer? snowTimer, ballTimer;
        private Random random = new Random();
        private Ellipse? ball;
        private double ballX = 0; // Текущая позиция X мяча
        private double ballY = 0; // Текущая позиция Y мяча
        private double xSpeed = 1500; // Горизонтальная скорость (пикселей в секунду)
        private double ySpeed = 1200; // Вертикальная скорость для зигзагообразного движения
        private bool isSnowmanActive = false, isBallActive = false;
        private int trailCounter = 0; // Счетчик для контроля частоты трейла
        Color Sapphire = Color.FromRgb(15, 82, 186);  // A deep blue shade
        Color Emerald = Color.FromRgb(80, 200, 120);  // A vibrant green shade
        Color Ruby = Color.FromRgb(224, 17, 95);      // A rich red shade

        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки снеговика
        private void SnowmanButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isSnowmanActive)
            {
                ClearCanvas();
                StopBallAnimation();

                // Ожидание обновления размеров холста перед рисованием
                Dispatcher.InvokeAsync(() =>
                {
                    DrawSnowman();
                    StartSnowfall();
                });

                isSnowmanActive = true;
            }
            else
            {
                StopSnowfall();
                isSnowmanActive = false;
            }
        }

        // Рисует снеговика на холсте
        private void DrawSnowman()
        {
            if (canvas.ActualWidth == 0 || canvas.ActualHeight == 0) return;

            // Устанавливаем голубой фон
            canvas.Background = new SolidColorBrush(Colors.LightBlue);

            double centerX = canvas.ActualWidth / 2;
            double baseMargin = 40;
            double baseBottomY = canvas.ActualHeight - baseMargin;

            // Размеры частей снеговика
            double bottomDiameter = 120; // Нижний круг
            double middleDiameter = 90;  // Средний круг
            double headDiameter = 60;    // Голова

            // Нижняя часть снеговика
            Ellipse bottom = new Ellipse
            {
                Width = bottomDiameter,
                Height = bottomDiameter,
                Fill = Brushes.White,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(bottom, centerX - bottomDiameter / 2);
            Canvas.SetTop(bottom, baseBottomY - bottomDiameter);
            canvas.Children.Add(bottom);

            // Средняя часть снеговика
            Ellipse middle = new Ellipse
            {
                Width = middleDiameter,
                Height = middleDiameter,
                Fill = Brushes.White,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(middle, centerX - middleDiameter / 2);
            Canvas.SetTop(middle, baseBottomY - bottomDiameter - middleDiameter + 15);
            canvas.Children.Add(middle);

            // Голова снеговика
            Ellipse head = new Ellipse
            {
                Width = headDiameter,
                Height = headDiameter,
                Fill = Brushes.White,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(head, centerX - headDiameter / 2);
            Canvas.SetTop(head, baseBottomY - bottomDiameter - middleDiameter - headDiameter + 30);
            canvas.Children.Add(head);

            double headTop = baseBottomY - bottomDiameter - middleDiameter - headDiameter + 30;

            // Глаза
            double eyeDiameter = 6;
            Ellipse leftEye = new Ellipse { Width = eyeDiameter, Height = eyeDiameter, Fill = Brushes.Black };
            Ellipse rightEye = new Ellipse { Width = eyeDiameter, Height = eyeDiameter, Fill = Brushes.Black };
            Canvas.SetLeft(leftEye, centerX - 12);
            Canvas.SetTop(leftEye, headTop + headDiameter * 0.35);
            Canvas.SetLeft(rightEye, centerX + 6);
            Canvas.SetTop(rightEye, headTop + headDiameter * 0.35);
            canvas.Children.Add(leftEye);
            canvas.Children.Add(rightEye);

            // Нос (оранжевый треугольник)
            Polygon nose = new Polygon
            {
                Points = new PointCollection { new Point(0, 0), new Point(15, 5), new Point(0, 10) },
                Fill = Brushes.Orange
            };
            Canvas.SetLeft(nose, centerX - 2);
            Canvas.SetTop(nose, headTop + headDiameter * 0.45);
            canvas.Children.Add(nose);

            // Рот (точки)
            double mouthY = headTop + headDiameter * 0.65;
            for (int i = -2; i <= 2; i++)
            {
                Ellipse mouthDot = new Ellipse { Width = 4, Height = 4, Fill = Brushes.Black };
                Canvas.SetLeft(mouthDot, centerX + i * 8 - 2);
                Canvas.SetTop(mouthDot, mouthY);
                canvas.Children.Add(mouthDot);
            }

            // Руки
            Line leftArm = new Line
            {
                Stroke = Brushes.Black,
                StrokeThickness = 3,
                X1 = centerX - middleDiameter / 2,
                Y1 = baseBottomY - bottomDiameter - middleDiameter / 2 + 15,
                X2 = centerX - middleDiameter / 2 - 40,
                Y2 = baseBottomY - bottomDiameter - middleDiameter / 2 + 15 - 20
            };
            Line rightArm = new Line
            {
                Stroke = Brushes.Black,
                StrokeThickness = 3,
                X1 = centerX + middleDiameter / 2,
                Y1 = baseBottomY - bottomDiameter - middleDiameter / 2 + 15,
                X2 = centerX + middleDiameter / 2 + 40,
                Y2 = baseBottomY - bottomDiameter - middleDiameter / 2 + 15 - 20
            };
            canvas.Children.Add(leftArm);
            canvas.Children.Add(rightArm);
        }

        // Запускает анимацию снегопада
        private void StartSnowfall()
        {
            snowTimer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(50) };
            snowTimer.Tick += (s, e) => AddSnowflake();
            snowTimer.Start();
        }

        // Останавливает анимацию снегопада
        private void StopSnowfall()
        {
            snowTimer?.Stop();
        }

        // Добавляет одну снежинку на холст
        private void AddSnowflake()
        {
            Ellipse snowflake = new Ellipse { Width = 5, Height = 5, Fill = Brushes.White };
            double x = random.NextDouble() * canvas.ActualWidth;
            Canvas.SetLeft(snowflake, x);
            Canvas.SetTop(snowflake, 0);
            canvas.Children.Add(snowflake);

            // Анимация падения снежинки
            var animation = new DoubleAnimation
            {
                To = canvas.ActualHeight,
                Duration = TimeSpan.FromSeconds(random.NextDouble() * 2 + 1)
            };
            animation.Completed += (s, e) => canvas.Children.Remove(snowflake);
            snowflake.BeginAnimation(Canvas.TopProperty, animation);
        }

        // Обработчик нажатия кнопки мяча
        private void BallButton_Click(object sender, RoutedEventArgs e)
        {
            canvas.Background = Brushes.White;

            if (!isBallActive)
            {
                ClearCanvas();
                StopSnowfall();
                CreateBall();
                StartBallAnimation();
                isBallActive = true;
            }
            else
            {
                StopBallAnimation();
                isBallActive = false;
            }
        }

        // Создает мяч с градиентом и тенью
        private void CreateBall()
        {
            ball = new Ellipse { Width = 20, Height = 20 };
            ball.Fill = new RadialGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Red, 0),
                    new GradientStop(Colors.DarkRed, 1)
                }
            };
            ball.Effect = new DropShadowEffect
            {
                Color = Colors.Black,
                Direction = 315,
                ShadowDepth = 5,
                Opacity = 0.5
            };
            ballX = 0;
            ballY = canvas.ActualHeight / 2;
            Canvas.SetLeft(ball, ballX);
            Canvas.SetTop(ball, ballY);
            canvas.Children.Add(ball);
        }

        // Запускает анимацию движения мяча
        private void StartBallAnimation()
        {
            ballTimer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(16) }; // ~60 FPS
            ballTimer.Tick += (s, e) => MoveBall();
            ballTimer.Start();
        }

        // Останавливает анимацию движения мяча
        private void StopBallAnimation()
        {
            ballTimer?.Stop();
            ball = null;
        }

        // Обновляет позицию мяча и обрабатывает отскоки
        private void MoveBall()
        {
            if (ball == null) return;

            double deltaTime = 0.016; // 16 мс на кадр

            // Обновление позиции
            ballX += xSpeed * deltaTime;
            ballY += ySpeed * deltaTime;

            // Отскок от верхнего и нижнего края
            if (ballY <= 0 || ballY >= canvas.ActualHeight - ball.Height)
            {
                ySpeed = -ySpeed;
                ballY = Math.Max(0, Math.Min(ballY, canvas.ActualHeight - ball.Height));
            }

            // Переход с правого края на левый
            if (ballX >= canvas.ActualWidth)
            {
                ballX = -ball.Width;
            }

            // Обновляем реальную позицию мяча на холсте
            Canvas.SetLeft(ball, ballX);
            Canvas.SetTop(ball, ballY);

            // Добавление эффекта следа с интервалом
            trailCounter++;
            if (trailCounter % 3 == 0) // Каждые ~48 мс
            {
                AddTrail();
            }
        }

        // Добавляет эффект следа за мячом, привязанный к текущей позиции мяча
        private void AddTrail()
        {
            if (ball == null) return;

            // Получаем текущую позицию мяча с холста (точнее, чем ballX и ballY)
            double currentX = Canvas.GetLeft(ball);
            double currentY = Canvas.GetTop(ball);

            Ellipse trail = new Ellipse { Width = 10, Height = 10 };
            trail.Fill = new LinearGradientBrush
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(1, 1),
                GradientStops = new GradientStopCollection
        {
            new GradientStop(Colors.Red, 0),
            new GradientStop(Colors.Transparent, 1)
        }
            };
            trail.Opacity = 0.7;
            Canvas.SetLeft(trail, currentX);
            Canvas.SetTop(trail, currentY);
            canvas.Children.Add(trail);

            // Анимация исчезновения следа
            var fade = new DoubleAnimation
            {
                To = 0,
                Duration = TimeSpan.FromMilliseconds(2000)
            };
            fade.Completed += (s, e) => canvas.Children.Remove(trail);
            trail.BeginAnimation(UIElement.OpacityProperty, fade);
        }

        // Обработчик нажатия кнопки "Points"
        private void PointsButton_Click(object sender, RoutedEventArgs e)
        {
            PointsWindow pointsWindow = new PointsWindow();
            pointsWindow.Show();
        }

        // Очищает все элементы с холста
        private void ClearCanvas()
        {
            canvas.Children.Clear();
        }
    }
}