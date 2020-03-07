using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC048B
    {
        static void Main(string[] args)
        {
            long[] init = Console.ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long a = init[0];
            long b = init[1];
            long x = init[2];

            long result = (b / x);
            if (a > 0)
                result -= ((a - 1) / x);
            else
                result++;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}