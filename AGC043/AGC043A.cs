using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace AGC043
{
    class AGC043A
    {
        static char BLACK = '#';

        static void Main(string[] args)
        {

            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];

            int[][] dpChangeMin = new int[H][];
            char[][] s = new char[H][];
            for (int i = 0; i < H; i++)
            {
                s[i] = ReadLine().ToCharArray();
                dpChangeMin[i] = new int[W];
                for (int j = 0; j < W; j++)
                {
                    dpChangeMin[i][j] = int.MaxValue;
                }
            }

            dpChangeMin[0][0] = BlackBlock(s[0][0]);
            for (int i = 1; i < H; i++)
            {
                dpChangeMin[i][0]
                 = dpChangeMin[i - 1][0]
                    + (BlackBlock(s[i - 1][0]) == 1 ? 0 : BlackBlock(s[i][0]));
            }

            for (int j = 1; j < W; j++)
            {
                dpChangeMin[0][j]
                 = dpChangeMin[0][j - 1]
                   + (BlackBlock(s[0][j - 1]) == 1 ? 0 : BlackBlock(s[0][j]));
            }

            for (int i = 1; i < H; i++)
            {
                for (int j = 1; j < W; j++)
                {
                    int curBlackBlockH = BlackBlock(s[i - 1][j]);
                    int curBlackBlockW = BlackBlock(s[i][j - 1]);
                    dpChangeMin[i][j]
                     = Min(dpChangeMin[i][j], 
                         dpChangeMin[i - 1][j]
                          + (curBlackBlockH == 1 ? 0 : BlackBlock(s[i][j])));
                    dpChangeMin[i][j]
                     = Min(dpChangeMin[i][j],
                         dpChangeMin[i][j - 1]
                          + (curBlackBlockW == 1 ? 0 : BlackBlock(s[i][j])));
                }
            }
            WriteLine(dpChangeMin[H - 1][W - 1]);
            ReadLine();
        }

        static int BlackBlock(char s)
        {
            return s.Equals(BLACK) ? 1 : 0;
        }
    }
}
