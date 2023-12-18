using BallGameLibrary;
using Timer = System.Windows.Forms.Timer;

namespace DiffusionModelWindowsForms
{
    public partial class MainForm : Form
    {
        private Timer timer = new Timer();
        int ballsCount = 20;
        List<PaintBillyardBall> billyardBalls = new List<PaintBillyardBall>();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ShowLineCenter();
            int countLeftBlueBalls = 0;
            int countLeftRedBalls = 0;

            int countRightBlueBalls = 0;
            int countRightRedBalls = 0;
            foreach (var ball in billyardBalls)
            {
                if (ball.LeftOfCenter() && ball.GetSolidBrush() == Brushes.Red) countLeftRedBalls++;
                else if (ball.LeftOfCenter() && ball.GetSolidBrush() == Brushes.Blue) countLeftBlueBalls++;
                else if (ball.RightOfCenter() && ball.GetSolidBrush() == Brushes.Red) countRightRedBalls++;
                else if (ball.RightOfCenter() && ball.GetSolidBrush() == Brushes.Blue) countRightBlueBalls++;
            }
         
            if (countLeftRedBalls == countLeftBlueBalls && countRightBlueBalls == 
                    countRightRedBalls && countLeftBlueBalls+countLeftRedBalls+
                    countRightRedBalls+countRightBlueBalls == ballsCount)
            {
                foreach (var ball in billyardBalls)
                {
                    ball.Stop();
                }
                    timer.Stop();
            }
        }

        private void Ball_Hit1(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel_1.Text = (int.Parse(leftLabel_1.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel_1.Text = (int.Parse(rightLabel_1.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel_1.Text = (int.Parse(topLabel_1.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel_1.Text = (int.Parse(downLabel_1.Text) + 1).ToString();
                    break;
            }
        }
        private void Ball_Hit2(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel_2.Text = (int.Parse(leftLabel_2.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel_2.Text = (int.Parse(rightLabel_2.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel_2.Text = (int.Parse(topLabel_2.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel_2.Text = (int.Parse(downLabel_2.Text) + 1).ToString();
                    break;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < ballsCount/2; i++)
            {
                var ball = new PaintBillyardBall(fieldPictureBox, new SolidBrush(Color.Blue));
                ball.Hit += Ball_Hit1;
                ball.Start();
                billyardBalls.Add(ball);

                ball = new PaintBillyardBall(fieldPictureBox, new SolidBrush(Color.Red));
                ball.Hit += Ball_Hit2;
                ball.Start();
                billyardBalls.Add(ball);
            }
        }

        private void ShowLineCenter()
        {
            var graphics = fieldPictureBox.CreateGraphics();
            graphics.DrawLine(Pens.Tomato,fieldPictureBox.Width/2,0, fieldPictureBox.Width /2, fieldPictureBox.Height);
        }
    }
}