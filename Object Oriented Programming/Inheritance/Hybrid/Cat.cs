using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Inheritance.Hybrid
{
    internal class Cat : Animal
    {
        public void SetDetails(string breed, int age)
        {
            this.breed = breed;
            this.age = age;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Breed: " + this.breed);
            Console.WriteLine("Age: " + this.age + " Year");
        }
    }
}
