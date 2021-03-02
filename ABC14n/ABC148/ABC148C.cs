using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC148
{
    class ABC148C
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long A = init[0];
            long B = init[1];

            long a = Max(A, B);
            long b = Min(A, B);
            long r = b;
            while (r > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            long gcd = a;
            long LCM = A / gcd * B;

            WriteLine(LCM.ToString());
            ReadKey();
        }
    }
}
