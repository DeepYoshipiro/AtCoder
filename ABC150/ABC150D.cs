using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC150
{
    class ABC150D
    {
        static void Main(string[] args)
        {
            ABC150D me = new ABC150D();
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            int N = (int)init[0];
            long M = init[1];

            long[] a = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long LCM = a[0] / 2;
            for (int i = 1; i < N; i++)
            {
                LCM = me.getLCM(LCM, a[i] / 2);
            }

            long result = (M / LCM) - (M / (2 * LCM));

            WriteLine(result.ToString());
            ReadKey();
        }

        internal long getLCM(long a, long b)
        {
            return a / getGcd(a, b) * b;
        }

        internal long getGcd(long m, long n)
        {
            long a = Max(m, n);
            long b = Min(m, n);
            long r = b;

            while (r > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a;
        }
    }
}