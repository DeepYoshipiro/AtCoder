using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC019A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n=> int.Parse(n)).ToArray();
            int Q = init[0];
            int H = init[1];
            int S = init[2];
            int D = init[3];

            long N = long.Parse(ReadLine());

            long cost1L = Min(Min(4 * Q, 2 * H), S);
            long cost2L = Min(2 * cost1L, D);

            long result = N / 2 * cost2L + N % 2 * cost1L;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}