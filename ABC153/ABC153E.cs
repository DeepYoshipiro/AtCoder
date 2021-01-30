// Solution : DP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC153
{
    class ABC153E
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int N = init[1];

            var A = new int[N];
            var B = new int[N];
            for (int i = 0; i < N; i++)
            {
                int[] spellBook = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                A[i] = spellBook[0];
                B[i] = spellBook[1];
            }

            var dpMinMP = new long[H + 1]
                    .Select(v => long.MaxValue).ToArray();
            dpMinMP[H] = 0;

            for (int i = H; i > 0; i--)
            {
                if (dpMinMP[i] == long.MaxValue) continue;
                for (int j = 0; j < N; j++)
                {
                    int nextHP = i - A[j];
                    if (nextHP <= 0) nextHP = 0;
                    if (dpMinMP[i] + B[j] < dpMinMP[nextHP])
                    {
                        dpMinMP[nextHP] = dpMinMP[i] + B[j];
                    }
                }
            }
            WriteLine(dpMinMP[0].ToString());
            ReadKey();
        }
    }
}