using Jeffrey_Richte_CLR_VIA_C._12;
using Jeffrey_Richte_CLR_VIA_C._13;
using Jeffrey_Richte_CLR_VIA_C._10;
using System;
using Jeffrey_Richte_CLR_VIA_C._14;
using Jeffrey_Richte_CLR_VIA_C._17;
using Jeffrey_Richte_CLR_VIA_C._20;
using Jeffrey_Richte_CLR_VIA_C._26_30;

namespace Jeffrey_Richte_CLR_VIA_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var testConstuctorInh2 = new TestConstuctorInh2();
            //System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor();
            var testPartial = new TestPartials();
            var testStructs = new TestStructs();
            var testStructs2 = new TestStructs(10);
            TestStaticConstuctors.Test();
            var testProperties = new TestProperties();
            testProperties.Test();
            var testGenerics = new TestGenerics();
            testGenerics.Test();
            var testInterfaces = new TestInterfaces();
            testInterfaces.Test();
            var testStrings = new TestStrings();
            testStrings.Test();
            var testDelegates = new TestDelegates();
            testDelegates.Test();
            var testExceptions = new TestExceptions();
            testExceptions.Test();
            //throw new Exception();
            var testThreads = new TestThreads();
            testThreads.Test();
        }
    }
}
