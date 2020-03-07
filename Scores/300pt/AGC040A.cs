using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;


namespace AGC040
{
    class AGC040A
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToArray();
            int N = S.Length;

            int[] a = new int[N + 1];
            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                switch (S[i])
                {
                    case '<':
                        a[i + 1] = a[i] + 1;
                        break;
                    case '>':
                        a[i + 1] = a[i] - 1;
                        break;
                }
                sum += a[i + 1];
            }
            sum += Abs(a.Min()) * N;

            WriteLine(sum.ToString());
            ReadKey();
        }
    }
}
