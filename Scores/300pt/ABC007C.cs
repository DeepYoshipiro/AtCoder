// Solution : BFS
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC007C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int R = init[0];
            int C = init[1];

            int[] start = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int sy = start[0] - 1;
            int sx = start[1] - 1;

            int[] goal = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int gy = goal[0] - 1;
            int gx = goal[1] - 1;

            int[][] step = new int[R][];
            for (int i = 0; i < R; i++)
            {
                char[] c = ReadLine().ToCharArray();
                step[i] = new int[C];
                for (int j = 0; j < C; j++)
                {
                    if (c[j].Equals('#'))
                    {
                        step[i][j] = -1;
                    }
                }
            }

            Queue<int> y = new Queue<int>();
            Queue<int> x = new Queue<int>();
            y.Enqueue(sy);
            x.Enqueue(sx);

            while (y.Count > 0)
            {
                int curY = y.Dequeue();
                int curX = x.Dequeue();

                if (curY == gy && curX == gx)
                {
                    break;
                }

                int[] dy = {-1, 0, 0, 1};
                int[] dx = {0, -1, 1, 0};

                for (int d = 0; d < dy.Length; d++)
                {
                    int nextY = curY + dy[d];
                    int nextX = curX + dx[d];

                    if (nextY == sy && nextX == sx) continue;
                    if (step[nextY][nextX] != 0) continue;

                    step[nextY][nextX] = step[curY][curX] + 1;
                    y.Enqueue(nextY);
                    x.Enqueue(nextX);
                }
            }

            WriteLine(step[gy][gx].ToString());
            ReadKey();
        }
    }
}