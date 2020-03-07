using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;


namespace _300pt
{
    class ABC134C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(ReadLine());
            }

            int[] B = A.OrderByDescending(n => n).ToArray();
            int max = B[0];
            int secondMax = B[1];

            for (int i = 0; i < N; i++)
            {
                if (A[i] == max)
                    WriteLine(secondMax.ToString());
                else
                    WriteLine(max.ToString());
            }
            ReadKey();
        }
    }
}