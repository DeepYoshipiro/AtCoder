using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC164
{
    class ABC164A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int S = init[0];
            int W = init[1];

            WriteLine(S <= W ? "unsafe" : "safe");
            ReadKey();
        }
    }
}
