using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo
{
    abstract class Building
    {
        public string BuildingNumber { get; set; }
        public string Location { get; set; }

        public void HasFireEvacuationPlan()
        {
            Console.WriteLine("This building has a fire evacuation plan.");
        }

        public void HasStorageSpace()
        {
            Console.WriteLine("This building has storage space.");
        }

        public void HasStaff()
        {
            Console.WriteLine("This building has staff in it.");
        }
    }
}
