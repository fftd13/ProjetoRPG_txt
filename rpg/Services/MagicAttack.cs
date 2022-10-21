using System;

namespace rpg.Services
{
    class MagicAttack : IMagicAttack
    {
        public double MagicalAttack(double baseDamage, double magicalDamage)
        {
            double half = magicalDamage / 2;
            double magicdmg = half * 3;
            return magicdmg + baseDamage;
        }

    }
}
