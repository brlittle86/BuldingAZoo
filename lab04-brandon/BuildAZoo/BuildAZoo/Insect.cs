using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Insect : Animal
    {
        public abstract void LegCount();

        public void HasCompoundEyes()
        {
            Console.WriteLine("This animal has compound eyes.");
        }

        public void HasManyLegs()
        {
            Console.WriteLine("This animal has more than four legs!");
        }

        public void BeenAround()
        {
            Console.WriteLine("This animal type has been around for hundreds of millions of years.");
        }
    }
}
