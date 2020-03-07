using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;
 
namespace ABC152
{
    class ABC152Erev
    {
        static void Main(string[] args)
        {
            ABC152Erev my = new ABC152Erev();
 
            int N = int.Parse(ReadLine());
            List<long> A = ReadLine().Split()
                            .Select(n => long.Parse(n))
                            .ToList();
 
            long maxA = (long)Pow(10, 6);
            Dictionary<long, long> sieve = my.GetSieve(maxA);
 
            List<long> tempA = new List<long>(A);

            int[][] factor = new int[maxA + 1][];
            for (int a = 0; a <= maxA; a++)
            {
                factor[a] = new int[N];
            }

            for (int i = 0; i < N; i++)
            {
                while (tempA[i] > 1)
                {
                    factor[sieve[tempA[i]]][i]++;
                    tempA[i] /= sieve[tempA[i]];
                }
            }

            long LCM = 1;
            long mod = (long)Pow(10, 9) + 7; 
            for (int a = 0; a <= maxA; a++)
            {
                int maxPow = factor[a].Max();
                for (int j = 1; j <= maxPow; j++)
                {
                    LCM *= a;
                    LCM %= mod;
                }
            }

            long B = 0;
            for (int i = 0; i < N; i++)
            {
                B += LCM * my.ModInv(A[i]);
                B %= mod;
            }
            WriteLine(B.ToString());
            ReadKey();
        }
 
        Dictionary<long, long> GetSieve(long n)
        {
            long[] prime = new long[n + 1];
            prime[0] = 1;
            prime[1] = 1;
            for (long i = 2; i <= (long)Sqrt(n); i++)
            {
                for (long j = i; j <= n; j += i)
                {
                    if (prime[j] == 0) prime[j] = i;
                }
            }
 
            Dictionary<long, long> ret = new Dictionary<long, long>();
            for (int i = 0; i <= n; i++)
            {
                if (prime[i] == 0) prime[i] = i;
                ret.Add(i, prime[i]);
            }
            return ret;
        }
 
        // a^n mod を計算する
        long ModPow(long a, long n, long mod) {
            long res = 1;
            while (n > 0) {
                if (n % 2 > 0) res = res * a % mod;
                a = a * a % mod;
                n >>= 1;
            }
            return res;
        }
 
        // a^{-1} mod を計算する
        long ModInv(long a) {
            long mod = (long)Pow(10, 9) + 7;
            return ModPow(a, mod - 2, mod);
        }
    }
}