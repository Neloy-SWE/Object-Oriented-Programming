using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Object_Oriented_Programming.Inheritance.Single.Derived
{
    internal class Manager : Employee
    {
        public Manager(int id, string name, int positionId) : base(id, name, positionId) { }

        public new void GetDetails()
        {
            Console.WriteLine("Employee details:\n");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Position: Manager");
            Console.WriteLine($"Employee ID: {positionId}{id}");
            Console.WriteLine("\n");
        }

        public new void CheckResponsibilities()
        {
            Console.WriteLine("Responsibilities:\n");
            Console.WriteLine("Deliver project to client");
            Console.WriteLine("\n\n");
        }
    }
}
