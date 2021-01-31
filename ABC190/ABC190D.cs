using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC190
{
    class ABC190D
    {
        static void Main(string[] args)
        { 
            var N = long.Parse(ReadLine());

            var dm = new DiscreteMath();
            var divisor = dm.Divisor(2 * N);
            var result = 0;
            foreach (long K in divisor)
            {
                if ((2 * N) % K != 0) continue;
                if ((((2 * N) / K) - (K - 1)) % 2 != 0) continue;
                var A = ((2 * N / K) - (K - 1)) / 2;
                result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }

    class DiscreteMath
    {
        internal IEnumerable<long> Divisor(long N)
        {
            for (long i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    yield return i;
                    if (i * i != N) yield return N / i;
                }
            }
            yield break;
        }
    }
}
