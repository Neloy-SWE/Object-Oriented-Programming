using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Constructor
{
    /*
     * if a constructor is created with private specifier is known as private constructor.
     * it is not possible for other classes to derive from this class and also it's not possible
     * to ceate an instance of this class.
     */
    internal class PrivateConstructor
    {
        private PrivateConstructor() { }
        // it is the implementation of a singleton pattern
        // use private constructor when we have only static members.
        // use private constructor to prevent the creation of the instances of that class.

        public static string name = "Engineer";
    }
}
