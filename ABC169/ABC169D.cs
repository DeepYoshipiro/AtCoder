using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC169
{
    class ABC169D
    {
        static void Main(string[] args)
        {
            var N = long.Parse(ReadLine());

            var Primes = PrimeFactorize(N);
            var PrimeFactor = new Dictionary<long, int>();

            var maxPow = 1;
            foreach (long p in Primes)
            {
                if (PrimeFactor.ContainsKey(p))
                {
                    PrimeFactor[p]++;
                    maxPow = Max(PrimeFactor[p], maxPow);
                }
                else
                {
                    PrimeFactor.Add(p, 1);
                }
            }

            var count = new long[maxPow + 1];
            var added = 1;
            var cur = 0;
            var i = 1;
            while (i <= maxPow)
            {
                cur++;
                added++;
                count[i] = cur; 
                for (int j = i + 1; j <= i + added; j++)
                {
                    if (j > maxPow) break;
                    count[j] = cur;
                }
                i += added;
            }

            long result = 0;
            foreach (long div in PrimeFactor.Keys)
            {
                result += count[PrimeFactor[div]];
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        static IEnumerable<long> PrimeFactorize(long N)
        {
            long firstN = N;
            long div = 2;
            while (N >= 1 && div * div < firstN)
            {
                if (N % div == 0)
                {
                    N /= div;
                    yield return div;
                }
                else
                {
                    div++;
                }                    
            }
            if (N > 1)
            {
                yield return N;
            }
        }

    }
}
