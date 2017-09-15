using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Otter : Mammal
    {
        public Otter(string name)
        {
            Name = name;
        }

        public override void SleepHours()
        {
            Console.WriteLine($"{Name} tends to be nocturnal, but may be diurnal from time to time.");
        }

        public void IsAmphibious()
        {
            Console.WriteLine("Otters spend most of their lives in water, but are more than capable of living on land.");
        }

        public void IsIntelligent()
        {
            Console.WriteLine($"{Name} displays high level puzzle solving intelligence and communication skills.");
        }

        public void FloatAndSleep()
        {
            Console.WriteLine("Otters often sleep while floating on their backs in the water.");
        }

        public override void IsAdorable()
        {
            Console.WriteLine("Super adorable babies, adorable adults.");
        }
    }
}
