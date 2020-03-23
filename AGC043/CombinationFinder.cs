using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

using System.Numerics;

namespace AGC043
{
    class CombinationFinder
    {
        static void Main(string[] args)
        {
            const int MOD = 1000000007;

            int N = int.Parse(ReadLine());
            CombinationTable N_Comb = new CombinationTable(N, MOD);

            for (int i = 0; i <= N; i++)
            {
                //WriteLine(comb.Comb[i]);
            }
            WriteLine("OK");
            ReadKey();
        }
    }

    internal class CombinationTable
    {
        private List<long> Binary = new List<long>();
        private long MOD;
        private int N;
        public long[] Comb {get;}

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
            Comb = new long[N + 1];
            Comb[0] = 1;
            for (int i = 1; i <= N; i++)
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