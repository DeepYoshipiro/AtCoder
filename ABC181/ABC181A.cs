using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC181
{
    class ABC181A
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            WriteLine(N % 2 == 0 ? "White" : "Black");
            ReadKey();
        }
    }
}
