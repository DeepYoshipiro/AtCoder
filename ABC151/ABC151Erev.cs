using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC151
{
    class ABC151Erev
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            long[] A = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderBy(n => n).ToArray();

            long result = 0;
            int maxElement = N - 1;
            int minElement = 0;
            long MOD = 1000000000 + 7;
            for (int i = N - K + 1; i > 0; i--)
            {
                result += i * A[maxElement];
                result -= i * A[minElement];
                result %= MOD;
                if (result < 0) result += MOD;
                maxElement--;
                minElement++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
