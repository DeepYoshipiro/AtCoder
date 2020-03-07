using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace Advanced
{
    class ARC085E
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            long[] a = (new long[1]{0})
                .Concat(ReadLine().Split(' ').Select(n => long.Parse(n)))
                .ToArray();

            for (int i = N; i >= 1; i--)
            {
                int d = i;
                long partSum = 0;
                for (int j = d; j <= N; j += d)
                {
                    partSum += a[j];
                }
                if (partSum < 0)
                {
                    for (int j = d; j <= N; j += d)
                    {
                        a[j] = 0;
                    }
                }
            }

            WriteLine(a.Sum().ToString());
            ReadKey();
        }
    }
}
