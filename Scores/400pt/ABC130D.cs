using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC130D
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long N = init[0];
            long K = init[1];

            long[] a = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();

            long sum = 0;
            long subtractTerm = 0;
            long result = 0;
            for (int i = 0; i < N; i++)
            {
                sum += a[i];
                while (sum >= K)
                {
                    result += N - i;
                    sum -= a[subtractTerm];
                    subtractTerm++;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}