using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC119D
    {
        static long[][] Spot;

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var Q = init[2];

            long INF = long.MaxValue / 5;
            Spot = new long[2][];
            for (int m = 0; m < 2; m++)
            {
                Spot[m] = new long[init[m] + 2];
                Spot[m][0] = -INF;
                for (int i = 1; i <= init[m]; i++)
                {
                    Spot[m][i] = long.Parse(ReadLine());
                }
                Spot[m][init[m] + 1] = INF;
            }

            var result = new long[Q];
            for (int j = 0; j < Q; j++)
            {
                var dist = new long[8];
                long curPos = long.Parse(ReadLine());
                for (int k = 0; k < 2; k++)
                {
                    var firstMovedPos = new long[2];
                    WalkTo(curPos, k, out firstMovedPos);
                    dist[4 * k] = Abs(firstMovedPos[0] - curPos);
                    dist[4 * k + 1] = Abs(firstMovedPos[0] - curPos);
                    dist[4 * k + 2] = Abs(firstMovedPos[1] - curPos);
                    dist[4 * k + 3] = Abs(firstMovedPos[1] - curPos);

                    var lastPosLeft = new long[2];
                    WalkTo(firstMovedPos[0], 1 - k, out lastPosLeft);
                    dist[4 * k] += Abs(lastPosLeft[0] - firstMovedPos[0]);
                    dist[4 * k + 1] += Abs(lastPosLeft[1] - firstMovedPos[0]);

                    var lastPosRight = new long[2];
                    WalkTo(firstMovedPos[1], 1 - k, out lastPosRight);
                    dist[4 * k + 2] += Abs(lastPosRight[0] - firstMovedPos[1]);
                    dist[4 * k + 3] += Abs(lastPosRight[1] - firstMovedPos[1]);
                }
                result[j] = dist.Min();
            }

            
            for (int j = 0; j < Q; j++)
            {
                WriteLine(result[j]);
            }
            ReadKey();
        }

        static void WalkTo(long curPos, int toVisit, out long[] result)
        {
            result = new long[2];
            var left = 0;
            var right = Spot[toVisit].Length - 1;
            while (left != right)
            {
                var mid = (left + right) / 2;
                switch (curPos.CompareTo(Spot[toVisit][mid]) * curPos.CompareTo(Spot[toVisit][mid + 1]))
                {
                    case 1:
                        if (curPos.CompareTo(Spot[toVisit][mid]) < 0)
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid;
                        }
                        break;
                    case 0:
                        result[0] = result[1] = curPos;
                        return;
                    case -1:
                        result[0] = Spot[toVisit][mid];
                        result[1] = Spot[toVisit][mid + 1];
                        return;            
                }
            }

            result[0] = Spot[toVisit][left];
            result[1] = Spot[toVisit][left + 1];
            return;            
        }
    }
}
