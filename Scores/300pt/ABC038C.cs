using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC038C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            long[] b = new long[N];
            b[0] = 1;
            int cur = 1;
            for (int i = 1; i < N; i++)
            {
                if (a[i - 1] >= a[i])
                {
                    cur = 0;
                }
                cur++;
                b[i] = cur;
            }

            WriteLine(b.Sum().ToString());
            ReadKey();
        }
    }
}