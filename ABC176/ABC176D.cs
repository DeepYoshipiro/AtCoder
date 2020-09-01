using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC176
{
    class ABC176D
    {
        static int H;
        static int W;

        static int[][] dist;
        static bool[][] searched;

        static Queue<int> WarpH = new Queue<int>();
        static Queue<int> WarpW = new Queue<int>();

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            H = init[0];
            W = init[1];

            var start = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var startH = start[0] - 1;
            var startW = start[1] - 1;

            var goal = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var goalH = goal[0] - 1;
            var goalW = goal[1] - 1;

            var S = new char[H][];
            dist = new int[H][];
            searched = new bool[H][];
            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
                dist[i] = new int[W];
                searched[i] = new bool[W];
                for (int j = 0; j < W; j++)
                {
                    if (S[i][j] == '.')
                    {
                        dist[i][j] = int.MaxValue;
                    }
                    else
                    {
                        dist[i][j] = -1;
                    }
                }
            }

            WarpH.Enqueue(startH);
            WarpW.Enqueue(startW);
            dist[startH][startW] = 0;

            while (WarpH.Count() > 0)
            {
                var warpToH = WarpH.Dequeue();
                var warpToW = WarpW.Dequeue();

                if (searched[warpToH][warpToW]) continue;

                var stepH = new Queue<int>();
                var stepW = new Queue<int>();
                stepH.Enqueue(warpToH);
                stepW.Enqueue(warpToW);

                while (stepH.Count() > 0)
                {
                    var curH = stepH.Dequeue();
                    var curW = stepW.Dequeue();

                    var curDist = dist[curH][curW];
                    searched[curH][curW] = true;
                    TeleportMark(curH, curW, -1);

                    int[] dH = {-1, 0, 0, 1};
                    int[] dW = {0, -1, 1, 0};

                    for (int k = 0; k < dH.Count(); k++)
                    {
                        var nextH = curH + dH[k];
                        var nextW = curW + dW[k];
                        if (StepSearch(curH + dH[k], curW + dW[k]))
                        {
                            dist[nextH][nextW] = curDist;
                            stepH.Enqueue(nextH);
                            stepW.Enqueue(nextW);
                            TeleportMark(nextH, nextW, k);
                        }
                    }
                }
            }

            if (dist[goalH][goalW] == int.MaxValue) 
            {
                dist[goalH][goalW] = -1;
            }

            WriteLine(dist[goalH][goalW].ToString());
            ReadKey();
        }

        static bool StepSearch(int curH, int curW)
        {
            if (curH < 0 || curH >= H) return false;
            if (curW < 0 || curW >= W) return false;

            if (searched[curH][curW]) return false;
            if (dist[curH][curW] < 0) return false;
            return true;
        }      

        static void TeleportMark(int curH, int curW, int mode)
        {
            switch (mode)
            {
                case -1:
                    for (int tH = -2; tH <= 2; tH++)
                    {
                        for (int tW = -2; tW <= 2; tW++)
                        {
                            checkTeleport(curH + tH, curW + tW, dist[curH][curW]);
                        }
                    }
                    break;
                case 0:
                    for (int tW = -2; tW <= 2; tW++)
                    {
                        checkTeleport(curH - 2, curW + tW, dist[curH][curW]);
                    }
                    break;
                case 1:
                    for (int tH = -2; tH <= 2; tH++)
                    {
                        checkTeleport(curH + tH, curW - 2, dist[curH][curW]);
                    }
                    break;
                case 2:
                    for (int tH = -2; tH <= 2; tH++)
                    {
                        checkTeleport(curH + tH, curW + 2, dist[curH][curW]);
                    }
                    break;
                case 3:
                    for (int tW = -2; tW <= 2; tW++)
                    {
                        checkTeleport(curH + 2, curW + tW, dist[curH][curW]);
                    }
                    break;
            }
        }

        static void checkTeleport(int curH, int curW, int curDist)
        {
            if (StepSearch(curH, curW))
            {
                if (dist[curH][curW] > curDist + 1)
                {
                    dist[curH][curW] = curDist + 1;
                    WarpH.Enqueue(curH);
                    WarpW.Enqueue(curW);
                }
            }                   
        }
    }
}
