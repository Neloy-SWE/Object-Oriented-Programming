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
        public string position;
        public int positionId;

        public Employee(int id, string name, string position, int positionId)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.positionId = positionId;
        }

        public void GetDetails()
        {
            Console.WriteLine("Call this method to get details");
        }

        public void CheckResponsibilies()
        {
            Console.WriteLine("Call this method to check responsibilities");
        }
    }
}
