using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Abstraction.InterfacesExample
{
    internal class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            Console.WriteLine("\n");
        }
    }
}
