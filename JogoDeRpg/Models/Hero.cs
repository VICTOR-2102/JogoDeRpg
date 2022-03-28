using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeRpg.Models
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero()
        {

        }

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

        public override string ToString()
        {
            return "Meu nome é " + this.Name + ", " + "sou do nível "+ this.Level + " e sou um " + this.HeroType;
        }

        public virtual string Ataque()
        {
            return this.Name + "Atacou com a sua espada";
        }
    }
}
