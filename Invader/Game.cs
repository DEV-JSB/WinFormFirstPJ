using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace Invader
{
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
    class Game
    {
        private int score = 0;
        private int livesLeft = 2;
        private int wave = 0;
        private int framesSkipped = 0;

        private Rectangle boundaries;
        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;

        private PlayerShip playerShip;
        private List<Shot> playerShots;
        private List<Shot> invaderShots;

        private Stars stars;

        public Game(Random random, Rectangle formArea)
        {
            this.boundaries = formArea;
            this.random = random;
            stars = new Stars();

            playerShip = new PlayerShip(formArea, new Point((formArea.Width / 2), (formArea.Height - 50)));
            playerShots = new List<Shot>();
            invaderShots = new List<Shot>();
            invaders = new List<Invader>();

        }
        private void NextWave()
        {
        }

    }
}
