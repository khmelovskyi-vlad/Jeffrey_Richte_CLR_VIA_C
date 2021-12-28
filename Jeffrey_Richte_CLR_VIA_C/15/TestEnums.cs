using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeffrey_Richte_CLR_VIA_C._15
{
    enum Color
    {
        Black,
        White
    }
    [Flags]
    enum Colors
    {
        Black = 1,
        White = 2
    }
    class TestEnums
    {
        public void Test()
        {
            var arr = Enum.GetValues(typeof(Color));
            var arr2 = Enum.GetValues<Color>();
            var color = Color.Black;
            Console.WriteLine((color & Color.Black) != 0);
            Console.WriteLine(color.HasFlag(Color.Black));
        }
    }
}
