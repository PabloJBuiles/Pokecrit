using System;
using System.Collections.Generic;

namespace Pokecrit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AtackSkill ataqueRapido = new AtackSkill(15, afinity.Fire, "ataqueRapido Rapido");
            AtackSkill latigoZeta = new AtackSkill(25, afinity.Wind, "Aatigo Zeta");
            AtackSkill aguaToxica = new AtackSkill(35, afinity.Water, "Agua Toxica");
            AtackSkill venenoAcido = new AtackSkill(0, afinity.Earth, "ataqueRapido Rapido"); //pues se crea con poder 1 porque tiene poder 0 :D
            //AtkUp, DefUp, SpdDwn
            SuppSkill atkUp = new SuppSkill("Incremento de ataque MAXIMO!!!", Skill.esSkill.AtkUp);
            SuppSkill defUp = new SuppSkill("Super Endurecimiento", Skill.esSkill.DefUp);
            SuppSkill spdUp = new SuppSkill("Suvida de velocidad", Skill.esSkill.SpdDwn);// directamente imposibles de crear con poder > 0

            List<Skill> setSkill1 = new List<Skill>();
            List<Skill> setSkill2 = new List<Skill>();

            setSkill1.Add(ataqueRapido);
            setSkill1.Add(defUp);
            setSkill1.Add(aguaToxica);
            setSkill2.Add(aguaToxica);//0
            setSkill2.Add(atkUp);//1
            setSkill2.Add(spdUp);//2


            Critter Trex = new Critter(50, 50, 50, 50, "Trex", afinity.Earth, setSkill2);
            Critter SuperUnicorn = new Critter(50, 50, 50, 50, "Super Unicorn", afinity.Fire, setSkill1);
            Critter LechuzaLegendaria = new Critter(50, 50, 50, 50, "Lechuza Legendaria", afinity.Water, setSkill2);


            Critter TotoroSanguinario = new Critter(50, 50, 50, 50, "Totoro Sanguinario", afinity.Water, setSkill2);
            Critter OrcaPacifista = new Critter(50, 50, 50, 50, "Orca Pacifista", afinity.Water, setSkill2);
            Critter TortugaProductiva = new Critter(50, 50, 50, 50, "Tortuga Productiva", afinity.Water, setSkill2);



            List<Critter> critters1 = new List<Critter>();
            List<Critter> critters2 = new List<Critter>();

            critters1.Add(Trex);
            critters1.Add(SuperUnicorn);
            critters1.Add(LechuzaLegendaria);


            critters2.Add(LechuzaLegendaria);
            critters2.Add(Trex);
            critters2.Add(SuperUnicorn);


            Player Jugador = new Player(critters1);
            Player Enemigo = new Player(critters2);


            Trex.owner = Jugador;
            SuperUnicorn.owner = Jugador;
            LechuzaLegendaria.owner = Jugador;

            TotoroSanguinario.owner = Enemigo;
            OrcaPacifista.owner = Enemigo;
            TortugaProductiva.owner = Enemigo;

            //turno 1

            Jugador.Buff(Trex, 2);
            Enemigo.Buff(OrcaPacifista, 2);

            //turno 2
            Jugador.Buff(Trex, 2);
            Enemigo.Buff(OrcaPacifista, 2);
            //turno 3
            Jugador.Buff(Trex, 2);
            Enemigo.Buff(OrcaPacifista, 2);
            //turno 4
            Jugador.Buff(Trex, 2);
            Enemigo.Buff(OrcaPacifista, 2);


            //no tan F soy muy malo trabajando a presion :v aiuda


        }
    }
}
