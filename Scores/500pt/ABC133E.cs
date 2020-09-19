// Solution : BFS
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class ABC133E
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = (long)init[1];

            var edge = new List<int>[N + 1]
                .Select(v => new List<int>()).ToArray();
            var deg = new int[N + 1];
            for (int i = 0; i < N - 1; i++)
            {
                var way = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                edge[way[0]].Add(way[1]);
                deg[way[1]]++;

                edge[way[1]].Add(way[0]);
                deg[way[0]]++;
            }

            int beginPos;
            var que = new Queue<int>();
            for (beginPos = 1; beginPos <= N; beginPos++)
            {
                if (deg[beginPos] == 1)
                {
                    que.Enqueue(beginPos);
                    break;
                }
            }

            long result = K;
            long MOD = (long)Pow(10, 9) + 7;

            var visited = new bool[N + 1];
            var usedDeg = new int[N + 1];
            while (que.Count() > 0)
            {
                var curPos = que.Dequeue();
                visited[curPos] = true;
                foreach (int nextPos in edge[curPos])
                {
                    if (visited[nextPos]) continue;
                    usedDeg[curPos]++;
                    usedDeg[nextPos]++;
                    result *= K - usedDeg[curPos];
                    result %= MOD;
                    que.Enqueue(nextPos); 
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
