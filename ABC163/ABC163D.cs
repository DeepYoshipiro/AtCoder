using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC163
{
    class ABC163D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            var googolCnt = new long[N + 2];
            for (int i = 1; i <= N + 1; i++)
            {
                googolCnt[i] = (long)i * (long)((N + 1 - i) + N) / 2;
                googolCnt[i] -= (long)i * (long)(i - 1) / 2 - 1;
            }

            long result = 0;
            for (int i = K; i <= N + 1; i++)
            {
                result += googolCnt[i];
                result %= (long)Pow(10, 9) + 7;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
