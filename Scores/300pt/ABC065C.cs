using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC065C
    {
        const long MOD = 1000000007;
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            long result;
            switch(Abs(N - M))
            {
                case 0:
                    result = Perm(N);
                    result *= 2;
                    result %= MOD;
                    break;
                case 1:
                    result = Perm(Min(M, N));
                    result *= Max(M, N);
                    result %= MOD;
                    break;
                default:
                    result = 0;
                    break;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        static long Perm(long N)
        {
            long result = 1;
            for (int i = 1; i <= N; i++)
            {
                result = (result * i) % MOD;
                result = (result * i) % MOD;
            }
            return result;
        }
    }
}