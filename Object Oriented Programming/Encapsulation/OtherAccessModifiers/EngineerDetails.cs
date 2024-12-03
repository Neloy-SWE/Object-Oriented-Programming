using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Encapsulation.OtherAccessModifiers
{
    internal class EngineerDetails
    {
        EmployeeDetails employeeDetails = new();
        public void SetEngineerDetails(string updateCompanyName, string role, string name)
        {
            // access check: internal, protected internal, public
            employeeDetails.companyName = updateCompanyName;
            employeeDetails.role = role;
            employeeDetails.Name = name;
            //employee.department // not accessible without extend
            //employee.salary // not accessible without extend
        }

        public void DisplayEngineerDetails()
        {
            Console.WriteLine("Engineer name: " + employeeDetails.Name);
            Console.WriteLine("Engineer role: " + employeeDetails.role);
            Console.WriteLine("Updated company name: " + employeeDetails.companyName);
            Console.WriteLine("\n\n");
        }
    }
}
