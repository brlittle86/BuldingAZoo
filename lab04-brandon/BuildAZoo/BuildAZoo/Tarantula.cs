using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Tarantula : Insect
    {
        public Tarantula(string name)
        {
            Name = name;
        }

        public override void SleepHours()
        {
            Console.WriteLine($"{Name} tends to be diurnal.");
        }

        public void Arachnid()
        {
            Console.WriteLine($"{Name} has 8 eyes and spins a web.");
        }

        public void AmbushHunter()
        {
            Console.WriteLine($"{Name} is an ambush hunter.");
        }

        public void LiquidDiet()
        {
            Console.WriteLine($"Like all spiders, {Name} liquefies the insides of its prey and drinks it.");
        }

        public override void LegCount()
        {
            Console.WriteLine($"{Name} has 8 legs.");
        }
    }
}
