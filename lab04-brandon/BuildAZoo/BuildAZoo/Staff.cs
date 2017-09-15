using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Staff
    {
        public abstract string Name { get; set; }
        public string Gender { get; set; }

        public void IsFriendly()
        {
            Console.WriteLine("They better be!");
        }

        public void CanDrive()
        {
            Console.WriteLine($"{Name} can drive!");
        }

        public void WorkingHours()
        {
            Console.WriteLine($"{Name} works from 9am to 5pm.");
        }
    }
}
