using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Constructor
{
    /*
     * a constructor having at least one parameter is called as parameterized constructor.
     * it can initialize each istance of the class to different values.
     */
    internal class ParameterizedConstructor
    {
        public string name;
        public int id;

        public ParameterizedConstructor(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
