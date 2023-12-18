namespace BallGameLibrary
{
    public class RandomMoveBall : MoveBall
    {
        public RandomMoveBall(PictureBox field) : base(field)
        {
            ballColor = Brushes.IndianRed;
        }
    }
}
