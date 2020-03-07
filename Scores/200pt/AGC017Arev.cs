using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class AGC017Arev
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int P = init[1];

            int[] A = new int[]{0}
                .Concat(ReadLine().Split(' ')
                .Select(n => int.Parse(n))).ToArray();

            long[][] dpMod = new long[2][];
            dpMod[0] = new long[N + 1];
            dpMod[1] = new long[N + 1];

            dpMod[0][0] = 1;
            for (int i = 1; i <= N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    dpMod[0][i] = dpMod[0][i - 1] * 2;
                    dpMod[1][i] = dpMod[1][i - 1] * 2;
                }
                else
                {
                    dpMod[0][i] = dpMod[0][i - 1] + dpMod[1][i - 1];
                    dpMod[1][i] = dpMod[1][i - 1] + dpMod[0][i - 1];
                }
            }

            WriteLine(dpMod[P][N].ToString());
            ReadKey();
        }
    }
}
