using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC107
{
    class ARC107B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            long result = 0;
            for (int S = 2; S <= 2 * N; S++)
            {
                var wayS = Min(S - 1, 2 * N - S + 1);

                var D = S - K;
                if (D < 2 || D > 2 * N) continue;
                var wayD = Min(D - 1, 2 * N - D + 1);

                result += (long)wayS * (long)wayD;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}