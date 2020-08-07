using System;
using System.Collections.Generic;
using System.Text;

namespace Pokecrit
{
    class Critter
    {
        private Player owner;
        private double hpBase, hpActual;
        private double dmgBase, dmgActual;
        private double speedBase, speedActual;
        private double defBase, defActual;
        private string critName = "";
        private afinity afinityType;
        public Critter target;
        private List<Skill> Skills = new List<Skill>();



        public Critter(Player owner, double hpBase, double dmgBase, double speedBase, double defBase, string critName, afinity afinityType)
        {
            this.owner = owner;
            //Verificar el daño entr 10 y 100
            if (dmgBase > 100)
            {
                this.DmgBase = 100;
            }else if (dmgBase < 10)
            {
                this.DmgBase = 10;
            }else
            {
                this.DmgBase = dmgBase;
            }
            //verificar defensa entre 10 y 100
            if (defBase > 100)
            {
                this.defBase = 100;
            }
            else if (defBase < 10)
            {
                this.defBase = 10;
            }
            else
            {
                this.defBase = defBase;
            }
            //verificar si la velocidad 1 y 50
            if (speedBase > 50)
            {
                this.speedBase = 50;
            }
            else if (speedBase < 1)
            {
                this.speedBase = 1;
            }
            else
            {
                this.speedBase = speedBase;
            }



          
            this.hpBase = hpBase;
            this.critName = critName;
            this.afinityType = afinityType;

            hpActual = this.hpBase;
            dmgActual = this.dmgBase;
            defActual = this.defBase;



        }

        public afinity AfinityType { get => afinityType;}
        public double SpeedActual { get => speedActual; set => speedActual = value; }
        public double DmgActual { set => dmgActual = value; }
        public double DefActual { set => defActual = value; }
        public double DmgBase {set => dmgBase = value; }

        public void GetDmg(double dmg)
        {
            hpActual -= dmg;
            if (hpActual <= 0)
            {
                owner.LoseCreatures(this);
            }
        }

        

    }
}
