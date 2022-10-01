using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace Invader
{
    public enum ShipType
    {
        Bug, Saucer, Satellite, SpcaeShip, Star,
    }
    class Invader
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;

        private Bitmap image;

        public Point Location { get; private set; }
        public ShipType InvaderType { get; private set; }

        public Rectangle Area { get { return new Rectangle(Location, image.Size); } }

        public int Score{get; private set;}

        public Invader(ShipType invaderType, Point location ,int score)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;

            // 이미지 생성 후 넣기 
            image = InvaderImage(invaderType);
        }
        
        public void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.Left:
                    Location = new Point((Location.X + HorizontalInterval), Location.Y);
                    break;
                case Direction.Right:
                    Location = new Point((Location.X - HorizontalInterval), Location.Y);
                    break;
                case Direction.Down:
                    Location = new Point(Location.X, (Location.Y + VerticalInterval));
                    break;
                case Direction.Up:
                    break;
            }
        }
        public void Draw(Graphics g , int animationCell)
        {
            g.DrawImage(image, Location);
        }

        private Bitmap InvaderImage(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.Bug:
                    return new Bitmap("bug.png");
                case ShipType.Satellite:
                    return new Bitmap("satellite.png");
                case ShipType.Saucer:
                    return new Bitmap("flyingsaucer.png");
                case ShipType.SpcaeShip:
                    return new Bitmap("spaceship.png");
                case ShipType.Star:
                    return new Bitmap("star.png");
            }
            return null;
        }

    }
}
