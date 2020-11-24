using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC108
{
    class ARC108A
    {
        static long S;
        static void Main(string[] args)
        {
            var my = new ARC108A();
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            S = init[0];
            var P = init[1];

            WriteLine(my.Divisor(P) ? "Yes" : "No");
            ReadKey();
        }

        internal bool Divisor(long N)
        {
            for (long i = 1; i * i <= N; i++)
            {
                if (N % i == 0 && i + (N / i) == S)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
