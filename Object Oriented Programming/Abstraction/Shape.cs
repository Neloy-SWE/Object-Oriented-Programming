using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Abstraction
{
    /*
     * internal class Shape:
     * is not a abstract class.
     * so if class is not abstract, 
     * abstract method cannot be created
     */

    internal abstract class Shape
    {
        public abstract void Draw(); // asbstract method
        public void Info()
        {
            Console.WriteLine("This is general shape class"); // concrete method
        }
    }
}
