using BallGameLibrary;

namespace AngryBirdsWinFormsApp
{
    
    public class Bird:MoveBall
    {
        private float g = 0.2f;
        private float elasitic = 0.4f;

        public Bird(PictureBox field):base(field) 
        {
            centerX = LeftSide();
            centerY = DownSide();
            ballColor = Brushes.Red;
            radius = 40;
        }
        protected override void ChangeLocation()
        {
            base.ChangeLocation();
            if(centerY > DownSide())
            {
                vy = -vy * elasitic;
                centerY = DownSide();
                vx = vx * elasitic;
            }

            if(vy < 0.1 && vx < 0.1)
            {
                Stop();
            }

            vy += g;
        }

        public void SetVelocity(int x,int y)
        {
            vx = (x - centerX) / 25;
            vy = (y - centerY) / 25;
        }

        public bool IsOutSide()
        {
            return centerX > RightSide();
        }

    }
}
