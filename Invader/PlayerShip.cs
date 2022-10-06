using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime;
using System.Resources;
namespace Invader
{
    class PlayerShip
    {
        private const int horizontalInterval = 10;
        public Point Location { get; private set; }

        public Bitmap image = new Bitmap(Image.FromFile("player.png"));

        private bool alive;

        private Rectangle winSize;

        public PlayerShip(Rectangle winsize,Point pos)
        {
            this.winSize = winsize;
            this.Location = pos;
            alive = true;

        }
        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, image.Size);
            }
        }

        public void Move(Direction direction)
        {
            if (direction == Direction.Left)
            {
                Point pos = new Point((Location.X - horizontalInterval), Location.Y);
                if ((pos.X < (winSize.Width - 100)) && (pos.X > 50))
                    Location = pos;
            }
            else if (direction == Direction.Right)
            {
                Point pos = new Point((Location.X + horizontalInterval), Location.Y);
                if ((pos.X < (winSize.Width - 100)) && (pos.X > 50))
                    Location = pos;
            }
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(image, Location);
        }

    }
}
