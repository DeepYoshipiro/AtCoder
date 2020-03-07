using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC006B
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());

            long[] a = new long[Max(n + 1, 4)];

            a[1] = 0;
            a[2] = 0;
            a[3] = 1;
            for (int i = 4; i <= n; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    a[i] += a[i - j];
                    a[i] %= 10007;
                }
            }

            WriteLine(a[n].ToString());
            ReadKey();
        }
    }
}