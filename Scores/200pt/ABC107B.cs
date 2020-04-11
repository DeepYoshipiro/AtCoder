using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC107B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];

            bool[] leftH = new bool[H];
            bool[] leftW = new bool[W];

            char[][] a = new char[H][];
            for (int h = 0; h < H; h++)
            {
                a[h] = ReadLine().ToCharArray();
                for (int w = 0; w < W; w++)
                {
                    if (a[h][w] == '#')
                    {
                        leftH[h] = true;
                        leftW[w] = true;
                    }
                }
            }

            for (int h = 0; h < H; h++)
            {
                bool writeRow = false;
                for (int w = 0; w < W; w++)
                {
                    if (leftH[h] && leftW[w])
                    {
                        Write(a[h][w]);
                        writeRow = true;
                    }
                }
                if (writeRow) WriteLine();
            }
            ReadKey();
        }
    }
}