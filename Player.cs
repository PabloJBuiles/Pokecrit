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

        void Attack()
        {

        }

    }
}
