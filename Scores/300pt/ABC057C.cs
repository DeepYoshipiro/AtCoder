using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC057C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(ReadLine());
            long maxA = 1;
            long minB = N;
            for (long a = (long)Sqrt(N); a >= 1; a--)
            {
                if (N % a == 0)
                {
                    maxA = a;
                    minB = N / a;
                    break;
                }
            }

            long digit = (long)Log10(minB) + 1;
            WriteLine(digit.ToString());
            ReadKey();
        }
    }
}