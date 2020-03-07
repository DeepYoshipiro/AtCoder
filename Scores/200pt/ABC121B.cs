using System;
using System.Linq;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC121B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];
            int C = init[2];

            int[] B = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                int[] A = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

                int productSum = 0;
                for (int j = 0; j < M; j++)
                {
                    productSum += A[j] * B[j];
                }
                productSum += C;
                if (productSum > 0) result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}