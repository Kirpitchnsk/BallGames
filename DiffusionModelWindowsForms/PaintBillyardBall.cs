using BallGameLibrary;

namespace DiffusionModelWindowsForms
{
    public class PaintBillyardBall : BillyardBalls
    {
        private PictureBox field;
        private SolidBrush solidBrush;
        public PaintBillyardBall(PictureBox field, SolidBrush color) : base(field)
        {
            ballColor = color;
            radius = 30;
            centerX = random.Next((int)LeftSide(), (int)RightSide());
            centerY = random.Next((int)TopSide(), (int)DownSide());
            this.field = field;
        }
        public bool LeftOfCenter()
        {
            return centerX + radius < field.Width / 2;
        }
        public bool RightOfCenter()
        {
            return centerX - radius > field.Width / 2;
        }
        public SolidBrush GetSolidBrush()
        {
            return solidBrush;
        }
    }
}
