using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class ABC144E
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long N = (long)init[0];
            long K = init[1];

            long[] A = ReadLine().Split(' ')
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToArray();
            long[] F = ReadLine().Split(' ')
                .Select(n => long.Parse(n))
                .OrderBy(n => n).ToArray();

            long upperTime = A.First() * F.Last();
            long lowerTime = 0;

            while (upperTime > lowerTime)
            {
                long needTime = (upperTime + lowerTime) / 2;
                long practice = 0;
                bool success = true;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] * F[i] > needTime)
                        practice += A[i] - needTime / F[i];
                    if (K < practice)
                    {
                        success = false;
                        lowerTime = needTime + 1;
                        break;
                    }
                }

                if (success)
                {
                    upperTime = needTime;
                }
            }

            WriteLine(upperTime.ToString());
            ReadKey();
        }
    }
}
