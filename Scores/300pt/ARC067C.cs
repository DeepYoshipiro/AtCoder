using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC067C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            List<int> P = new List<int>();
            for (int i = 2; i <= N; i++)
            {
                P.AddRange(PrimeFactors(i).ToList());
            }

            long result = 1;
            for (int i = 2; i <= N; i++)
            {
                result *= P.Where(p => p == i).ToArray().Count() + 1;
                result %= (long)(Pow(10, 9) + 7);
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        internal static IEnumerable<int> PrimeFactors(int n)
        {
            int i = 2;
            int tmp = n;

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
                yield return tmp;
            }
        }
    }
}