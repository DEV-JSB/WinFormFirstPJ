using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Second
{
    abstract class Weapon : Mover
    {


        private bool pickedUp;
        public bool PickedUp{ get { return pickedUp; } }

        public Weapon(Game game,Point location)
            :base(game,location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }

        public void PickUpWeapon() { pickedUp = true; }
        public abstract string Name { get; }
        public abstract void Attack(Direction dircetion, Random random);

        public bool Nearby(Point enemy, Point point, int radius)
        {
            // 몰 ? 루 
            return true;
        }

        public Point Move(Direction direction, Point point,Rectangle boundaries)
        {
            // 몰? 루
            return new Point();
        }

        protected bool DamageEnemy(Direction direction,int radius,int damage,Random random)
        {
            Point target = game.PlayerLocation;
            for(int distance = 0; distance < radius; ++distance)
            {
                foreach(Enemy enemy in game.Enemies)
                {
                    if(Nearby(enemy.Location,target,radius))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        
    }
}
