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
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            long[] A = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToArray();

            long result = 0;
            int k = K;
            int[] maximim = new int[N];
            int[] minimum = new int[N];
            for (int i = K; i > 0; i--)
            {
                maximim[N - K + i - 1] = i;
                minimum[K - i] = K;
            }
            for (int i = 0; i < N; i++)
            {
                result += maximim[i] * A[i];
                result %= 100000007;
                result -= minimum[i] * A[i];
                result %= 100000007;
            }

            if (result < 0) result += 100000007;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
