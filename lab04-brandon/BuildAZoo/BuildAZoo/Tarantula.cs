using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Tarantula : Insect
    {
        public override void SleepHours()
        {
            Console.WriteLine("Tarantulas tend to be diurnal.");
        }

        public void Arachnid()
        {
            Console.WriteLine("The Tarantula has 8 legs and spins a web.");
        }

        public void AmbushHunter()
        {
            Console.WriteLine("The Tarantual is an ambush hunter.");
        }
    }
}
