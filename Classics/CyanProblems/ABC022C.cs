using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ABC022C
    {
        static Dictionary<int, int>[] roadMap;
        static long[] roadDist;
        static long INF;
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            roadMap = new Dictionary<int, int>[N + 1]
                .Select(v => new Dictionary<int, int>()).ToArray();
            roadDist = new long[M + 1];
            for (int i = 1; i <= M; i++)
            {
                var W = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var U = W[0];
                var V = W[1];
                var L = (long)W[2];

                roadMap[U].Add(i, V);
                roadMap[V].Add(i, U);

                roadDist[i] = L;
            }

            var usedRoad = new bool[M + 1];
            
            INF = long.MaxValue / 2;

            var result = DFS(1, 0, usedRoad);
            if (result == INF) result = -1;

            WriteLine(result.ToString());
            ReadKey();
        }

        static long DFS(int pos, long traveledDist, bool[] usedRoad)
        {
            if (pos == 1 && traveledDist > 0)
            {
                return traveledDist;
            }

            long result = INF;
            foreach (KeyValuePair<int, int> next in roadMap[pos])
            {
                if (usedRoad[next.Key]) continue;
                usedRoad[next.Key] = true;
                result = Min(result, DFS(next.Value, traveledDist + roadDist[next.Key], usedRoad));
                usedRoad[next.Key] = false;
            }

            return result;
        }
    }
}
