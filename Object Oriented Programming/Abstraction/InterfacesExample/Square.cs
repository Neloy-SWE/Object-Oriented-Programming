using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Abstraction.InterfacesExample
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square");
            Console.WriteLine("\n");
        }
    }
}
