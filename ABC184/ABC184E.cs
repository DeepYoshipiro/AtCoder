using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC184
{
    class ABC184E
    {
        internal class Pos
        {
            internal int H{get; set;}
            internal int W{get; set;}

            internal Pos(int h, int w)
            {
                H = h;
                W = w;
            }
        }

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];

            var A = new char[H][];
            var S = new Pos(-1, -1);
            var G = new Pos(-1, -1);
            var teleporter = new List<Pos>['z' - 'a' + 1]
                .Select(v => new List<Pos>()).ToArray();
            for (int i = 0; i < H; i++)
            {
                A[i] = ReadLine().ToCharArray();
                for (int j = 0; j < W; j++)
                {
                    switch (A[i][j])
                    {
                        case '.':
                        case '#':
                            break;
                        case 'S':
                            S.H = i;
                            S.W = j;
                            break;
                        case 'G':
                            G.H = i;
                            G.W = j;
                            break;
                        default:
                            teleporter[A[i][j] - 'a'].Add(new Pos(i, j));
                            break;
                    }
                }
            }

            // var searched = new bool[H][]
            //     .Select(v => new bool[W]).ToArray();

            var visitTime = new int[H][]
                .Select(v => Enumerable.Repeat(-1, W).ToArray()).ToArray();

            visitTime[S.H][S.W] = 0;
            var que = new Queue<Pos>();
            que.Enqueue(new Pos(S.H, S.W));

            var dh = new int[4]{0, -1, 1, 0};
            var dw = new int[4]{-1, 0, 0, 1};
            while (que.Count() > 0)
            {
                var cur = que.Dequeue();
                // if (searched[cur.H][cur.W]) continue;
                // searched[cur.H][cur.W] = true;
                if (A[cur.H][cur.W] >= 'a' && A[cur.H][cur.W] <= 'z')
                {
                    foreach (Pos to in teleporter[A[cur.H][cur.W] - 'a'])
                    {
                        if (visitTime[to.H][to.W] >= 0) continue;
                        visitTime[to.H][to.W] = visitTime[cur.H][cur.W] + 1;
                        que.Enqueue(new Pos(to.H, to.W));
                    }
                    teleporter[A[cur.H][cur.W] - 'a'].Clear();
                }
                for (int move = 0; move < 4; move++)
                {
                    var nextH = cur.H + dh[move];
                    var nextW = cur.W + dw[move];
                    if (nextH < 0 || nextH >= H) continue;
                    if (nextW < 0 || nextW >= W) continue;
                    if (A[nextH][nextW] == '#') continue;
                    if (visitTime[nextH][nextW] >= 0) continue;
                    visitTime[nextH][nextW] = visitTime[cur.H][cur.W] + 1;
                    if (A[nextH][nextW] == 'G') break;
                    que.Enqueue(new Pos(nextH, nextW));
                }
            }
            WriteLine(visitTime[G.H][G.W]);
            ReadKey();
        }
    }
}
