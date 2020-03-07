using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC100C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                while (a[i] % 2 == 0)
                {
                    result++;
                    a[i] /= 2;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}