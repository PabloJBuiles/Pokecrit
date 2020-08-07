namespace Pokecrit
{
    abstract class Skill
    {
        internal afinity afinity;
        internal string nombre;
        internal int uses;

  

        internal enum esSkill { AtkUp, DefUp, SpdDwn, Atck };

        public virtual void UseSkill() {
            uses++;
        }

    }

}
