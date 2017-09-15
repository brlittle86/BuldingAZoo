using System;

namespace BuildAZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's learn about Akasha the Tiger!");
            Tiger akasha = new Tiger("Akasha");
            akasha.DoesWalk();
            akasha.HasFur();
            akasha.IsABigCat();
            Console.WriteLine();

            Console.WriteLine("Now, let's talk about Steve the Chameleon!");
            Chameleon steve = new Chameleon("Steve");
            steve.DoesWalk();
            steve.HasATail();
            steve.EatsInsects();
            Console.WriteLine();

            Console.WriteLine("Last, but not least, let's meet Miyuki the Praying Mantis!");
            PrayingMantis miyuki = new PrayingMantis("Miyuki");
            miyuki.DoesBreath();
            miyuki.HasCompoundEyes();
            miyuki.DeadlyFemale();

            Console.Read();
        }
    }
}
