using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC153
{
    class ABC153C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];
            long[] H = ReadLine().Split(' ')
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToArray();

            for (int i = 0; i < Min(N, K); i++)
            {
                H[i] = 0;
            }

            WriteLine(H.Sum().ToString());
            ReadKey();
        }
    }
}
