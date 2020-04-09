using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC160
{
    class ABC160Crev
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int K = init[0];
            int N = init[1];

            int[] A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            int[] dist = new int[N];
            for (int i = 0; i < N - 1; i++)
            {
                dist[i] = A[i + 1] - A[i];
            }
            dist[N - 1] = (A[0] + K) - A[N - 1];
            
            int result = K - dist.Max();
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}