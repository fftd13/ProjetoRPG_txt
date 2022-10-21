using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Services
{
    interface IMagicAttack
    {
        public double MagicalAttack(double baseDamage, double magicalDamage);
    }
}
