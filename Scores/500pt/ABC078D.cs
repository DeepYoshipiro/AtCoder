using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class ABC078D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int Z = init[1];
            int W = init[2];

            int[] a = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            
            if (N == 1)
            {
                WriteLine(Abs(a[0] - W).ToString());
            }
            else
            {
                WriteLine(
                    Max(Abs(a[N - 1] - W), Abs(a[N - 2] - a[N - 1]))
                    .ToString()
                );
            }
            
            ReadKey();
        }
    }
}
