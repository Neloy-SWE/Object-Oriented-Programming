using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Constructor
{
    /*
     * this constructor creates an object by copying variables from another object. 
     * its main use is to initialize a new instance to the values of an existing instance.
     */
    internal class CopyConstructor
    {
        private int id;
        private string name;

        public CopyConstructor(CopyConstructor copy)
        {
            this.id = copy.id;
            this.name = copy.name;
        }

        public CopyConstructor(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Details
        {
            get
            {
                return "ID: " + id + "\nName: " + name;
            }
        }
    }
}
