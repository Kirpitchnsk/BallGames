using BallGameLibrary;

namespace SalutModelWinFormsApp
{
    internal class AloneSalutBall:MoveBall
    {
        private PictureBox pictureBox;
        public AloneSalutBall(PictureBox pictureBox) : base(pictureBox)
        {
            this.pictureBox = pictureBox;
            radius = 20;
            centerX = random.Next(5, pictureBox.ClientSize.Width-5);
            centerY = pictureBox.ClientSize.Height - random.Next(1,50);
            ballColor = new SolidBrush(Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255)));
            vy = -random.Next(2,6);
            vx = 0;
        }
        public bool CheckCenter() => centerY <= pictureBox.Height / 2;

        protected override void ChangeLocation()
        {
            base.ChangeLocation();
        }
    }
}
