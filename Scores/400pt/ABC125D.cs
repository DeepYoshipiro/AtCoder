using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC125D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            long[] A = new long[]{0}
                .Concat(ReadLine().Split()
                .Select(m => long.Parse(m)))
                .ToArray();

            for (int i = 1; i <= N - 1; i++)
            {                
                if (A[i] + A[i + 1] < 0)
                {
                    A[i] *= -1;
                    A[i + 1] *= -1;
                }
            }

            if (N > 2 && A[N - 2] + A[N] < 0)
            {
                A[N - 2] *= -1;
                A[N] *= -1;
            }
            
            WriteLine(A.Sum().ToString());
            ReadKey();
        }
    }
}