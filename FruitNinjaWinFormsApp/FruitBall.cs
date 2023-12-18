using BallGameLibrary;
namespace FruitNinjaWinFormsApp
{
    public class FruitBall: RandomMoveBall
    {
        private float g = 0.2f;
        public FruitBall(PictureBox pictureBox):base(pictureBox)
        {
            ballColor = new SolidBrush(Color.FromArgb(random.Next(1, 256), random.Next(1, 256), random.Next(1, 256)));
            radius = 50;
            centerY = pictureBox.Height + radius;
            vy = (float)random.NextDouble() * -6 - 7;
        }
        protected override void ChangeLocation()
        {
            base.ChangeLocation();
            vy += g;

            if(centerY > DownSide()+2*radius)
            {
                Stop();
            }
        }
        public void MakeBallSlower()
        {
            vx = (float)random.NextDouble() * 5 -5;
            vy = (float)random.NextDouble() * 5 -5;
        }
    }
}
