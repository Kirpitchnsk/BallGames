namespace BallGameLibrary
{
    public class RandomPointBall:Ball
    {
        protected static Random random = new Random();
        public RandomPointBall(PictureBox field):base(field)
        {
            centerX = random.Next((int)LeftSide(),(int)RightSide());
            centerY = random.Next((int)TopSide(),(int)DownSide());
        }
    }
}
