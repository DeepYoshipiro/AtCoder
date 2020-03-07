using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC081C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int[] appearCnt = new int[N + 1];

            for (int i = 0; i < N; i++)
            {
                appearCnt[A[i]]++;
            }

            Array.Sort(appearCnt);
            Array.Reverse(appearCnt);

            int leftElementCnt = 0;
            for (int i = 0; i < K; i++)
            {
                leftElementCnt += appearCnt[i];
            }

            WriteLine((N - leftElementCnt).ToString());
            ReadKey();
        }
    }
}