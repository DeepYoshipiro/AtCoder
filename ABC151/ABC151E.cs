// Solution : Combination Calculate (Used Cumulative Sum)
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC151
{
    class ABC151E
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            var A = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToArray();

            if (N == 1 || K == 1)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            var dm = new DiscreteMath();

            long MOD = (long)Pow(10, 9) + 7;
            var Combination = new long[N - K + 1];
            var SumCombination = new long[N - K + 1];

            Combination[0] = 1;
            SumCombination[0] = 1;

            var MaxTermsBetween = N - K;
            for (int j = 1; j <= MaxTermsBetween; j++)
            {
                Combination[j] = Combination[j - 1] * (long)(K - 2 + j) 
                    * dm.Inverse((long)j, MOD);
                Combination[j] %= MOD;

                SumCombination[j] = SumCombination[j - 1] + Combination[j];
                SumCombination[j] %= MOD;
            }

            long result = 0;
            for (int i = 0; i <= MaxTermsBetween; i++)
            {
                var diff = (A[i] - A[N - 1 - i]) % MOD;
                result += SumCombination[MaxTermsBetween - i] * diff;
                result %= MOD;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        class DiscreteMath
        {
            internal long extGCD(long A, long B, out long X, out long Y)
            {
                var curR = new List<long>();
                var curX = new List<long>();
                var curY = new List<long>();
                curR.Add(A);
                curX.Add(1);
                curY.Add(0);
                
                curR.Add(B);
                curX.Add(0);
                curY.Add(1);

                while (curR[curR.Count() - 2] % curR[curR.Count - 1] != 0)
                {
                    var idxA = curR.Count() - 2;
                    var idxB = curR.Count() - 1;

                    var curA = curR[idxA];
                    var curB = curR[idxB];

                    curR.Add(curA % curB);
                    var Q = curA / curB;

                    curX.Add(curX[idxA] - Q * curX[idxB]);
                    curY.Add(curY[idxA] - Q * curY[idxB]);
                }

                X = curX.Last();
                Y = curY.Last();
                return curR.Last();
            }


            internal long Inverse(long A, long MOD)
            {
                long X = 0;
                long Y = 0;
                extGCD(A, MOD, out X, out Y);
                if (X < 0) X += MOD;
                return X;
            }
        }
    }
}
