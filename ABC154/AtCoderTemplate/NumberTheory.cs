using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC1NN
{
    class ABC1NN_NumberTheory
    {
        static void Main(string[] args)
        {
            //long gcd = gcd(m, n);
            //long LCM = A / gcd * B;         

            //最大公約数の約数を素因数分解して因数だけ取り出す
            //long result = PrimeFactors(a).Distinct().ToList().Count + 1;
        }
    }

    class NumberTheory
    {   
        internal long gcd(long m, long n)
        {
            //aとbの最大公約数を求める。
            //ユークリッド互除法の実施
            long a = Max(m, n);
            long b = Min(m, n);
            long r = a;

            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        internal static IEnumerable<long> PrimeFactors(long n)
        {
            long i = 2;
            long tmp = n;

            while (i * i <= n)
            {
                if (tmp % i == 0)
                {
                    tmp /= i;
                    yield return i;
                }
                else
                {
                    i++;
                }
            }
            if (tmp != 1) 
            {
                yield return tmp; //最後の素数も返す
            }
        }

        internal int Primes(int maxnum, int X)
        {
            int[] sieve = Enumerable.Range(0, maxnum + 1).ToArray();
            sieve[1] = 0;  // 0 : 素数ではない
            int squareroot = (int)Math.Sqrt(maxnum);
            for (int i = 2; i <= squareroot; i++) {
                if (sieve[i] <= 0)
                    continue;
                for (int n = i * 2; n <= maxnum; n += i)
                    sieve[n] = 0;
            }
            return sieve.Where(n => n >= X).First();
        }
    }
}
