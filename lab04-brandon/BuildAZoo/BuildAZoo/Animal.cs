using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public abstract void SleepHours();

    }
}
