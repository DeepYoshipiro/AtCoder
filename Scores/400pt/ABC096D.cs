using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC096D
    {
        static void Main(string[] args)
        {
            ABC096D my = new ABC096D();
            int N = int.Parse(ReadLine());

            List<int> primes = my.GetPrimes_Mod5_Equal2(55555);

            for (int i = 0; i < N; i++)
            {
                Write(primes[i].ToString() + " ");
            }
            WriteLine();
            ReadKey();
        }

        internal List<int> GetPrimes_Mod5_Equal2(int maxNum)
        {
            int[] sieve = Enumerable.Range(0, maxNum + 1).ToArray();
            sieve[1] = 0;  // 0 : 素数ではない
            int squareroot = (int)Math.Sqrt(maxNum);
            for (int i = 2; i <= squareroot; i++) {
                if (sieve[i] <= 0)
                    continue;
                for (int n = i * 2; n <= maxNum; n += i)
                    sieve[n] = 0;
            }

            return sieve.Where(n => n > 0 && n % 5 == 2).ToList();
        }
    }
}