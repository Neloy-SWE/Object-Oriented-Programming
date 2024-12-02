using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Constructor
{
    /*
     * static constructor has to be invoked only once in the class
     * and it has been invoked during the creation of the first reference
     * to a staic member in the class. 
     * a static constructor is initialized static fields 
     * or data of the class and to be executed only once.
     */
    internal class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static constructor");
        }
        // it can't be called dirctly.
        // when it is executing then the user has no control.
        // it does not take access modifiers or any parameters.
        // it is called automatically to initialize the class before the first instance created.

        public StaticConstructor(int a)
        {
            Console.WriteLine("Instance constructor " + a);
        }

        public void Show()
        {
            Console.WriteLine("Hello world");
        }
    }
}
