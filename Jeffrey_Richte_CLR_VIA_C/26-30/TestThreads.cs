using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C._26_30
{
    class TestThreads
    {
        public void Test()
        {
            var thread1 = new Thread(() => {
                Thread.Sleep(2000);
                Console.WriteLine("Start first background thread after 2 second");
            });
            var thread2 = new Thread(() => {
                Thread.Sleep(10000);
                Console.WriteLine("Start second background thread after 10 second");
            });
            var thread3 = new Thread(() => {
                Thread.Sleep(5000);
                Console.WriteLine("Start foreground thread after 5 second");
            });
            thread1.IsBackground = true;
            thread1.Start();
            thread2.IsBackground = true;
            thread2.Start();
            thread3.Start();
        }
    }
}
