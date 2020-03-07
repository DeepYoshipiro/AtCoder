using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC133C
    {
        static void Main(string[] args)
        {
            const int DIV_NUM = 2019;
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long L = init[0];
            long R = Min(init[1], L + DIV_NUM);

            long result = DIV_NUM - 1;
            for (long m = L; m < R; m++)
            {
                for (long n = L + 1; n <= R; n++)
                {
                    long mn = ((m % DIV_NUM) * (n % DIV_NUM)) % DIV_NUM;
                    if (mn < result) result = mn;
                    if (mn == 0) break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}