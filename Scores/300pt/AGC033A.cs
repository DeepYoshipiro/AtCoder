using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC033A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];

            char[][] A = new char[H][];
            int[][] step = new int[H][];
            var nextVisit = new Queue<Position>();
            var neverVisited = H * W;

            for (int h = 0; h < H; h++)
            {
                A[h] = ReadLine().ToCharArray();
                step[h] = new int[W];
                for (int w = 0; w < W; w++)
                {
                    step[h][w] = -1;
                    if (A[h][w].Equals('#'))
                    {
                        step[h][w] = 0;
                        nextVisit.Enqueue(new Position(h, w));
                        neverVisited--;
                    }
                }
            }

            int maxStep = 0;
            int[] dH = new int[]{-1, 0, 0, 1};
            int[] dW = new int[]{0, -1, 1, 0};
            while (nextVisit.Count > 0 && neverVisited > 0)
            {
                var curPos = nextVisit.Dequeue();
                int curStep = step[curPos.H][curPos.W];

                for (int i = 0; i < dH.Count(); i++)
                {
                    int nextH = curPos.H + dH[i];
                    int nextW = curPos.W + dW[i];

                    if (nextH < 0 || nextH >= H) continue;
                    if (nextW < 0 || nextW >= W) continue;

                    int nextStep = step[nextH][nextW];
                    if (nextStep < 0)
                    {
                        step[nextH][nextW] = curStep + 1;
                        neverVisited--;
                        if (curStep + 1 > maxStep) maxStep = curStep + 1;
                        nextVisit.Enqueue(new Position(nextH, nextW));
                    }
                    else
                    {
                        step[nextH][nextW] = Min(step[nextH][nextW], nextStep + 1);
                    } 
                }
            }

            WriteLine(maxStep.ToString());
            ReadKey();
        }

        class Position
        {
            internal int H {get;}
            internal int W {get;}

            internal Position(int h, int w)
            {
                H = h;
                W = w;
            }
        }
    }
}