using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Inheritance.MultiLevel.Derived
{
    internal class Level1 : Level
    {
        public new void CheckResponsibilities()
        {
            base.CheckResponsibilities();
            Console.WriteLine("Responsibilities:\n");
            Console.WriteLine("Develop software");
            Console.WriteLine("Report to level 2");
            Console.WriteLine("\n\n");
        }
    }
}
