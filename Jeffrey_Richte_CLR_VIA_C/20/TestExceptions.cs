using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C._20
{
    class TestExceptions
    {
        public void Test()
        {
            //IntPtr
            //﻿FormatterServices
            //SurrogateSelector
            try
            {
                try
                {
                    string s = null;
                    var first = s[0];
                    try
                    {
                        RuntimeHelpers.EnsureSufficientExecutionStack(); // check enough stack space
                    }
                    catch (InsufficientExecutionStackException)
                    {
                        Console.WriteLine("");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("First check");
                    throw new Exception("");
                }
                finally
                {
                    Console.WriteLine("Finally");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Second check");
            }
        }
    }
}
