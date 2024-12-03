using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Encapsulation.OtherAccessModifiers
{
    internal class ManagerDetails : EmployeeDetails
    {
        public void SetManagerDetails(string department, decimal salaryAmount, string roleName)
        {
            // access check: protected, protected internal, private protected
            this.department = department;
            this.role = roleName;
            this.salary = salaryAmount;
            //this.employeeId = "M101"; // private member is not accessible
        }

        public void DisplayManagerDetails()
        {
            Console.WriteLine($"Manager Department: {department}");
            Console.WriteLine($"Manager Role: {role}");
            Console.WriteLine("\n\n");
        }
    }
}
