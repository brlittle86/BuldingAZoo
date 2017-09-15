using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Mammal : Animal
    {
        public void HasFur()
        {
            Console.WriteLine("This animal has fur!");
        }

        public void LiveBirth()
        {
            Console.WriteLine("This animal gives live birth.");
        }

        public void HasBinocularVision()
        {
            Console.WriteLine("This animal has binocular vision");
        }
    }
}
