using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Polymorphism.OverrideExampleClasses
{
    internal class Motorcycle : Vehicle
    {
        public new void DisplayDetails()
        {
            Console.WriteLine("This is a motorcycle.");
        }
    }
}
