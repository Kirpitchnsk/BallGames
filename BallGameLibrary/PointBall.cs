namespace BallGameLibrary
{
    public class PointBall:Ball
    {
        static Random random = new Random();
        public PointBall(PictureBox field,int x ,int y):base(field) 
        {
            this.centerX = x - radius / 2;
            this.centerY = y - radius / 2;
        }
    }
}
