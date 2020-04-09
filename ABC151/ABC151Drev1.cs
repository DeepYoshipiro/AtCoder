// Solution : BFS
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC151
{
    class ABC151Drev1
    {
        static int H;
        static int W;
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            H = init[0];
            W = init[1];

            char[][] S = new char[H][];
            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
            }

            int result = 0;

            int[] dH = {-1, 0, 0, 1};
            int[] dW = {0, -1, 1, 0};
            for (int start = 0; start < H * W; start++)
            {
                int startH = getH(start);
                int startW = getW(start);
                if (S[startH][startW].Equals('#'))
                {
                    continue;
                }

                int[][] distance = new int[H][];
                for (int i = 0; i < H; i++)
                {
                    distance[i] = new int[W];
                }

                Queue<int> point = new Queue<int>();
                point.Enqueue(start);
                while (point.Count > 0)
                {
                    int cur = point.Dequeue();
                    int curH = getH(cur);
                    int curW = getW(cur);
                    for (int j = 0; j < dH.Length; j++)
                    {
                        int nextH = curH + dH[j];
                        int nextW = curW + dW[j];

                        if (nextH < 0 || nextH >= H)
                            continue;
                        if (nextW < 0 || nextW >= W)
                            continue;
                        if (S[nextH][nextW].Equals('#'))
                            continue;
                        if (distance[nextH][nextW] > 0)
                            continue;

                        int destination = getPoint(nextH, nextW);
                        if (destination == start) continue;

                        point.Enqueue(destination);

                        distance[nextH][nextW] = distance[curH][curW] + 1;
                        if (distance[nextH][nextW] > result)
                            result = distance[nextH][nextW];
                    }
                }
            }
                    
            WriteLine(result.ToString());
            ReadKey();
        }

        static int getH(int point)
        {
            return point / W;
        }

        static int getW(int point)
        {
            return point % W;
        }

        static int getPoint(int h, int w)
        {
            return h * W + w; 
        }
    }
}
