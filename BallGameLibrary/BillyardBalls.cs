namespace BallGameLibrary
{
    public class BillyardBalls:MoveBall
    {
        public event EventHandler<HitEventArgs> Hit;
        public BillyardBalls(PictureBox field):base(field)
        {

        }
        protected override void ChangeLocation()
        {
            base.ChangeLocation();
            if(centerX <= LeftSide())
            {
                vx = -vx;
                Hit.Invoke(this,new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vx = -vx;
                Hit.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                vy = -vy;
                Hit.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                vy = -vy;
                Hit.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
