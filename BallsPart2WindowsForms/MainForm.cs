
using System.Windows.Forms;
using BallGameLibrary;

namespace BallsPart2WindowsForms
{
    public partial class MainForm : Form
    {
        private int numberOfBalls;
        private int countBalls;
        private List<RandomMoveBall> moveBalls;
        public MainForm()
        {
            InitializeComponent();
            moveBalls = new List<RandomMoveBall>();
            countBalls = 0;
            numberOfBalls = 10;
            createButton.Enabled = true;
            createButton.Visible = true;
            countBallsLabel.Text = countBalls.ToString();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createButton.Enabled = false;
            createButton.Visible = false;
            clearButton.Visible = true;
            clearButton.Enabled = true;
            for (int i = 0; i < numberOfBalls; i++)
            {
                var moveBall = new RandomMoveBall(gameField);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            createButton.Enabled = true;
            createButton.Visible = true;
            clearButton.Enabled = false;
            clearButton.Visible = false;
            foreach (var ball in moveBalls)
            {
                ball.Stop();
                ball.Clear();
            }
        }


        private void gameField_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                if (ball.IsMovable() && ball.Contains(e.X, e.Y))
                {
                    ball.Stop();
                    countBalls++;
                }
            }
            countBallsLabel.Text = countBalls.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
            clearButton.Visible = false;
        }
    }
}