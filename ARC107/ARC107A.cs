using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC107
{
    class ARC107A
    {
        static void Main(string[] args)
        {
            var my = new ARC107A();
            long MOD = 998244353;

            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long result = 1;
            long divide2 = my.Inverse(2, MOD);
            foreach (long times in init)
            {
                result *= times;
                result %= MOD;
                result *= times + 1;
                result %= MOD;
                result *= divide2;
                result %= MOD;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        long Inverse(long A, long MOD)
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