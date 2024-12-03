using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Encapsulation.OtherAccessModifiers
{
    internal class Employee
    {
        private string employeeId;
        protected string department;
        internal string companyName = "TechCorp";
        public string Name { get; set; }
        protected internal string role;
        private protected decimal salary;

        public void SetEmployeeDetails(string id, string department, decimal salaryAmount, string roleName)
        {
            this.employeeId = id; // private
            this.department = department; // protected
            this.salary = salaryAmount; // private protected
            this.role = roleName; // protected internal
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {employeeId}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Role: {role}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Company: {companyName}");
            Console.WriteLine($"Name: {Name}");
        }
    }
}
