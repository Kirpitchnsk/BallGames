using Timer = System.Windows.Forms.Timer;

namespace BallGameLibrary
{
    public class Ball
    {
        private PictureBox field;

        protected Timer timer;

        public float centerX { get; protected set; } = 150;
        public float centerY { get; protected set; } = 150;

        protected float vx= 10;
        protected float vy = 10;
        protected float radius = 50;

        protected Brush ballColor = Brushes.IndianRed;
        protected Brush clearColor;
        public Ball(PictureBox field) 
        {
            this.field = field;

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;

            clearColor = new SolidBrush(field.BackColor);
        }

        public bool IsMovable() => timer.Enabled;

        public void Start() => timer.Start();

        public void Stop() => timer.Stop();
        private void Timer_Tick(object? sender, EventArgs e) => Move();
        public void Show()
        {
            Draw(ballColor);
        }
        public bool Contains(int pointX,int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;
            return dx*dx + dy*dy <= radius * radius;
        }
        public bool Intersect(Ball anotherBall)
        {
            var dx = centerX - anotherBall.centerX;
            var dy = centerY - anotherBall.centerY;
            return dx*dx + dy*dy <= Math.Pow(radius + anotherBall.radius,2);
        }
        protected virtual void ChangeLocation()
        {
            centerX += vx;
            centerY += vy;
        }
        public bool OnForm()=>centerX>= LeftSide() && centerY>=TopSide() && centerX<=RightSide() && centerY<=DownSide();
        public void Clear()
        {
            Draw(clearColor);
        }
        public float LeftSide() => radius;
        public float TopSide() => radius;
        public float DownSide() => field.Height - radius;
        public float RightSide() => field.Width - radius;
        public void Move()
        {
            Clear();
            ChangeLocation();
            Show();
        }
        private void Draw(Brush brush)
        {
            var graphics = field.CreateGraphics();
            var rectangle = new RectangleF(centerX, centerY, radius, radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
