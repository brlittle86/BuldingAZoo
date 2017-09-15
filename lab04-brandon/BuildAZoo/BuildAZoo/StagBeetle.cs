using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class StagBeetle : Insect
    {
        public StagBeetle(string name)
        {
            Name = name;
        }

        public override void SleepHours()
        {
            Console.WriteLine($"{Name} is generally diurnal.");
        }

        public void HasHorns()
        {
            Console.WriteLine($"{Name} is distinguished by its signature horns.");
        }

        public void BlackColor()
        {
            Console.WriteLine("The Stag Beetle generally looks black, but actually ranges from dark purples to bold blues.");
        }

        public void GreatForParties()
        {
            Console.WriteLine($"No Stag party is complete without {Name}.");
        }

        public override void LegCount()
        {
            Console.WriteLine($"{Name} has 6 legs.");
        }
    }
}
