namespace BallGameLibrary
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(PictureBox field) : base(field)
        {
            radius = random.Next(30, 70);
        }
    }
}
