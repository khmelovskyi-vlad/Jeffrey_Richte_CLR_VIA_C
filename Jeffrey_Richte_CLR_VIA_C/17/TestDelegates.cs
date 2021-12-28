using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C._17
{
    class TestDelegates
    {
        private delegate void TestDel(int num);
        private delegate object TestVar(string num);
        public void Test()
        {
            var testDelegates = new TestDelegates();
            var testDel = new TestDel(testDelegates.TestMet);
            testDel += null;
            testDel += new TestDel(TestMet);
            //testDel += new TestDel(TestMet4);
            testDel(5);
            testDel.Invoke(2);
            var func = new Func<int, string>(TestMet2);
            func(10);
            var testVar = new TestVar(TestMet3);
            testVar += new TestVar(TestMet4);
            testVar("15");
            DelegateReflection.Method(new string[] { "Jeffrey_Richte_CLR_VIA_C._17.OneString", "Reverse", "Hi man" });
        }
        private void TestMet(int num)
        {
            Console.WriteLine(num);
            Console.WriteLine(GetHashCode());
        }
        private string TestMet2(int num)
        {
            return num.ToString();
        }
        private object TestMet3(string num)
        {
            Console.WriteLine(num);
            return num;
        }
        private string TestMet4(object num)
        {
            Console.WriteLine(num);
            return num.ToString();
        }
    }
    internal delegate object TwoInt32s(int n1, int n2);
    internal delegate object OneString(string s1);

    public static class DelegateReflection
    {
        public static void Method(string[] args)
        {
            if (args.Length < 2)
            {
                string usage = @"Usage:" + 
                    "{0} delType methodName [Arg1] [Arg2]" + 
                    "{0} where delType must be TwoInt32s or OneString" + 
                    "{0} if delType is TwoInt32s, method Name must be Add or Subtract" + 
                    "{0} if delType is OneString, method Name must be NumChars or Reverse" + 
                    "{0}" + 
                    "{0}Examples:" + 
                    "{0}   TwoInt32s Add 123 321" + 
                    "{0}   TwoInt32s Subtract 123 321" + 
                    "{0}   OneString NumChars \"Hello there\"" + 
                    "{0}   OneString Reverse  \"Hello there\"";
                Console.WriteLine(usage, Environment.NewLine);
                return;
            }

            Type delType = Type.GetType(args[0]);
            if (delType == null)
            {
                Console.WriteLine("Invalid delType agrument: " + args[0]);
                return;
            }
            Delegate d;
            try
            {
                MethodInfo mi = typeof(DelegateReflection).GetTypeInfo().GetDeclaredMethod(args[1]);
                d = mi.CreateDelegate(delType);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid methodName argument: " + args[1]);
                return;
            }
            object[] callbackArgs = new object[args.Length - 2];
            if (d.GetType() == typeof(TwoInt32s))
            {
                try
                {
                    for (int a = 2; a < args.Length; a++)
                    {
                        callbackArgs[a - 2] = int.Parse(args[a]);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Parameters must be inregers.");
                    return;
                }
            }
            if (d.GetType() == typeof(OneString))
            {
                Array.Copy(args, 2, callbackArgs, 0, callbackArgs.Length);
            }
            try
            {
                object result = d.DynamicInvoke(callbackArgs);
                Console.WriteLine(result);
            }
            catch (TargetParameterCountException)
            {
                Console.WriteLine("Incorrect number of parameters specified.");
            }
        }
        private static object Add(int n1, int n2)
        {
            return n1 + n2;
        }
        private static object Subtrack(int n1, int n2)
        {
            return n1 - n2;
        }
        private static object NumChars(string s1)
        {
            return s1.Length;
        }
        private static object Reverse(string s1)
        {
            return new string(s1.Reverse().ToArray());
        }
    }
}
