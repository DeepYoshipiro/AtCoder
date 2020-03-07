using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace TeaBreak003
{
    class TeaBreak003A
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());

            WriteLine(n % 4 != 3 ? "Yes" : "No");
            ReadKey();
        }
    }
}