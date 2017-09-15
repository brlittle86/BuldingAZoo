using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Otter : Mammal
    {
        public override void SleepHours()
        {
            Console.WriteLine("Otters tend to be nocturnal, but may be diurnal.");
        }

        public void IsAmphibious()
        {
            Console.WriteLine("Otters spend most of their lives in water, but are more than capable of living on land.");
        }

        public void IsIntelligent()
        {
            Console.WriteLine("Otters display high level puzzle solving intelligence and communication skills.");
        }

        public void FloatAndSleep()
        {
            Console.WriteLine("Otters often sleep while floating on their backs in the water.");
        }
    }
}
