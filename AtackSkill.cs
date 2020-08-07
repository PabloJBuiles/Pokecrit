using System;
using System.Collections.Generic;
using System.Text;

namespace Pokecrit
{
    class AtackSkill : Skill
    {
        double skillPower;

        public AtackSkill(double skillPower, afinity afinity, string nombre)
        {
            this.skillPower = skillPower;
            base.afinity = afinity;
            base.nombre = nombre;
        }

        public void UseSkill(Critter mCritter, Critter enemy, double dmgActual)
        {
            if (uses <= 3)
            {            
            double affinityDmg = Affinity.CalculateAffinity(mCritter.AfinityType, enemy.AfinityType);
            enemy.GetDmg((dmgActual + skillPower) * affinityDmg);
            base.UseSkill();
            }
        }
    }
}
