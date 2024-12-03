using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Encapsulation
{
    file class FileAccessModifierExample
    {
       public int a = 10;
    }

    class Check
    {
       public void RunTask()
        {
            FileAccessModifierExample example = new FileAccessModifierExample();
            Console.WriteLine(example.a);
        }
    }
}
