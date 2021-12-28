using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C
{
    struct TestStructs
    {
        int x,y,z;
        public TestStructs(int x)
        {
            this = new TestStructs();
            this.x = x;
            Console.WriteLine($"x={x}, y={y}, z={z}");
        }
    }
}
