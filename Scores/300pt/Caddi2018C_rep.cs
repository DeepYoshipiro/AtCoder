using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class Caddi2018C_rep
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long N = init[0];
            long P = init[1];

            long result = 1;
            for (long i = 2; i <= Sqrt(P + 1); i++)
            {
                int divisible = 0;
                while (P % i == 0)
                {
                    divisible++;
                    P /= i;
                    if (divisible == N)
                    {
                        result *= i;
                        divisible = 0;
                    }
                }
            }

            if (N == 1) result = init[1];
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}