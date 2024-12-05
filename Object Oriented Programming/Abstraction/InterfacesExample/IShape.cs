using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * interfaces cannot contain instance fields
 * interfaces can contain static fields
 */

namespace Object_Oriented_Programming.Abstraction.InterfacesExample
{
    internal interface IShape
    {
        //static string message = ""; // allow
        //string message; // not allow
        //public abstract void Draw();
        void Draw();
        //{
        //    Console.WriteLine("Hello");
        //}
    }
}
