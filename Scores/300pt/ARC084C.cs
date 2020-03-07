using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC084C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderBy(n => n).ToArray();
            int[] B = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderBy(n => n).ToArray();
            int[] C = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderBy(n => n).ToArray();

            long[] combBC = new long[N];
            int c = 0;
            for (int b = 0; b < N; b++)
            {
                while (c < N && B[b] >= C[c])
                {
                    c++;
                }
                combBC[b] = N - c;
            }
            for (int b = N - 2; b >= 0; b--)
            {
                combBC[b] += combBC[b + 1];
            }

            long result = 0;
            int bc = 0;
            for (int a = 0; a < N; a++)
            {
                while (bc < N && A[a] >= B[bc])
                {
                    bc++;
                }
                if (bc >= N) break;
                result += combBC[bc];
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
          