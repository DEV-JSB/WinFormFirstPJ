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

        private int invaderXSpacing = 50;
        private int invaderYSpacing = 50;

        private Direction invaderDirection;
        private List<Invader> invaders;

        private PlayerShip playerShip;
        private List<Shot> playerShoots;
        private List<Shot> invaderShots;

        private Stars stars;

        public Game(Random random, Rectangle formArea)
        {
            this.boundaries = formArea;
            this.random = random;
            stars = new Stars(random, formArea);

           


        playerShip = new PlayerShip(formArea, new Point((formArea.Width / 2), (formArea.Height - 50)));
            playerShoots = new List<Shot>();
            invaderShots = new List<Shot>();
            invaders = new List<Invader>();

            invaderDirection = Direction.Right;
            int currentInvaderYSpace = 0;
            for (int x = 0; x < 5; x++)
            {
                ShipType currentInvaderType = (ShipType)x;
                currentInvaderYSpace += invaderYSpacing;
                int currentInvaderXSpace = 0;
                for (int y = 0; y < 5; y++)
                {
                    currentInvaderXSpace += invaderXSpacing;
                    Point newInvaderPoint =
                        new Point(currentInvaderXSpace, currentInvaderYSpace);
                    // Need to add more varied invader score values
                    Invader newInvader =
                        new Invader(currentInvaderType, newInvaderPoint, 10);
                    invaders.Add(newInvader);
                }
            }
        }

        public void Draw(Graphics graphics, int frame, bool gameOver)
        {
            graphics.FillRectangle(Brushes.Black, boundaries);

            stars.Draw(graphics);
            foreach (Invader invader in invaders)
                invader.Draw(graphics, frame);
            playerShip.Draw(graphics);
            foreach (Shot shot in playerShoots)
                shot.Draw(graphics);
            foreach (Shot shot in invaderShots)
                shot.Draw(graphics);


        }
        public void FireShot()
        {
                Shot newShot = new Shot(new Point((playerShip.Location.X + (playerShip.image.Width / 2))
                                        , playerShip.Location.Y)
                                        , Direction.Up, boundaries);
                playerShoots.Add(newShot);
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
            while(true)
            {
                List<Shot> deadPlayerShots = new List<Shot>();
                foreach (Shot shot in playerShoots)
                {
                    if (!shot.Move())
                        deadPlayerShots.Add(shot);
                }
                foreach (Shot shot in deadPlayerShots)
                    playerShoots.Remove(shot);

                List<Shot> deadInvaderShots = new List<Shot>();
                foreach (Shot shot in invaderShots)
                {
                    if (!shot.Move())
                        deadInvaderShots.Add(shot);
                }
                foreach (Shot shot in deadInvaderShots)
                    invaderShots.Remove(shot);

                moveInvaders();
                checkForCollisions();
            }
        }

        private void checkForCollisions()
        {
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

            foreach (Shot shot in playerShoots)
            {
                List<Invader> deadInvaders = new List<Invader>();
                foreach (Invader invader in invaders)
                {
                    if (invader.Area.Contains(shot.Location))
                    {
                        deadInvaders.Add(invader);
                        score = score + (1 * wave);
                    }
                }
                foreach (Invader invader in deadInvaders)
                    invaders.Remove(invader);
            }
            foreach (Shot shot in deadPlayerShots)
                playerShoots.Remove(shot);
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
    }


}
