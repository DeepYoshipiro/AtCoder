using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC172
{
    class ABC172D
    {
        static void Main(string[] args)
        {
            var dm = new DiscreteMath();

            var N = long.Parse(ReadLine());

            var divisorCnt = dm.DivisorCnt(N);

            long result = 0;
            for (long i = 1; i <= N; i++)
            {
                result += i * divisorCnt[i];
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }

    internal class DiscreteMath
    {
        internal long[] DivisorCnt(long N)
        {
            var divisorCnt = new long[N + 1];

            for (long i = 1; i <= N; i++)
            {
                for (long j = i; j <= N; j += i)
                {
                    divisorCnt[j]++;
                }
            }

            return divisorCnt;
        }
    }
}
