using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace Invader
{
   

    public struct Star
    {
        public Point point;
        public Brush brush;

        public Star(Point _point , Brush _brush)
        {
            this.point = _point;
            this.brush = _brush;
        }
    }

    class Stars
    {
        private List<Star> stars;
        private Rectangle formArea;
        
        private void AddStar(Random random)
        {
            int height = formArea.Height;
            int width = formArea.Width;
            Point pos = new Point(random.Next(0, width), random.Next(0, height));
            stars.Add(new Star(pos, Brushes.Yellow));
        }

        public void Draw(Graphics g)
        {
            foreach(Star star in stars)
            {
                g.FillRectangle(star.brush, star.point.X, star.point.Y, 1, 1);
            }
        }

        public void Twinkle(Random random)
        {
            stars.RemoveRange(0, 4);
            for (int i = 0; i < 4; ++i)
                AddStar(random);
        }
    }
}
