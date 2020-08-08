using System;
using System.Collections.Generic;
using System.Text;

namespace Pokecrit
{
    class SuppSkill: Skill
    {
        esSkill sSkill;
        public SuppSkill(string nombre, esSkill sSkill)
        {            
            base.afinity = afinity.Dark;
            base.nombre = nombre;
            this.sSkill = sSkill;
        }

        public void UseSkill(Critter mCritter, double AtkUpB, double DefUpB, double SpdDwnB)
        {
            if (uses <= 3)
            {
                
                switch (sSkill)
                {
                    case esSkill.AtkUp:
                        mCritter.DmgActual = AtkUpB + AtkUpB * 0.2;
                        break;
                    case esSkill.DefUp:
                        mCritter.DefActual = DefUpB + DefUpB * 0.2;
                        break;
                    case esSkill.SpdDwn:
                        mCritter.SpeedActual = SpdDwnB + SpdDwnB * 0.3;
                        break;
                    default:
                        break;
                }
              
                base.UseSkill();
            }
        }
    }
}
