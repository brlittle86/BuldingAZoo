using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class Chameleon : Reptile
    {
        public Chameleon(string name)
        {
            Name = name;
        }

        public override void SleepHours()
        {
            Console.WriteLine($"{Name} is generally diurnal.");
        }

        public void EatsInsects()
        {
            Console.WriteLine($"{Name} eats small insects by catching them with their fast, whip-like, sticky tongue.");
        }

        public void StealthyReptile()
        {
            Console.WriteLine($"{Name} is able to change its skin color at will to provide extra stealth.");
        }

        public void TwoThumbs()
        {
            Console.WriteLine("The Chameleon has two opposing toes on each foot, so it's kind of like having two thumbs and three fingers.");
        }
    }
}
