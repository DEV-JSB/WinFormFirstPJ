using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Invader
{
    class Shot
    {
        private const int moveInterval = 20;
        private const int width = 5;
        private const int height = 15;

        public Point Location { get; private set; }

        private Direction direction;
        private Rectangle boundaries;

        public Shot(Point location,Direction direction,
            Rectangle boundaries)
        {
            this.Location = location;
            this.direction = direction;
            this.boundaries = boundaries;
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Red,
                Location.X, Location.Y, width, height);
        }

        public bool Move()
        {
            Point pos;
            if (direction == Direction.Down)
            {
                pos = new Point(Location.X, (Location.Y + moveInterval));
            }
            else //if (direction == Direction.Up)
            {
                pos = new Point(Location.X, (Location.Y - moveInterval));
            }
            if ((pos.Y < boundaries.Height) && (pos.Y > 0))
            {
                Location = pos;
                return true;
            }
            else
                return false;
        }
    }
}
