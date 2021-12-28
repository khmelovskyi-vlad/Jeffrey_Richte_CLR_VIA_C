using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C._13
{
    interface ITest
    {
        void MetTest();
        void MetTest2();
    }
    class BaseClass : ITest
    {
        void ITest.MetTest2()
        {

        }
        public virtual void MetTest()
        {
            Console.WriteLine("base class");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void MetTest()
        {
            Console.WriteLine("derived class");
            base.MetTest();
        }
    }
    class TestInterfaces
    {
        public void Test()
        {
            var d = new DerivedClass();
            d.MetTest();
        }
    }
}
