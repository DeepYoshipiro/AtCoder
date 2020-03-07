using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC088D
    {
        static int H;
        static int W;
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            H = init[0];
            W = init[1];
            char[][] s = new char[H][];

            int[] dH = {-1, 0, 1, 0};
            int[] dW = {0, -1, 0, 1};

            int[][] step = new int[H][];
            int black = 0;
            for (int i = 0; i < H; i++)
            {
                s[i] = ReadLine().ToCharArray();
                for (int j = 0; j < W; j++)
                {
                    if (s[i][j].Equals('#')) black++;
                }
                step[i] = new int[W];
            }
            Queue<int> p = new Queue<int>(); 
            p.Enqueue(0);

            bool arrivedGoal = false;
            while (p.Count > 0)
            {
                int cur = p.Dequeue();
                int curH = getH(cur);
                int curW = getW(cur);

                if (curH == H - 1 && curW == W - 1)
                {
                    arrivedGoal = true;
                    break;
                }

                for (int dir = 0; dir < dH.Length; dir++)
                {
                    int nextH = curH + dH[dir];
                    int nextW = curW + dW[dir];

                    if (nextH < 0 || nextH >= H) continue;
                    if (nextW < 0 || nextW >= W) continue;
                    if (s[nextH][nextW].Equals('#')) continue;

                    if (nextH == 0 && nextW == 0) continue;
                    if (step[nextH][nextW] > 0) continue;

                    step[nextH][nextW] = step[curH][curW] + 1;
                    p.Enqueue(getPoint(nextH, nextW));
                }
            }

            int result = 0;
            if (arrivedGoal)
            {
                result = H * W - (step[H - 1][W - 1] + 1);
                result -= black;
            }
            else
            {
                result = -1;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        static int getPoint(int h, int w)
        {
            return h * W + w;
        }

        static int getH(int point)
        {
            return point / W;
        }

        static int getW(int point)
        {
            return point % W;
        }
    }
}
