using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Homework
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox pictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run() 
        {
            Point pos = pictureBox.Location;
            if (pos.X >= RacetrackLength - 80)
                return true;
            pos.X += Randomizer.Next(5);
            pictureBox.Location = pos;
            pictureBox.Update();
            return false;
        }
        public int TakeStartingPosition()
        {
            return 0;
        }
    }
}
