using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Inheritance.Single
{
    internal class Employee
    {
        public int id;
        public string name;
        public int positionId;

        public Employee(int id, string name, int positionId)
        {
            this.id = id;
            this.name = name;
            this.positionId = positionId;
        }

        public void GetDetails()
        {
            Console.WriteLine("Call this method to get details");
        }

        public void CheckResponsibilities()
        {
            Console.WriteLine("Call this method to check responsibilities");
        }
    }
}
