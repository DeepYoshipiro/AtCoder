using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _700pt
{
    class AGC025B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = init[0];  
            var A = init[1]; 
            var B = init[2];
            var K = init[3];

            long MOD = 998244353;
            var comb = (new DiscreteMath()).Combination(N, MOD);

            long result = 0;
            for (long i = 0; i <= N; i++)
            {
                if ((K - i * A) % B != 0) continue;
                
                long j = (K - i * A) / B;
                if (j < 0 || j > N) continue;

                result += comb[i] * comb[j];
                result %= MOD;
            }
            WriteLine(result.ToString());
            ReadKey();
        }

        class DiscreteMath
        {
            internal long[] Combination(long N, long MOD)
            {
                var inverse = new long[N + 1];
                inverse[0] = 0;
                for (long i = 1; i <= N; i++)
                {
                    inverse[i] = Inverse(i, MOD);
                }

                var comb = new long[N + 1];
                comb[0] = 1;
                for (long i = 1; i <= N; i++)
                {
                    comb[i] = (comb[i - 1] * (N + 1 - i)) % MOD;
                    comb[i] *= inverse[i];
                    comb[i] %= MOD;
                    if (comb[i] < 0) comb[i] += MOD;
                }
                return comb;
            }

            private long Inverse(long A, long MOD)
            {
                long X = 0;
                long Y = 0;
                extGCD(A, MOD, out X, out Y);
                if (X < 0) X += MOD;
                return X;
            }

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
        }
    }
}
