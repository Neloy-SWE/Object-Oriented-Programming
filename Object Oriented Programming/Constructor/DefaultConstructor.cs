using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Constructor
{
    /*
     * a constructor with no parameters is called a default constructor.
     * a default constructor has every instance of the class to be initialized to the same values.
     * the default constructor initializes all numeric fields to zero 
     * and all string and obejct fields to nul inside a class.
     */
    internal class DefaultConstructor
    {
        public int num;
        public string name;

        /* 
         * if we do not declare any constructor
         * compiler will autometically create a default constructor
         */

        public DefaultConstructor()
        {
            name = "";
            Console.WriteLine("Default constructor called");
        }
    }
}
