using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeRpg.Models
{
    public class Knight : Hero
    {
        public Knight()
        {

        }
        public Knight(string Name, int Level, string HeroType)
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
            if (Bonus > 6)
            {
                return this.Name + "Lançou uma magia super efetiva com " + Bonus;
            }
            else
            {
                return this.Name + "Lançou magía com força fraca com bonus de " + Bonus;
            }
        }
    }
}
