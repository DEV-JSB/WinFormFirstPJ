using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Second
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        {

        }
        public override void Move(Random random, Rectangle boundaries)
        {
            Point newLocation = location;
            int direction = random.Next(0, 4);
            switch (direction)
            {
                case 0:
                    if (newLocation.Y - 10 >= boundaries.Top)
                        newLocation.Y -= 10;
                    break;
                case 1:
                    if (newLocation.Y + 10 <= boundaries.Bottom)
                        newLocation.Y += 10;
                    break;
                case 2:
                    if (newLocation.X - 10 >= boundaries.Left)
                        newLocation.X -= 10;
                    break;
                case 3:
                    if (newLocation.X + 10 <= boundaries.Right)
                        newLocation.X += 10;
                    break;
                default:
                    break;
            }
            location = newLocation;
        }
    }
}
