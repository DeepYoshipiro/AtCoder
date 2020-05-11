using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC167
{
    class ABC167C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];
            var X = init[2];

            int[][] A = new int[N + 1][];
            int[] C = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                A[i] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                C[i] = A[i][0];
            }

            int result = int.MaxValue;
            for (int bit = 0; bit < (1<<N); bit++)
            {
                bool satisfy = true;
                int cost = 0;
                int[] improve = new int[M + 1];
                for (int i = 1; i <= N; i++)
                {
                    if ((bit & 1<<(i-1)) > 0)
                    {
                        cost += C[i]; 
                        for (int j = 1; j <= M; j++)
                        {
                            improve[j] += A[i][j];
                        }
                    }
                }

                if (cost >= result) continue;
                for (int j = 1; j <= M; j++)
                {
                    if (improve[j] < X)
                    {
                        satisfy = false;
                        break;
                    } 
                }

                if (satisfy)
                {
                    result = cost;
                }
            }

            if (result == int.MaxValue) result = -1;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
