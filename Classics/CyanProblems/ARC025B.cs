using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ARC025B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];

            var black = new int[H + 1][]
                .Select(v => new int[W + 1]).ToArray();
            var white = new int[H + 1][]
                .Select(v => new int[W + 1]).ToArray();

            for (int i = 1; i <= H; i++)
            {
                var info = (new int[]{0})
                    .Concat(ReadLine().Split()
                        .Select(n => int.Parse(n)))
                    .ToArray();

                for (int j = 1; j <= W; j++)
                {
                    black[i][j] += black[i][j - 1];
                    white[i][j] += white[i][j - 1];
                    if ((i + j) % 2 == 0)
                    {
                        black[i][j] += info[j];
                    }
                    else
                    {
                        white[i][j] += info[j];
                    }
                }
            }

            for (int j = 1; j <= W; j++)
            {
                for (int i = 1; i <= H; i++)
                {
                    black[i][j] += black[i - 1][j];
                    white[i][j] += white[i - 1][j];
                }
            }

            int result = 0;
            for (int minH = 1; minH <= H; minH++)
            {
                for (int maxH = minH; maxH <= H; maxH++)
                {
                    for (int minW = 1; minW <= W; minW++)
                    {
                        for (int maxW = minW; maxW <= W; maxW++)
                        {
                            var usedBlack = black[maxH][maxW]
                                     - black[minH - 1][maxW]
                                     - black[maxH][minW - 1]
                                     + black[minH - 1][minW - 1];

                            var usedWhite = white[maxH][maxW]
                                     - white[minH - 1][maxW]
                                     - white[maxH][minW - 1]
                                     + white[minH - 1][minW - 1];

                            if (usedBlack != usedWhite) continue;
                            var area = (maxH - minH + 1) * (maxW - minW + 1);
                            result = (area > result) ? area : result;
                        }
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
