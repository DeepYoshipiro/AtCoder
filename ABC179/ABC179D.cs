using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC179
{
    class ABC179D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            // var advance = new List<int>();
            var dpNumWay = new long[N + 1];
            long MOD = 998244353;

            var L = new int[K];
            var R = new int[K];
            for (int j = 0; j < K; j++)
            {
                var range = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                L[j] = range[0];
                R[j] = range[1] + 1;

                // for (int m = L; m <= R; m++)
                // {
                //     advance.Add(m);
                // }
            }
            // advance.Sort();

            dpNumWay[1] = 1;
            dpNumWay[2] = -1;
            for (int curPos = 1; curPos <= N; curPos++)
            {
                dpNumWay[curPos] += dpNumWay[curPos - 1];
                dpNumWay[curPos] %= MOD;
                if (dpNumWay[curPos] < 0) dpNumWay[curPos] += MOD;
                if (dpNumWay[curPos] == 0) continue;
                for (int j = 0; j < K; j++)
                {
                    if (curPos + L[j] > N) continue;
                    dpNumWay[curPos + L[j]] += dpNumWay[curPos];

                    if (curPos + R[j] > N) continue;
                    dpNumWay[curPos + R[j]] -= dpNumWay[curPos];
                }
                // foreach (int move in advance)
                // {
                //     if (curPos + move > N) break;
                //     dpNumWay[curPos + move] += dpNumWay[curPos];
                //     dpNumWay[curPos + move] %= MOD;
                // }
            }

            WriteLine(dpNumWay[N].ToString());
            ReadKey();
        }
    }
}
