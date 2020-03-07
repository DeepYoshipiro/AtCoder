using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC096C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];

            char[][] s = new char[H][];
            for (int i = 0; i < H; i++)
            {
                s[i] = ReadLine().ToCharArray();
            }

            int[] dh = { 0, 0, -1, 1 };
            int[] dw = { -1, 1, 0, 0 };
            bool result = true;
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    if (s[h][w].Equals('.')) continue;
                    bool cell = false;
                    for (int j = 0; j < dh.Length; j++)
                    {
                        if (h + dh[j] < 0 || h + dh[j] >= H
                            || w + dw[j] < 0 || w + dw[j] >= W)
                            continue;
                        if (s[h + dh[j]][w + dw[j]].Equals('#'))
                        {
                            cell = true;
                            break;
                        }
                    }
                    result &= cell;
                    if (!result) break;
                }
                if (!result) break;
            }
 
            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}