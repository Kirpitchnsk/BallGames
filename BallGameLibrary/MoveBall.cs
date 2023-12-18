

namespace BallGameLibrary
{
    public class MoveBall:RandomPointBall
    {
        
        public MoveBall(PictureBox field):base(field)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }

        private int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            var sign = 1;
            if (randomDouble < 0.5) sign = -1;
            return random.Next(1,5)*sign;
        }
    }
}
