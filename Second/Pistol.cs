using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class Pistol : Weapon
    {
        protected int chanceToHit = 65;
        Random random = new Random();

        public override int Damage()
        {
            if (Hitting())
            {
                return Shoot();
            }

            return 0;
        }

        public int Shoot()
        {
            return damage + 10;
        }

        public bool Hitting()
        {
            return random.Next(0, 101) <= chanceToHit ? true : false;
        }
    }
}