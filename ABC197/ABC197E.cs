using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC197
{
    class ABC197E
    {
        class Color
        {
            internal int Count{get; set;}
            internal long MinPos{get; set;}
            internal long MaxPos{get; set;}
        }

        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var Ball = new Color[N + 1]
                .Select(v => new Color()).ToArray();

            for (int i = 1; i <= N; i++)
            {
                var info = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                var X = info[0];
                var C = (int)info[1];
                if (++Ball[C].Count == 1)
                {
                    Ball[C].MinPos = X;
                    Ball[C].MaxPos = X;
                }
                else
                {
                    Ball[C].MinPos = Min(X, Ball[C].MinPos);
                    Ball[C].MaxPos = Max(X, Ball[C].MaxPos);
                }
            }

            var dpDistance = new long[N + 1][]
                .Select(v => new long[2]).ToArray();
            var curPos = new long[2];
            int ToMin = 0;
            int ToMax = 1;
            for (int i = 1; i <= N; i++)
            {
                dpDistance[i][ToMin] = dpDistance[i - 1][ToMin];
                dpDistance[i][ToMax] = dpDistance[i - 1][ToMax];
                long rangeColorBall = Ball[i].MaxPos - Ball[i].MinPos;
                if (Ball[i].Count == 0) continue;
                for (int j = 0; j < 2; j++)
                {
                    long distNextColor
                        = Min(Abs(curPos[j] - Ball[i].MinPos)
                            , Abs(curPos[j] - Ball[i].MaxPos));
                    dpDistance[i][j] += distNextColor + rangeColorBall;
                //     curPos
                //         = Abs(curPos - Ball[i].MinPos) < Abs(curPos - Ball[i].MaxPos)
                //         ? Ball[i].MaxPos : Ball[i].MinPos;
                }
            }
            for (int j = 0; j < 2; j++)
            {
                dpDistance[N][j] += Min(Abs(curPos[ToMin]), Abs(curPos[ToMax]));
            }

            WriteLine(dpDistance.ToString());
            ReadKey();
        }
    }
}
