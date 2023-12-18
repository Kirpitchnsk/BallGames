using BallGameLibrary;

namespace AngryBirdsWinFormsApp
{
    public class Pig:MoveBall
    {
        public Pig(PictureBox field):base(field) 
        { 
            ballColor = Brushes.Green;
            radius = 70;
        }
    }
}
