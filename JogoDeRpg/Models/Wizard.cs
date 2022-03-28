using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeRpg.Models
{
    public class Wizard : Hero
    {
        public Wizard()
        {

        }
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }
        public override string Ataque()
        {
            return this.Name + "Lançou mágia!!";
        }
        public virtual string Ataque(int Bonus)
        {
            return this.Name + "Lançou magía com bonus de ataque de" + Bonus;
        }

    }
}
