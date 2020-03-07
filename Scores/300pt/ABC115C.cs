using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC115C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            int[] h = new int[N];
            for (int i = 0; i < N; i++)
            {
                h[i] = int.Parse(ReadLine());
            }
            Array.Sort(h);
            Array.Reverse(h);

            int minDiff = int.MaxValue;
            for (int i = 0; i <= N - K; i++)
            {
                int diff = h[i] - h[i + K - 1];
                if (diff < minDiff) minDiff = diff;
            }

            WriteLine(minDiff.ToString());
            ReadKey();
        }
    }
}