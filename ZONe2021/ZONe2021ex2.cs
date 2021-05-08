using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ZONe2021
{
    class ZONe2021ex2
    {
        static void Main(string[] args)
        {
            var dm = new DiscreteMath();
            var sieve = dm.Sieve(999); 

            int size = 20;
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                var info = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();

                for (int j = 0; j < size; j++)
                {
                    if (sieve[info[j]]) result++;
                }
            }

            WriteLine(result.ToString());
            ReadLine();
        }

        class DiscreteMath
        {
            internal bool[] Sieve(long N)
            {
                var prime = new bool[N + 1].Select(v => true).ToArray();
                prime[0] = false;
                prime[1] = false;

                for (long i = 2; i * i <= N; i++)
                {
                    if (!prime[i]) continue;
                    for (long j = 2 * i; j <= N; j += i)
                    {
                        prime[j] = false;
                    }
                }
                return prime;
            }
        }
    }
}
