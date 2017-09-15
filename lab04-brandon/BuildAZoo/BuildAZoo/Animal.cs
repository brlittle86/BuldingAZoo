using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public abstract void SleepHours();

        public void DoesWalk()
        {
            Console.WriteLine("This animal walks!");
        }

        public void DoesBreath()
        {
            Console.WriteLine("This animal breaths!");
        }

        public void DoesEat()
        {
            Console.WriteLine("This animal eats!");
        }
    }
}
