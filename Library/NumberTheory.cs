using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Library
{
    class NumberTheory
    {
        internal int GCD(int A, int B)
        {
            if (A < B)
            {
                BaseAlgorithm ba = new BaseAlgorithm();
                ba.Swap(ref A, ref B);
            }

            int R = A;

            while (R > 0)
            {
                R = A % B;
                A = B;
                B = R;
            }
            return A;
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
