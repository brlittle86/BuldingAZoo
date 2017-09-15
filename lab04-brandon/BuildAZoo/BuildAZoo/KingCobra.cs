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
            Console.WriteLine($"{Name} is generally diurnal.");
        }

        public void IntimidatingHood()
        {
            Console.WriteLine($"{Name}'s hood is meant to make them look bigger and scarier to predators.");
        }

        public void IsVenomous()
        {
            Console.WriteLine($"{Name} has a potent venom they inject into prey via needle-like fangs.");
        }

        public void IsFast()
        {
            Console.WriteLine($"Despite having no legs, {Name} can achieve speeds above 12mph.");
        }
    }
}
