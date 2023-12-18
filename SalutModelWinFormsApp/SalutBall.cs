using BallGameLibrary;
using System.Windows.Forms;
namespace SalutModelWinFormsApp
{
    public class SalutBall:MoveBall
    {
        private float g = 0.65f;
        public SalutBall(PictureBox pictureBox,float centerX,float centerY):base(pictureBox)
        {
            radius = 20;
            this.centerX = centerX;
            this.centerY = centerY;
            ballColor = new SolidBrush(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
            vy = -Math.Abs(vy);
        }
        protected override void ChangeLocation()
        {
            base.ChangeLocation();
            vy += g;
        }
    }
}
