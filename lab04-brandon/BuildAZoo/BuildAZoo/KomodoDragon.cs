using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class KomodoDragon : Reptile
    {
        public KomodoDragon(string name)
        {
            Name = name;
        }

        public override void SleepHours()
        {
            Console.WriteLine("Komodo Dragons are mostly diurnal.");
        }

        public void VenomIsSaliva()
        {
            Console.WriteLine("Komodo Dragon saliva is highly venomous and full of bacteria.");
        }

        public void LargeReptile()
        {
            Console.WriteLine("Komodo Dragons often exceed 10 feet in length.");
        }

        public void RemoteHome()
        {
            Console.WriteLine("The Komodo Dragon comes from a small set of islands in the southeast Pacific Ocean.");
        }
    }
}
