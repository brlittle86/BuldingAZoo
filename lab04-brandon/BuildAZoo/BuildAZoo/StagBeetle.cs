﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    class StagBeetle : Insect
    {
        public StagBeetle(string name)
        {
            Name = name;
        }

        public override void SleepHours()
        {
            Console.WriteLine("Stag Beetles are generally diurnal.");
        }

        public void HasHorns()
        {
            Console.WriteLine("The Stag Beetle is distinguished by its signature horns.");
        }

        public void BlackColor()
        {
            Console.WriteLine("The Stag Beetle generally looks black, but actually ranges from dark purples to bold blues.");
        }

        public void GreatForParties()
        {
            Console.WriteLine("No Stag party is complete without Stag Beetles.");
        }

        public override void LegCount()
        {
            Console.WriteLine("The Stag Beetle has 6 legs.");
        }
    }
}
