// Solution : DFS
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC054C_rev
    {
        static int N;
        static List<int>[] edge;

        static void Main(string[] args)
        {
            var init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            N = init[0];
            var M = init[1];

            edge = new List<int>[N + 1];
            for (int u = 1; u <= N; u++)
            {
                edge[u] = new List<int>();
            }
            for (int j = 0; j < M; j++)
            {
                var way = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                edge[way[0]].Add(way[1]);
                edge[way[1]].Add(way[0]);
            }

            var visitedOrder = new int[N + 1];
            var result = DFS(1, 1, visitedOrder);

            WriteLine(result.ToString());
            ReadKey();
        }

        static int DFS(int curPos, int visitedCityCnt, int[] visitedOrder)
        {
            int result = 0;
            if (visitedOrder[curPos] > 0) return 0;

            visitedOrder[curPos] = visitedCityCnt;
            if (visitedCityCnt == N) return 1;
            foreach (int nextPos in edge[curPos])
            {
                var newVisitedOrder = visitedOrder.Clone();
                result += DFS(nextPos, visitedCityCnt + 1, (int[])newVisitedOrder);
            }

            return result;
        }
    }
}