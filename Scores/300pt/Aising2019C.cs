using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class Aising2019C
    {
        static void Main(string[] args)
        {
            // BFS
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];

            var S = new char[H][];
            var grp = new int[H][];
            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
                grp[i] = Enumerable.Repeat<int>(-1, W).ToArray();
            }

            var grpBlackCnt = new int[H * W];

            var grpCnt = -1;
            var dH = new int[]{-1, 0, 0, 1};
            var dW = new int[]{0, -1, 1, 0};
            var parentGrp = new Dictionary<int, int>();
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (S[i][j] != '#') continue;
                    if (grp[i][j] >= 0) continue;

                    // int curGrp = grp[i][j];
                    // if (curGrp < 0) curGrp = ++grpCnt;
                    grpCnt++;

                    var que = new Queue<Tuple<int,int>>();
                    que.Enqueue(new Tuple<int, int>(i, j));
                    while (que.Count > 0)
                    {
                        var curPos = que.Dequeue();
                        int curH = curPos.Item1;
                        int curW = curPos.Item2; 

                        if (grp[curH][curW] >= 0) continue;
                        grp[curH][curW] = grpCnt;

                        char nextChr = 
                            (S[curH][curW] == '#' ? '.' : '#');

                        for (int k = 0; k < dH.Length; k++)
                        {
                            int nextH = curH + dH[k];
                            if (nextH < 0 || nextH >= H) continue;

                            int nextW = curW + dW[k];
                            if (nextW < 0 || nextW >= W) continue;

                            // if (Abs(nextH - i) + Abs(nextW - j) > 2) continue;

                            if (S[nextH][nextW] == nextChr)
                            {
                                if (grp[nextH][nextW] < 0)
                                {
                                    que.Enqueue(new Tuple<int, int>(nextH, nextW));
                                }
                                // else if (grp[curH][curW] != grp[nextH][nextW])
                                // {
                                //     dictGrp.Add(grp[curH][curW], grp[nextH][nextW]);
                                // }

                            }
                        }
                    }
                }
            }

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (S[i][j] == '#')
                    {
                        grpBlackCnt[grp[i][j]]++;
                    }
                }
            }

            long result = 0;
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (S[i][j] == '.' && grp[i][j] >= 0)
                    {
                        result += grpBlackCnt[grp[i][j]];
                    }
                }
            }
            
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}