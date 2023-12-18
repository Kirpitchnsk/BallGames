using Timer = System.Windows.Forms.Timer;

namespace AngryBirdsWinFormsApp
{
    public partial class MainForm : Form
    {
        Bird bird;
        Pig pig;
        Timer timer = new Timer();
        bool birdMoving = false;
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (bird.Intersect(pig))
            {
                scoreLabel.Text = (int.Parse(scoreLabel.Text) + 1).ToString();
                CreateNewBird();
                CreateNewPig();
            }
            if (!bird.IsMovable())
            {
                CreateNewBird();
            }
            if (bird.IsOutSide())
            {
                CreateNewBird();
            }
        }
        void CreateNewBird()
        {
            timer.Stop();
            if (bird != null)
            {
                bird.Stop();
                bird.Clear();
            }
            bird = new Bird(gameField);
            bird.Show();
            birdMoving = false;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            CreateNewBird();
            CreateNewPig();
            scoreLabel.Text = "0";
            gameField.TabIndex = 0;
        }

        private void CreateNewPig()
        {
            timer.Stop();
            if (pig != null)
            {
                pig.Stop();
                pig.Clear();
            }
            pig = new Pig(gameField);
            pig.Show();
        }

        private void gameField_MouseDown(object sender, MouseEventArgs e)
        {
            if (!birdMoving)
            {
                timer.Start();
                bird.SetVelocity(e.X, e.Y);
                bird.Start();
                birdMoving = true;
            }
        }
    }
}