using JogoDeRpg.Models;
using System;

namespace JogoDeRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero heroy = new Hero("Arus", 25 , "Knight");
            Wizard oponente  = new Wizard("Maléficos", 30 , "Devil");
           

            Console.WriteLine(heroy.Ataque());
            Console.WriteLine(oponente.Ataque(50));
        }
    }
}
