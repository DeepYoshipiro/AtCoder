using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC167
{
    class ABC167E
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];
            var K = init[2];

            if (M == 1 && K == N - 1)
            {
                WriteLine("1");
                ReadKey();
                return;
            }

            long MOD = 998244353;
            long pow = 1;
            for (long j = 1; j <= N - 1; j++)
            {
                pow *= M - 1;
                pow %= MOD;
            }

            var dm = new DiscreteMath();
            long comb = 1;
            long result = pow;
            for (long i = 1; i <= K; i++)
            {
                pow *= dm.Inverse(M - 1, MOD);
                pow %= MOD;

                comb *= N - i;
                comb %= MOD;
                comb *= dm.Inverse(i, MOD);
                comb %= MOD;

                result += comb * pow;
                result %= MOD;
            }
            result *= M;
            result %= MOD;

            WriteLine(result.ToString());
            ReadKey();
        }

        class DiscreteMath
        {
            internal long Inverse(long A, long MOD)
            {
                long X = 0;
                long Y = 0;
                extGCD(A, MOD, out X, out Y);
                if (X < 0) X += MOD;
                return X;
            }

            private long extGCD(long A, long B, out long X, out long Y)
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
