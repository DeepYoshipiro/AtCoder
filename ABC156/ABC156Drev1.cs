// Solution : High-speed Exp, Mod Inverse
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC156
{
    class ABC156Drev1
    {
        static void Main(string[] args)
        {
            int[] unlike = ReadLine().Split()
                .Select(m => int.Parse(m)).ToArray();
            int N = unlike[0];
            int A = unlike[1];
            int B = unlike[2];

            int MOD = (int)Pow(10, 9) + 7;

            CombinationTable N_Comb = new CombinationTable(N, MOD);

            // Find 2^n
            long result = N_Comb.Pow2Mod();
            // - nC0
            result--;
            if (result < 0) result += MOD;

            // - nCa
            result -= N_Comb.Comb[A];
            if (result < 0) result += MOD;

            // - nCb
            result -= N_Comb.Comb[B];
            if (result < 0) result += MOD;

            WriteLine(result.ToString());
            ReadKey();
        }
    }

    internal class CombinationTable
    {
        private List<long> Binary = new List<long>();
        private long MOD;
        private int N;
        public long[] Comb {get;}

        internal long Pow2Mod()
        {
            int _N = N;
            long square = 2;
            long result = 1;
            while (_N > 0)
            {
                if (_N % 2 == 1)
                {
                    result *= square;
                    result %= MOD;
                }
                _N /= 2;                

                square *= square;
                square %= MOD;
            }
            return result;
        }

        internal CombinationTable(int _N, long mod)
        {
            N = _N;
            MOD = mod;

            // For find inverse, make binary
            mod -= 2;
            while (mod > 0)
            {
                Binary.Add(mod % 2);
                mod /= 2;
            }

            // Make Combination Table
            int K = Min(N, 200000);
            Comb = new long[K + 1];
            Comb[0] = 1;
            for (int i = 1; i <= K; i++)
            {
                Comb[i] = Comb[i - 1] * (N + 1 - i) % MOD;
                Comb[i] *= Inv(i);
                Comb[i] %= MOD;
            }
        }

        private long Inv(int K)
        {
            long square = K;
            long result = Binary[0] * square % MOD;
            for (int i = 1; i < Binary.Count(); i++)
            {
                square *= square;
                square %= MOD;
                if (Binary[i] == 1)
                {
                    result *= square;
                    result %= MOD;
                }                
            }
            return result;
        }
    }
}
