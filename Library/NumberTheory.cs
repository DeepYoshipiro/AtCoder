using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Library
{
    class ABC070C
    {
        static void Main(string[] args)
        {
            var nt = new NumberTheory();
            int N = int.Parse(ReadLine());
            long result = long.Parse(ReadLine());
            for (int i = 2; i <= N; i++)
            {
                long T = long.Parse(ReadLine());
                result = nt.LCM(result, T);
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }

    class NumberTheory
    {
        internal long GCD(long M, long N)
        {
            long A = Max(M, N);
            long B = Min(M, N);
            long R = A;

            while (R > 0)
            {
                R = A % B;
                A = B;
                B = R;
            }
            return A;
        }

        internal long LCM(long M, long N)
        {
            long d = GCD(M, N);
            return M / d * N;
        }

        internal IEnumerable<long> PrimeFactorize(long N)
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
