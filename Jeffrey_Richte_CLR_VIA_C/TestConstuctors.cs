using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C
{
    class TestConstuctorMain
    {
        public TestConstuctorMain()
        {
            Console.WriteLine("main");
            BadIdea();
        }
        protected virtual void BadIdea()
        {
            Console.WriteLine("main Bad Idea");
        }
    }
    class TestConstuctorInh1: TestConstuctorMain
    {
        public TestConstuctorInh1()
        {
            Console.WriteLine("Inh1");
            BadIdea();
        }
        protected override void BadIdea()
        {
            Console.WriteLine("Inh1 Bad Idea");
        }
    }
    class TestConstuctorInh2: TestConstuctorInh1
    {
        public TestConstuctorInh2()
        {
            Console.WriteLine("Inh2");
            BadIdea();
        }
        protected override void BadIdea()
        {
            Console.WriteLine("Inh2 Bad Idea");
        }
    }
}
