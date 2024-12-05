using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Inheritance.Multiple
{
    internal class ShowResult : Error, Success
    {
        private string message = "";
        public void SetMessage(string message)
        {
            this.message = message;
        }

        public void Show()
        {
            Console.Write($"Status: {this.message}");
        }
    }
}
