using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Second
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location)
            : base(game, location)
        { }
        public override string Name { get { return "Mace"; } }
        public override void Attack(Direction dircetion, Random random)
        {
            if (!DamageEnemy(Direction.Left, 7, 7, random))
            {
                if (!DamageEnemy(Direction.Down, 7, 7, random))
                {
                    if (!DamageEnemy(Direction.Up, 7, 7, random))
                    {
                        DamageEnemy(Direction.Down, 7, 7, random);
                    }
                }
            }
        }
    }
}
