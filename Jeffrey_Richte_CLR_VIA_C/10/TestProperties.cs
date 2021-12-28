using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C._10
{
    class TestProperties
    {
        public void Test()
        {
            //var haveList = new HaveList() { ListInts = { 1, 2, 3 } };
            //foreach (var item in haveList.ListInts)
            //{
            //    Console.WriteLine(item);
            //}

            //HaveList.CheckRefProp(ref HaveList.PropForRef);

            var name = "Vlad";
            //var test = new { name, name };

            //var test = new Tuple(1, 2);
            var test = Tuple.Create(1, 2);
        }
    }
    class HaveList
    {
        public int this[bool b] { get { return 0; } }
        //public string this[bool b] { get { return ""; } }
        //[IndexerName("Jeff")]
        public string this[string b] { get { return ""; } }
        public IEnumerable<int> ListInts { get; set; }

        public static int PropForRef { get; set; }
        //public static void CheckRefProp(ref int count, Foo h = new Foo(3))
        //{
        //    count = 2;
        //}
    }
    struct Foo
    {
        public int Test;
        public Foo(int test)
        {
            Test = test;
        }
    }
}
