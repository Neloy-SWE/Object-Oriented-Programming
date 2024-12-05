using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.OtherTopics
{
    internal class StaticInstanceExample
    {
        public static int TotalCount = 0;
        public int InstanceCount = 0;

        public StaticInstanceExample()
        {
            TotalCount++;
            InstanceCount++;
        }
    }
}
