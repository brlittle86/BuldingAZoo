using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class PrayingMantis : Insect
    {
        public override void SleepHours()
        {
            Console.WriteLine("The Praying Mantis is primarily diurnal.");
        }

        public void DeadlyFemale()
        {
            Console.WriteLine("The female Praying Mantis kills and eats her mate after mating.");
        }

        public void FastAttack()
        {
            Console.WriteLine("The Praying Mantis attacks very quickly and has inspired martial arts.");
        }

        public void LooksReligious()
        {
            Console.WriteLine("It gets its name from how it appears to be praying due to the position of its forelimbs.");
        }
    }
}
