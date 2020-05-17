using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC165
{

    class ABC165C
    {
        static int N;
        static int M;
        static int Q;
        static int[][] query;

        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            N = init[0];
            M = init[1];
            Q = init[2];

            query = new int[Q][];
            for (int q = 0; q < Q; q++)
            {
                query[q] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            }

            var A = new List<int>();
            long result = DFS(A, 1);

            WriteLine(result.ToString());
            ReadKey();
        }

        static long DFS(List<int> A, int Ai)
        {
            long result = 0;
            if (A.Count() == N)
            {
                long score = 0;
                for (int q = 0; q < Q; q++)
                {
                    int a = query[q][0];
                    int b = query[q][1];
                    int c = query[q][2];
                    int d = query[q][3];

                    if (A[b - 1] - A[a - 1] == c)
                    {
                        score += d;
                    }
                }
                return score;
            }

            for (int i = Ai; i <= M; i++)
            {
                A.Add(i);
                result = Max(DFS(A, i), result);
                A.RemoveAt(A.Count() - 1);
            }
            return result;
        }
    }
}
