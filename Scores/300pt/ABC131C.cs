using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC131C
    {
        static void Main(string[] args)
        {
            long[] input = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long A = input[0];
            long B = input[1];
            long C = input[2];
            long D = input[3];

            long F = B / C - (A - 1) / C;
            long G = B / D - (A - 1) / D;

            long LCM = ABC131C.LCM(C, D);
            long H = B / LCM - (A - 1) / LCM;

            long result = B - (A - 1) - (F + G) + H;
            WriteLine(result.ToString());
            ReadKey();
        }

        internal static long gcd(long c, long d)
        {
            long a = Max(c, d);
            long b = Min(c, d);
            long r = a;
            
            while (r != 0) {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        internal static long LCM(long a, long b)
        {
            long d = gcd(a, b);
            return a / d * b;
        }
    }
}