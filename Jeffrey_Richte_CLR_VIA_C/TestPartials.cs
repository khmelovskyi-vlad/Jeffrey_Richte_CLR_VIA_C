using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C
{
    partial class TestPartials
    {
        public TestPartials()
        {
            Test1();
            Test2();
        }
        partial void Test1();
        partial void Test2();
        partial void Test3(ref string a);
        //partial void Test4(out string a);
    }
    partial class TestPartials
    {
        partial void Test1()
        {
            Console.WriteLine("Test 1");
        }
    }
}
