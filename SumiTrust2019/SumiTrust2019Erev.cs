using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace SumiTrust2019
{
    class SumiTrust2019Erev
    {
        static void Main(string[] args)
        {
            long mod = (long)Pow(10, 9) + 7;           

            long N = long.Parse(ReadLine());
            long[] A = ReadLine().Split(' ')
                        .Select(n => long.Parse(n))
                        .ToArray();

            long[] testimony = new long[N + 1];
            testimony[0] = 3;
            long result = 1;
            for (int i = 0; i < N; i++)
            {
                result *= testimony[A[i]];
                result %= mod;
                testimony[A[i]]--;
                testimony[A[i] + 1]++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}