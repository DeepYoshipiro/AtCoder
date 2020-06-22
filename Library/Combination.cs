using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Library
{
    class CombinationTest
    {

        static void Main(string[] args)
        {
            // long M = (long)(Pow(10, 9) + 7);
            long M = 101;
            Write("case: {0} ", M);
            var cb = new Combination(M);
            foreach (int r in cb.Bin)
            {
                Write(r.ToString());
            }
            WriteLine();

            var test = new long[]{100, 48, 33, 70, 56, 5, 2, 1};
            foreach (long N in test)
            {
                long rev = cb.Inv(N);
                Write("{0} * {1} = {2} ≡ {3}", N, rev, N * rev, (N * rev) % M);
                WriteLine();
            }
            ReadKey();
        }
    }

    internal class Combination
    {
        public List<int> Bin{get;}
        long Mod;

        internal Combination(long M)
        {
            Mod = M;
            Bin = Binary(M).ToList();
        }

        internal IEnumerable<int> Binary(long M)
        {
            var m = M - 2;
            while (m > 0)
            {
                int R = (int)(m % 2);
                m -= R;
                m /= 2;
                yield return R;
            }
            yield break;
        }

        internal long Inv(long a)
        {
            long result = 1;
            foreach (int x in Bin)
            {
                if (x == 1)
                {  
                    result *= a;
                    result %= Mod;
                }
                a *= a;
                a %= Mod;
            }
            return result;
        }
    }
}