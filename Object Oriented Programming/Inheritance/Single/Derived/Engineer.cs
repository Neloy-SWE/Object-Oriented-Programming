using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Inheritance.Single.Derived
{
    internal class Engineer : Employee
    {
        private int level;
        public Engineer(int id, string name, int positionId, int level) : base(id, name, positionId)
        {
            this.level = level;
        }

        public new void GetDetails()
        {
            Console.WriteLine("Employee details:\n");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Position: Engineer level-{level}");
            Console.WriteLine($"Employee ID: {positionId}{id}");
            Console.WriteLine("\n");
        }

        public new void CheckResponsibilities()
        {
            Console.WriteLine("Responsibilities:\n");
            if (level == 1)
            {
                Console.WriteLine("Develop software");
                Console.WriteLine("Report to level 2");
            }
            else if (level == 2)
            {
                Console.WriteLine("Review code");
                Console.WriteLine("Report to manager");
            }
            Console.WriteLine("\n\n");
        }
    }
}
