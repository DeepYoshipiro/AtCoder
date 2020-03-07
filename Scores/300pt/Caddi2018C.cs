using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class Caddi2018C
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long N = init[0];
            long P = init[1];

            long[] d = PrimeFactors(P).ToArray();
            int conCnt = 0;
            long conNum = 0;
            long result = 1;
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == conNum)
                {
                    conCnt++;
                }
                else
                {
                    conNum = d[i];
                    conCnt = 1;
                }

                if (conCnt == N)
                {
                    result *= conNum;
                    conCnt = 0;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        internal static IEnumerable<long> PrimeFactors(long n)
        {
            long p = 2;
            long a = n;

            while (p * p <= n)
            {
                if (a % p == 0)
                {
                    a /= p;
                    yield return p;
                }
                else
                {
                    p++;
                }
            }
            if (a != 1) 
            {
                yield return a;
            }
        }
    }
}