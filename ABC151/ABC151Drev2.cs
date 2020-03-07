using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC151
{
    // BFS Template
    internal class Point
    {
        int h;
        int w;

        public Point(int _h, int _w)
        {
            h = _h;
            w = _w;
        }

        public int GetH()
        {
            return h;
        }

        public int GetW()
        {
            return w;
        }
    }
    class ABC151Drev2
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];

            char[][] S = new char[H][];
            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
            }

            int result = 0;

            int[] dH = {-1, 0, 0, 1};
            int[] dW = {0, -1, 1, 0};
            for (int startH = 0; startH < H; startH++)
            {
                for (int startW = 0; startW < W; startW++)
                {
                    if (S[startH][startW].Equals('#'))
                    {
                        continue;
                    }

                    int[][] distance = new int[H][];
                    for (int i = 0; i < H; i++)
                    {
                        distance[i] = new int[W];
                    }

                    Queue<Point> point = new Queue<Point>();
                    point.Enqueue(new Point(startH, startW));
                    while (point.Count > 0)
                    {
                        Point cur = point.Dequeue();
                        int curH = cur.GetH();
                        int curW = cur.GetW();
                        for (int j = 0; j < dH.Length; j++)
                        {
                            int nextH = curH + dH[j];
                            int nextW = curW + dW[j];

                            // ＊いしのなかにいる！＊ は、ダメ
                            if (nextH < 0 || nextH >= H)
                                continue;
                            if (nextW < 0 || nextW >= W)
                                continue;
                            if (S[nextH][nextW].Equals('#'))
                                continue;

                            if (nextH == startH && nextW == startW) 
                                continue;
                            if (distance[nextH][nextW] > 0)
                                continue;

                            point.Enqueue(new Point(nextH, nextW));

                            distance[nextH][nextW] = distance[curH][curW] + 1;
                            if (distance[nextH][nextW] > result)
                                result = distance[nextH][nextW];
                        }
                    }
                }
            }
                    
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
