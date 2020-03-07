using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC066C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int[] b = new int[N];

            int j = 0;
            for (int i = N - 1; i >= 0; i -= 2)
            {
                b[j] = a[i];
                j++;
            }

            for (int i = N % 2; i < N; i += 2)
            {
                b[j] = a[i];
                j++;
            }

            for (int i = 0; i < N; i++)
            {
                Write(b[i].ToString() + " ");
            }

            ReadKey();
        }
    }
}