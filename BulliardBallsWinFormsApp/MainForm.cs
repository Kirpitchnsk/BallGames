using BallGameLibrary;
namespace BulliardBallsWinFormsApp
{
    public partial class MainForm : Form
    {
        private int countBalls = 10;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < countBalls; i++)
            {
                var ball = new BillyardBalls(fieldPictureBox);
                ball.Hit += Ball_Hit;
                ball.Start();
            }
        }

        private void Ball_Hit(object? sender, HitEventArgs e)
        {
            switch(e.Side)
            {
                case Side.Left:
                    leftLabel.Text = (int.Parse(leftLabel.Text) + 1).ToString();
                    break; 
                case Side.Right:
                    rightLabel.Text = (int.Parse(rightLabel.Text) + 1).ToString();
                    break; 
                case Side.Top:
                    topLabel.Text = (int.Parse(topLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel.Text = (int.Parse(downLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}