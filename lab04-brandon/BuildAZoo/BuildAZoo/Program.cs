using System;

namespace BuildAZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger akasha = new Tiger("Akasha");
            akasha.DoesWalk();
            akasha.HasFur();
            akasha.IsABigCat();

            Chameleon steve = new Chameleon("Steve");
            steve.DoesWalk();
            steve.HasATail();
            steve.EatsInsects();

            PrayingMantis miyuki = new PrayingMantis("Miyuki");
            miyuki.DoesBreath();
            miyuki.HasCompoundEyes();
            miyuki.DeadlyFemale();
        }
    }
}
