using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Inheritance.MultiLevel.Derived
{
    internal class Level2 : Level1
    {
        public new void CheckResponsibilities()
        {
            //base.CheckResponsibilities();
            Console.WriteLine("Responsibilities:\n");
            Console.WriteLine("Review code");
            Console.WriteLine("Report to manager");
            Console.WriteLine("\n\n");
        }

        public void ExtraResponsibilities()
        {
            Console.WriteLine("Extra responsibilities:\n");
            Console.WriteLine("Bug fix");
            Console.WriteLine("\n\n");
        }
    }
}
