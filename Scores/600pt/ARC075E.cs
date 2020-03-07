using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _600pt
{
    class ARC075E
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long N = init[0];
            long K = init[1];

            long[] a = new long[N];
            a[0] = long.Parse(ReadLine()) - K;
            for (int i = 1; i < N; i++)
            {
                a[i] = long.Parse(ReadLine()) - K;
                a[i] += a[i - 1];
            }

   //         long before = 0;

            WriteLine();
            ReadKey();
        }
    }
}