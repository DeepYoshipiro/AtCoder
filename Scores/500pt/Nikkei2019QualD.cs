using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class Nikkei2019QualD
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var inDeg = new int[N + 1];

            var descendant = new List<int>[N + 1]
                .Select(v => new List<int>()).ToArray();
            // var IsRoot = new bool[N + 1].Select(v => true).ToArray();
            // IsRoot[0] = false;
            // var dist = new int[N + 1].Select(v => -1).ToArray();
            var parent = new int[N + 1];

            for (int i = 0; i < N - 1 + M; i++)
            {
                var way = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var P = way[0];
                var C = way[1];
                descendant[P].Add(C);
                // IsRoot[C] = false;
                inDeg[C]++;
            }

            int Root;
            for (Root = 1; Root <= N; Root++)
            {
                // if (IsRoot[Root]) break;
                if (inDeg[Root] == 0) break;
            }

            var que = new Queue<int>();
            que.Enqueue(Root);
            // dist[Root] = 0;

            // var visited = new bool[N + 1];
            while (que.Count() > 0)
            {
                var cur = que.Dequeue();
                // visited[cur] = true;

                foreach (int next in descendant[cur])
                {
                    // dist[next] = dist[cur] + 1;
                    inDeg[next]--;

                    if (inDeg[next] == 0)
                    {
                        parent[next] = cur;
                        que.Enqueue(next);
                    }
                }
            }

            // que.Enqueue(Root);
            // parent[Root] = 0;

            // var visited2 = new bool[N + 1];
            // while (que.Count() > 0)
            // {
            //     var cur = que.Dequeue();
            //     visited2[cur] = true;

            //     foreach (int next in descendant[cur])
            //     {
            //         if (dist[next] == dist[cur] + 1)
            //         {
            //             parent[next] = cur;
            //         }                    
            //         if (visited2[next]) continue;
            //         que.Enqueue(next);
            //     }
            // }

            for (int i = 1; i <= N; i++)
            {
                WriteLine(parent[i].ToString());
            }
            ReadKey();
        }
    }
}
