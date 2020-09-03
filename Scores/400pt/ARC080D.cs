using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ARC080D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];

            int N = int.Parse(ReadLine());

            int[] a = (new int[]{0})
                    .Concat(ReadLine().Split()
                        .Select(n => int.Parse(n))).ToArray();
            for (int i = 1; i <= N; i++)
            {
                a[i] += a[i - 1];
            }

            int[][] result = new int[H][];
            for (int i = 0; i < H; i++)
            {
                result[i] = new int[W];
            }

            int colored = 0;
            int curH = 0;
            int curW = 0;
            int curNum = 1;
            int curOri = 1;
            while (++colored <= H * W)
            {
                if (colored > a[curNum]) curNum++;
                result[curH][curW] = curNum;
                if ((curOri == 1 && curW == W - 1)
                    || (curOri == -1 && curW == 0))
                {
                    curH++;
                    curOri *= -1;
                }
                else
                {
                    curW += curOri;
                }
            }

            for (int h = 0; h < H; h++)
            {
                StringBuilder row = new StringBuilder();
                for (int w = 0; w < W; w++)
                {
                    row.Append(result[h][w].ToString());
                    row.Append(" ");
                }
                WriteLine(row.ToString().PadRight(' '));
            }
            ReadKey();
        }
    }
}
