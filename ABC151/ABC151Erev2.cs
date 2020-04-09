using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC151
{
    class ABC151Erev2
    {
        static void Main(string[] args)
        {
            long Mod = (long)Pow(10, 9) + 7;
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];
            CombinationTable comb = new CombinationTable(N, Mod);

            long[] A = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToArray();
            
            long result = 0;

            long Comb = 1;
            for (int i = 0; i <= K; i++)
            {
                result += Comb * (A[K - i] - A[(N - 1) - (K - i)]);
                result %= Mod; 

                Comb *= (K + i) * comb.Inv(i + 1);
                Comb %= Mod;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }

    internal class CombinationTable
    {
        private List<long> Binary = new List<long>();
        private long MOD;
        private int N;
        //public long[] Comb {get;}

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

        }

        internal long Inv(int K)
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