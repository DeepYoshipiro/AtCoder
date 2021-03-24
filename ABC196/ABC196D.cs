using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC196
{
    class ABC196D
    {
        // class LayTatami
        // {
        //     int[][] layOut{get;set;}
        //     int A{get; set;}

        //     LayTatami(int H, int W)
        //     {
        //         layOut = new int[H][]
        //             .Select(v => new int[W]).ToArray();
        //     }
        // }
        static internal int H;
        static internal int W;

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            H = init[0];
            W = init[1];
            var A = init[2];
            var B = init[3];

            var Tatami = new int[H][]
                    .Select(v => new int[W]).ToArray();
            var result = DFS(0, 0, A, B, Tatami);

            WriteLine(result.ToString());
            ReadKey();
        }

        static int DFS(int curH, int curW, int A, int B, int[][] Tatami)
        {
            if (curH >= H && curW >= W && A == 0 && B == 0) return 1;
            if (curH >= H || curW >= W) return 0;
            if (A == 0 && B == 0) return 0;
            int result = 0;
            var newTatami = (int[][])Tatami.Clone();
            if (B > 0 && Tatami[curH][curW] == 0)
            {
                newTatami[curH][curW] = 1;
                result += DFS(curH + 1, curW, A, B - 1, newTatami);
                result += DFS(curH, curW + 1, A, B - 1, newTatami);
                newTatami[curH][curW] = 0;
            }
            if (A > 0)
            {
                if (curH < H - 1 && Tatami[curH + 1][curW] == 0)
                {
                    newTatami[curH][curW] = 2;
                    newTatami[curH + 1][curW] = 2;
                    result += DFS(curH, curW + 1, A - 1, B, newTatami);
                    result += DFS(curH + 1, curW + 1, A - 1, B, newTatami);
                    result += DFS(curH + 2, curW, A - 1, B, newTatami);
                    newTatami[curH][curW] = 0;
                    newTatami[curH + 1][curW] = 0;
                }

                if (curW < W - 1 && Tatami[curH][curW + 1] == 0)
                {
                    newTatami[curH][curW] = 3;
                    newTatami[curH][curW + 1] = 3;
                    result += DFS(curH, curW, A - 1, B, newTatami);
                    result += DFS(curH, curW + 1, A - 1, B, newTatami);
                    result += DFS(curH, curW + 2, A - 1, B, newTatami);
                    newTatami[curH][curW] = 0;
                    newTatami[curH][curW + 1] = 0;
                }
            }
            return result;
        }
    }
}
