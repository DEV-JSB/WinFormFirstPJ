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
        public void FireShot()
        {
                Shot newShot = new Shot(new Point((playerShip.Location.X + (playerShip.image.Width / 2))
                                        , playerShip.Location.Y)
                                        , Direction.Up, boundaries);
                playerShots.Add(newShot);
        }
        public void MovePlayer(Direction direction, bool gameOver)
        {
            if (!gameOver)
            {
                playerShip.Move(direction);
            }
        }

        public void Go()
        {
                List<Shot> deadPlayerShots = new List<Shot>();
                foreach (Shot shot in playerShots)
                {
                    if (!shot.Move())
                        deadPlayerShots.Add(shot);
                }
                foreach (Shot shot in deadPlayerShots)
                    playerShots.Remove(shot);

                List<Shot> deadInvaderShots = new List<Shot>();
                foreach (Shot shot in invaderShots)
                {
                    if (!shot.Move())
                        deadInvaderShots.Add(shot);
                }
                foreach (Shot shot in deadInvaderShots)
                    invaderShots.Remove(shot);

                moveInvaders();
                returnFire();
                checkForCollisions();
            }

        private void checkForCollisions()
        {
            // Created seperate lists of dead shots since items can't be
            // removed from a list while enumerating through it
            List<Shot> deadPlayerShots = new List<Shot>();
            List<Shot> deadInvaderShots = new List<Shot>();

            foreach (Shot shot in invaderShots)
            {
                if (playerShip.Area.Contains(shot.Location))
                {
                    deadInvaderShots.Add(shot);
                    livesLeft--;
                    // worth checking for gameOver state here too?
                }
            }

            foreach (Shot shot in playerShots)
            {
                List<Invader> deadInvaders = new List<Invader>();
                foreach (Invader invader in invaders)
                {
                    if (invader.Area.Contains(shot.Location))
                    {
                        deadInvaders.Add(invader);
                        // Score multiplier based on wave
                        score = score + (1 * wave);
                    }
                }
                foreach (Invader invader in deadInvaders)
                    invaders.Remove(invader);
            }
            foreach (Shot shot in deadPlayerShots)
                playerShots.Remove(shot);
            foreach (Shot shot in deadInvaderShots)
                invaderShots.Remove(shot);
        }
        private void moveInvaders()
        {
                if (invaderDirection == Direction.Right)
                {
                    if (invaders.Count > 0)
                    {
                        invaderDirection = Direction.Left;
                        foreach (Invader invader in invaders)
                            invader.Move(Direction.Down);
                    }
                    else
                    {
                        foreach (Invader invader in invaders)
                            invader.Move(Direction.Right);
                    }
                }

                if (invaderDirection == Direction.Left)
                {
                    if (invaders.Count > 0)
                    {
                        invaderDirection = Direction.Right;
                        foreach (Invader invader in invaders)
                            invader.Move(Direction.Down);
                    }
                    else
                    {
                        foreach (Invader invader in invaders)
                            invader.Move(Direction.Left);
                    }
                }

                foreach (Invader invader in invaders)
                {
                    invader.Move(invaderDirection);
                }
            }
        private void returnFire()
        {
            /*foreach (var invaderColumn in invaderColumns)
            {
                var invaderRow =
                    from invader in invaderColumn
                    orderby invader.Location.Y descending
                    select invader;
                Invader shooter = invaderRow.First();
                Point newShotLocation = new Point(shooter.Location.X + (shooter.Area.Width / 2),
                shooter.Location.Y + shooter.Area.Height);
                Shot newShot = new Shot(newShotLocation, Direction.Down,
                    formArea);
                if (invaderShots.Count < (wave + 1))
                {
                    invaderShots.Add(newShot);
                }
            }*/
        }
    }


}
