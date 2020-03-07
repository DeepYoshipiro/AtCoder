using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC109D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];

            int[][] a = new int[H][];
            List<int> fromY = new List<int>();
            List<int> fromX = new List<int>();
            List<int> toY = new List<int>();
            List<int> toX = new List<int>();

            int N = 0;
            for (int i = 0; i < H; i++)
            {
                a[i] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                for (int j = 0; j < W - 1; j++)
                {
                    if (a[i][j] % 2 != 0)
                    {
                        a[i][j]--;
                        a[i][j + 1]++;
                        fromY.Add(i + 1);
                        fromX.Add(j + 1);
                        toY.Add(i + 1);
                        toX.Add(j + 2);
                        N++;
                    }
                }
            }

            for (int i = 0; i < H - 1; i++)
            {
                if (a[i][W - 1] % 2 != 0)
                {
                    a[i][W - 1]--;
                    a[i + 1][W - 1]++;
                    fromY.Add(i + 1);
                    fromX.Add(W);
                    toY.Add(i + 2);
                    toX.Add(W);
                    N++;
                }
            }

            WriteLine(N.ToString());

            for (int k = 0; k < N; k++)
            {
                WriteLine("{0} {1} {2} {3}", fromY[k], fromX[k], toY[k], toX[k]);
            }
            ReadKey();
        }
    }
}
