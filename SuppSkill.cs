using System;
using System.Collections.Generic;
using System.Text;

namespace Pokecrit
{
    class SuppSkill: Skill
    {
        public SuppSkill(string nombre)
        {            
            base.afinity = afinity.Dark;
            base.nombre = nombre;
        }

        public void UseSkill(Critter mCritter, double @base, Enum sSkill)
        {
            if (uses <= 3)
            {
                
                switch (sSkill)
                {
                    case esSkill.AtkUp:
                        mCritter.DmgActual = @base + @base * 0.2;
                        break;
                    case esSkill.DefUp:
                        mCritter.DefActual = @base + @base * 0.2;
                        break;
                    case esSkill.SpdDwn:
                        mCritter.SpeedActual = @base + @base * 0.3;
                        break;
                    default:
                        break;
                }
              
                base.UseSkill();
            }
        }
    }
}
