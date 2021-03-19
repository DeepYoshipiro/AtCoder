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

            long[] A = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToArray();

            long[] Sum = new long[N];
            Sum[0] = A[0];
            for (int i = 1; i < N; i++)
            {
                Sum[i] = Sum[i - 1] + A[i];
            }

            if (K == 1)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            long result = 0;
            for (int i = 0; i < N - K + 1; i++)
            {
                var add = (long)((N - K + 2) - i) * A[i];
                var sub = Sum[N - 1] - Sum[i + K - 2];
                result += (long)((N - K + 2) - i) * A[i] - (Sum[N - 1] - Sum[i + K - 2]);
                result %= 1000000000 + 7;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
