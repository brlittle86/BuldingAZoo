using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class RedPanda : Mammal
    {
        public RedPanda(string name)
        {
            Name = name;
        }

        public override void SleepHours()
        {
            Console.WriteLine("The Red Panda is a daytime mammal, and generally sleeps at night.");
        }

        public void LivesInChina()
        {
            Console.WriteLine("The Red Panda comes from southwest China and Tibet.");
        }

        public void AtRisk()
        {
            Console.WriteLine("Due to having an adorable, warm, bushy tail, the Red Panda is at risk for becoming endangered.");
        }

        public void Chitter()
        {
            Console.WriteLine("The Red Panda makes a chittering call when communicating.");
        }

        public override void IsAdorable()
        {
            Console.WriteLine("Adorableness levels are at maximum.");
        }
    }
}
