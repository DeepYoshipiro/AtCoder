using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC069C
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long S = init[0];
            long c = init[1];

            long m = (c - 2 * S) / 4;
            if (m > 0)
            {
                S += m;
                c -= 2 * m;
            }

            WriteLine(Min(S, c / 2).ToString());
            ReadKey();
        }
    }
}