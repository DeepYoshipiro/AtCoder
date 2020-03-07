using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _700pt
{
    class AGC041B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            long N = init[0];
            long M = init[1];
            long V = init[2];
            long P = init[3];

            long[] A = (new long[1]{0})
                .Concat(ReadLine().Split()
                    .Select(n => long.Parse(n))
                    .OrderByDescending(n => n)).ToArray();

            long lower = P;
            long upper = N;

            while (lower < upper)
            {
                long X = (lower + upper) / 2;
                if (X == lower) X++;

                if (A[X] + M < A[P])
                {
                    upper = X - 1;
                    continue;
                }

                long rest = V;
                rest -= P - 1;
                rest -= N - X;
                if (rest < 0)
                {
                    lower = X;
                    continue;
                }

                rest *= M;
                for (long i = P; i < X; i++)
                {
                    rest -= (A[X] + M) - A[i];
                }

                if (rest > 0)
                {
                    upper = X - 1;
                }
                else
                {
                    lower = X;
                }
            }
            long result = upper;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
