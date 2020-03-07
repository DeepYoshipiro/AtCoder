using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC152
{
    class ABC152E
    {
        static void Main(string[] args)
        {
            ABC152E my = new ABC152E();
            int N = int.Parse(ReadLine());
            long[] A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();

            long LCM = A[0];
            for (int i = 1; i < N; i++)
            {
                long gcd = my.gcd(LCM, A[i]);
                LCM = LCM / gcd * A[i];
            }

            long result = 0;
            for (int i = 0; i < N; i++)
            {
                result += LCM / A[i];
                result %= 1000000007;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        internal long gcd(long m, long n)
        {
            //aとbの最大公約数を求める。
            //ユークリッド互除法の実施
            long a = Max(m, n);
            long b = Min(m, n);
            long r = a;

            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a;
        }
    }
}