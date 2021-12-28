using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C._14
{
    class TestStrings
    {
        public void Test()
        {
            var c = 'c';
            var category = char.GetUnicodeCategory(c);
            StringComparison sc = StringComparison.OrdinalIgnoreCase;
            CompareOptions co = CompareOptions.IgnoreCase;
            CultureInfo ci = new CultureInfo("de-DE");
            //CompareInfo
            Console.WriteLine();
            Console.WriteLine(String.Compare("Strasse", "Straße", StringComparison.Ordinal) == 0);
            Console.WriteLine(String.Compare("Strasse", "Straße", true, ci) == 0);
            Console.WriteLine("cs" == "CS");
            String.Intern("");
            var s1 = "Hi";
            var s2 = "Hi";
            Console.WriteLine(Object.ReferenceEquals(s1, s2));
            var si = new StringInfo("");
            var sb = new StringBuilder();
            sb.AppendFormat("");
            //ICustomFormatter
            2.ToString("", CultureInfo.InvariantCulture);
        }
    }
}
