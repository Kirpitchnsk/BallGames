using Timer = System.Windows.Forms.Timer;

namespace FruitNinjaWinFormsApp
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();
        private Timer timer = new Timer();
        private List<FruitBall> fruitBalls;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fruitBalls = new List<FruitBall>();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            for (int i = 0; i < random.Next(4, 10); i++)
            {
                var ballNumber = random.Next(6);
                FruitBall ball;
                if (ballNumber == 0) ball = new BananaBall(fieldPictureBox);
                else if (ballNumber == 4) ball = new BombBall(fieldPictureBox);
                else ball = new FruitBall(fieldPictureBox);

                fruitBalls.Add(ball);

                ball.Start();
            }

            timer.Interval = random.Next(2000, 5000);
        }
        private void EndGame()
        {
            timer.Stop();
            foreach (var fruit in fruitBalls) fruit.Stop();
            MessageBox.Show("Игра окончена!!!");
        }
        private void MakeBallsSlower()
        {
            foreach (var fruit in fruitBalls)
            {
                fruit.MakeBallSlower();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruitBall in fruitBalls)
            {
                if (fruitBall.IsMovable() && fruitBall.Contains(e.X, e.Y))
                {
                    fruitBall.Stop();

                    if (fruitBall is BombBall)
                    {
                        EndGame();
                        return;
                    }
                    if (fruitBall is BananaBall)
                    {
                        MakeBallsSlower();
                    }

                    fruitBall.Clear();
                    scoreLabel.Text = (int.Parse(scoreLabel.Text) + 1).ToString();
                }
            }
        }
    }
}