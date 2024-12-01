using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Inheritance.Single.Derived
{
    internal class Stuff : Employee
    {
        public Stuff(int id, string name, int positionId) : base(id, name, positionId) { }

        public new void GetDetails()
        {
            Console.WriteLine("Employee details:\n");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Position: Stuff");
            Console.WriteLine($"Employee ID: {positionId}{id}");
            Console.WriteLine("\n");
        }

        public new void CheckResponsibilities()
        {
            Console.WriteLine("Responsibilities:\n");
            Console.WriteLine("Provide support to maintain working environment");
            Console.WriteLine("\n\n");
        }
    }
}
