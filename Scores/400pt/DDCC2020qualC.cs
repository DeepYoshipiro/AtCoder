using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class DDCC2020qualC
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];
            int K = init[2];

            char[][] s = new char[H][];
            int[][] a = new int[H][];
            for (int i = 0; i < H; i++)
            {
                s[i] = ReadLine().ToCharArray();
                a[i] = new int[W];
            }

            int lastAppearStrawberryRow = -1;
            int appearStrawberryRow = 0;
            int curNum = 0;
            for (int i = 0; i < H; i++)
            {
                curNum++;
                appearStrawberryRow = 0;
                for (int j = 0; j < W; j++)
                {
                    if (s[i][j].Equals('#'))
                    {
                        appearStrawberryRow++;
                        if (appearStrawberryRow >= 2)
                        {
                            curNum++;
                        }
                    }
                    a[i][j] = curNum;
                }
                if (appearStrawberryRow == 0)
                {
                    curNum--;
                    if (i == H - 1)
                    {
                        a[i] = a[lastAppearStrawberryRow];
                    } 
                    else
                    {
                        a[i] = a[i + 1];
                    }
                }
                else 
                {
                    lastAppearStrawberryRow = i;
                }                
            }

            for (int i = 0; i < H; i++)
            {
                StringBuilder result = new StringBuilder();
                for (int j = 0; j < W; j++)
                {
                    result.Append(a[i][j].ToString());
                    result.Append(" ");
                }
                WriteLine(result);
            }
            ReadLine();
        }
    }
}
