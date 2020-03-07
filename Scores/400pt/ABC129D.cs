using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC129D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];
            char[][] S = new char[H][];
            int[][] lightHeight = new int[H][];
            int[][] lightWidth = new int[H][];
            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
                lightHeight[i] = new int[W];
                lightWidth[i] = new int[W];
            }

            int maxLight = 0;
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    if (S[h][w].Equals('#')) continue;
                    if (h > 0 && lightHeight[h - 1][w] > 0)
                    {
                        lightHeight[h][w] = lightHeight[h - 1][w];
                    }
                    else{
                        for (int down = h; down < H; down++)
                        {
                            if (S[down][w].Equals('#')) break;
                            lightHeight[h][w]++;
                        }
                    }

                    if (w > 0 && lightWidth[h][w - 1] > 0)
                    {
                        lightWidth[h][w] = lightWidth[h][w - 1];
                    }
                    else
                    {
                        for (int right = w; right < W; right++)
                        {
                            if (S[h][right].Equals('#')) break;
                            lightWidth[h][w]++;
                        }
                    }

                    int lightGrid = lightHeight[h][w] + lightWidth[h][w] - 1;
                    if (maxLight < lightGrid) maxLight = lightGrid;
                }
            }

            WriteLine(maxLight.ToString());
            ReadKey();
        }
    }
}