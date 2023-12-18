using BallGameLibrary;
namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int ballsCount;
        private List<Ball> balls;
        public MainForm()
        {
            InitializeComponent();
            initialiseBalls();
        }
        private void initialiseBalls()
        {
            stopButton.Enabled = true;
            stopButton.Visible = true;
            createButton.Enabled = false;
            ballsCount = 10;
            balls = new List<Ball>();
            for (int i = 0; i < ballsCount; i++)
            {
                var moveBall = new RandomMoveBall(fieldPictureBox);
                balls.Add(moveBall);
            }
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            foreach (MoveBall moveBall in balls)
            {
                moveBall.Start();
            }
            createButton.Enabled = false;
            createButton.Visible = false;
            stopButton.Enabled = true;
            stopButton.Visible = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            var counter = 0;
            foreach (var moveBall in balls)
            {
                moveBall.Stop();
                if (moveBall.OnForm()) counter++;
            }
            MessageBox.Show("Шаров на форме " + counter.ToString());
            stopButton.Enabled = false;
            stopButton.Visible = false;
            clearButton.Enabled = true;
            clearButton.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            createButton.Enabled = true;
            createButton.Visible = true;
            stopButton.Enabled = false;
            stopButton.Visible = false;
            clearButton.Visible = false;
            clearButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var moveBall in balls)
            {
                moveBall.Clear();
            }
            clearButton.Visible = false;
            clearButton.Enabled = false;
            createButton.Enabled = true;
            createButton.Visible = true;
        }
    }
}