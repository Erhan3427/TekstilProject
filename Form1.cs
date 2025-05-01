using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private Snake snake;
        private Food food;
        private Timer gameTimer;
        private int score;
        private bool isGameOver;
        private const int GridSize = 20;
        private const int GameSpeed = 100;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Form ayarları
            this.Text = "Yılan Oyunu";
            this.ClientSize = new Size(800, 600);
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            // Oyun nesnelerini oluştur
            snake = new Snake(10, 10);
            food = new Food();
            score = 0;
            isGameOver = false;

            // Timer ayarları
            gameTimer = new Timer();
            gameTimer.Interval = GameSpeed;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            // Yem pozisyonunu ayarla
            food.GenerateNewPosition(ClientSize.Width / GridSize, ClientSize.Height / GridSize);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!isGameOver)
            {
                // Yılanı hareket ettir
                snake.Move();

                // Çarpışma kontrolü
                if (CheckCollision())
                {
                    isGameOver = true;
                    gameTimer.Stop();
                    MessageBox.Show($"Oyun Bitti! Skorunuz: {score}", "Yılan Oyunu");
                    return;
                }

                // Yem yeme kontrolü
                if (snake.Body[0].X == food.Position.X && snake.Body[0].Y == food.Position.Y)
                {
                    snake.Grow();
                    food.GenerateNewPosition(ClientSize.Width / GridSize, ClientSize.Height / GridSize);
                    score += 10;
                }

                // Ekranı yenile
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Arka planı temizle
            g.Clear(Color.White);

            // Yılanı çiz
            foreach (var point in snake.Body)
            {
                g.FillRectangle(Brushes.Green, 
                    point.X * GridSize, 
                    point.Y * GridSize, 
                    GridSize - 1, 
                    GridSize - 1);
            }

            // Yemi çiz
            g.FillEllipse(Brushes.Red,
                food.Position.X * GridSize,
                food.Position.Y * GridSize,
                GridSize - 1,
                GridSize - 1);

            // Skoru göster
            g.DrawString($"Skor: {score}", 
                new Font("Arial", 16), 
                Brushes.Black, 
                10, 10);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (!isGameOver)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        if (snake.CurrentDirection != Direction.Down)
                            snake.CurrentDirection = Direction.Up;
                        break;
                    case Keys.Down:
                        if (snake.CurrentDirection != Direction.Up)
                            snake.CurrentDirection = Direction.Down;
                        break;
                    case Keys.Left:
                        if (snake.CurrentDirection != Direction.Right)
                            snake.CurrentDirection = Direction.Left;
                        break;
                    case Keys.Right:
                        if (snake.CurrentDirection != Direction.Left)
                            snake.CurrentDirection = Direction.Right;
                        break;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                // Yeni oyun başlat
                InitializeGame();
            }
        }

        private bool CheckCollision()
        {
            // Duvarlara çarpma kontrolü
            if (snake.Body[0].X < 0 || 
                snake.Body[0].X >= ClientSize.Width / GridSize ||
                snake.Body[0].Y < 0 || 
                snake.Body[0].Y >= ClientSize.Height / GridSize)
            {
                return true;
            }

            // Kendine çarpma kontrolü
            return snake.CheckSelfCollision();
        }
    }
} 