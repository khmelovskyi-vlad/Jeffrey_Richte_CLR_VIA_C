using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C
{
    class BeforeFieldInit
    {
        public static int Value = 1;
    }
    class Precise
    {
        public static int Value;
        static Precise()
        {
            Value = 1;
        }
    }
    class TestStaticConstuctors
    {
        public static void Test()
        {
            var count = 1_000_000_00;
            PerformanceTest(count);
            Console.WriteLine(count);
            PerformanceTest(count);

        }
        public static void PerformanceTest(int count)
        {
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                BeforeFieldInit.Value = 1;
            }
            Console.WriteLine($"Test1: {sw.Elapsed} - BeforeFieldInit");

            sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                Precise.Value = 1;
            }
            Console.WriteLine($"Test1: {sw.Elapsed} - Precise");
        }
    }
}
