using BallGameLibrary;

namespace SalutModelWinFormsApp
{
    public partial class MainForm : Form
    {
        static readonly Random random = new Random();
        List<AloneSalutBall> balls = new List<AloneSalutBall>();
        public MainForm()
        {
            InitializeComponent();
            FireWorks();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void fieldPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            var ballCount = random.Next(4, 10);
            Salut(ballCount, e.X, e.Y);
        }
        private void FireWorks()
        {
            var ballCount = random.Next(3, 6);
            for (int i = 0; i < ballCount; i++)
            {
                var ball = new AloneSalutBall(fieldPictureBox);
                balls.Add(ball);
                ball.Start();
            }
            timer1.Start();
        }


        private void Salut(int count, float x, float y)
        {
            for (int i = 0; i < count; i++)
            {
                var salut = new SalutBall(fieldPictureBox, x, y);
                salut.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                if (ball.CheckCenter())
                {
                    ball.Stop();
                    ball.Clear();
                    Salut(random.Next(3, 6), ball.centerX, ball.centerY);
                    timer1.Stop();
                }
            }
            FireWorks();
        }
    }
}