using System;
using System.Collections.Generic;
using System.Text;

namespace Pokecrit
{
    class Player
    {
        // para que en algun momento el jugador pueda tener mas de 3 criaturas
        int maxCritters = 3;
        public List<Critter> crittersOwned = new List<Critter>();

        public Player(List<Critter> crittersOwned)
        {
            this.crittersOwned = crittersOwned;
        }

        public void LoseCreatures( Critter critterLose)
        {
            crittersOwned.Remove(critterLose);
        }

        public void AddCreatures(Critter critterAdd)
        {
            if (crittersOwned.Count < maxCritters)
            {
                crittersOwned.Add(critterAdd);
            }
        }

        public void Attack(Critter critter, Critter enemyCritter, int skill)
        {
            if (crittersOwned.Count != 0 && critter != null && enemyCritter != null && critter.Moveset1.Count >= skill && critter.Moveset1[skill] is AtackSkill)
            {
                critter.Atack(enemyCritter, critter.Moveset1[skill] as AtackSkill);
            }else
            {
                //no puede atacar
            }

        }

       public void Buff(Critter critter, int skill)
        {
            if (crittersOwned.Count != 0 && critter != null && critter.Moveset1.Count >= skill && critter.Moveset1[skill] is SuppSkill)
            {

                critter.Buff(critter.Moveset1[skill] as SuppSkill);
            }
            else
            {
                //no puede atacar
            }
        }

    }
}
