using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Reptile : Animal
    {
        public void IsScaley()
        {
            Console.WriteLine("This animal has scaley skin!");
        }

        public void LaysEggs()
        {
            Console.WriteLine("This animal lays eggs.");
        }

        public void HasATail()
        {
            Console.WriteLine("This animal has a tail!");
        }
    }
}
