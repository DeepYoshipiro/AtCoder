using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC149
{
    class ABC149C
    {
        static void Main(string[] args)
        {
            int X = int.Parse(ReadLine());

            int result = Primes(2 * X, X);
            WriteLine(result.ToString());
            ReadKey();
        }

        static int Primes(int maxnum, int X) {
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
