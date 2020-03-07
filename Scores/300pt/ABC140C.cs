using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC140C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[] B = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int[] supA0 = new int[B.Length + 1];
            int[] supA1 = new int[B.Length + 1];

            for (int i = 0; i < N - 1; i++)
            {
                supA0[i] = B[i];
            }
            supA0[N - 1] = B[N - 2];

            supA1[0] = B[0];
            for (int i = 0; i < N - 1; i++)
            {
                supA1[i + 1] = B[i];
            }

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                result += Min(supA0[i], supA1[i]);
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
