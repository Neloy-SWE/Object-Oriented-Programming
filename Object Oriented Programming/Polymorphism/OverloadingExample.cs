using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Polymorphism
{
    // compile-time polymorphism (overloading)
    // parameter must need to change to perform overloading
    internal class OverloadingExample
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition of {a} + {b} = {a + b}");
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine($"Addition of {a} + {b} + {c} = {a + b + c}");
        }
    }
}
