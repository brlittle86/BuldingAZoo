using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class KingCobra : Reptile
    {
        public KingCobra(string name)
        {
            Name = name;
        }

        public override void SleepHours()
        {
            Console.WriteLine("King Cobra are generally diurnal.");
        }

        public void IntimidatingHood()
        {
            Console.WriteLine("The King Cobra's hood is meant to make it look bigger and scarier to predators.");
        }

        public void IsVenomous()
        {
            Console.WriteLine("The King Cobra has a potent venom it injects into prey via needle-like fangs.");
        }

        public void IsFast()
        {
            Console.WriteLine("Despite having no legs, the King Cobra can achieve speeds above 12mph.");
        }
    }
}
