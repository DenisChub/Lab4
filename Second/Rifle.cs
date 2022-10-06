using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class Rifle : Weapon
    {
        protected int chanceToHit = 100;
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
            return damage + 30;
        }

        public bool Hitting()
        {
            return random.Next(0, 101) <= chanceToHit ? true : false;
        }
    }
}