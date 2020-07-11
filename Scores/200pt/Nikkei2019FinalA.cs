using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class Nikkei2019FinalA
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = (new int[]{0})
                .Concat(ReadLine().Split()
                        .Select(n => int.Parse(n)))
                .ToArray();
            var sumA = new long[N + 1];

            for (int i = 1; i <= N; i++)
            {
                sumA[i] = sumA[i - 1] + (long)A[i];
            }

            for (int i = 1; i <= N; i++)
            {
                long result = 0;
                for (int j = 1; j <= N - i + 1; j++)
                {
                    int first = j;
                    int last = j + i - 1;
                    long cur = sumA[last] - sumA[first - 1];
                    if (cur > result) result = cur;
                }
                WriteLine(result.ToString());
            }
            ReadKey();
        }
    }
}        

