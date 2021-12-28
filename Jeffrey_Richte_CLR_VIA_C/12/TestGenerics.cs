using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C._12
{
    public delegate TResult Func<in T, out TResult>(T arg);
    class TestGenerics
    {
        public void Test()
        {
            //Func<object, ArgumentException> fn1 = null;
            //Func<string, Exception> fn2 = fn1;
            //Exception e = fn2("");

            Func<object, ArgumentException> ffn1 = ExMet;
            Func<string, Exception> ffn2 = ffn1;
            Exception ee = ffn2("mes");
            Console.WriteLine(ee.Message);
        }
        private Exception ExMet(string mes)
        {
            return new Exception(mes);
        }
        private ArgumentException ExMet(object mes)
        {
            if (mes is string message)
            {
                return new ArgumentException(message);
            }
            return new ArgumentException("");
        }
        private void Test<T>(T i1, T i2)
        {
            //if (i1 == i2)
            //{

            //}
        }
    }
}
