using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Tiger : Mammal
    {
        public Tiger(string name)
        {
            Name = name;
        }

        public override void SleepHours()
        {
            Console.WriteLine("Tigers are nocturnal ambush hunters.");
        }

        public void HasStripes()
        {
            Console.WriteLine("The tiger has stripes to aid in camoflage and hunting.");
        }

        public void IsABigCat()
        {
            Console.WriteLine("Like the lion, the tiger is a big cat - often weighing more than 500 pounds.");
        }

        public void SmallLitters()
        {
            Console.WriteLine("Tigers tend to have small litters of one to three kittens.");
        }

        public override void IsAdorable()
        {
            Console.WriteLine("Kittens are cute, adults are not.");
        }
    }
}
