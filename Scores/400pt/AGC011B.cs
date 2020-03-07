using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class AGC011B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split()
                    .Select(m => int.Parse(m))
                    .OrderBy(m => m).ToArray();

            long[] sum = new long[N];
            sum[0] = a[0];

            int survivable = 0;
            for (int i = 1; i < N; i++)
            {
                sum[i] = sum[i - 1] + a[i];
                if (2 * sum[i - 1] < a[i])
                {
                    survivable = i;
                }
            }

            int result = N - survivable;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}