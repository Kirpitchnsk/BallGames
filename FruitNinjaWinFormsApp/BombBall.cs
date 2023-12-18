using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitNinjaWinFormsApp
{
    public class BombBall:FruitBall
    {
        public BombBall(PictureBox pictureBox):base(pictureBox) 
        { 
            ballColor = Brushes.Black;
        }
    }
}
