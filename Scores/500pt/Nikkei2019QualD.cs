// Solution : Topological Sort (Applied BFS)
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
            var parent = new int[N + 1];

            for (int i = 0; i < N - 1 + M; i++)
            {
                var way = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var P = way[0];
                var C = way[1];
                descendant[P].Add(C);
                inDeg[C]++;
            }

            int Root;
            for (Root = 1; Root <= N; Root++)
            {
                if (inDeg[Root] == 0) break;
            }

            var que = new Queue<int>();
            que.Enqueue(Root);

            while (que.Count() > 0)
            {
                var cur = que.Dequeue();

                foreach (int next in descendant[cur])
                {
                    inDeg[next]--;

                    if (inDeg[next] == 0)
                    {
                        parent[next] = cur;
                        que.Enqueue(next);
                    }
                }
            }

            for (int i = 1; i <= N; i++)
            {
                WriteLine(parent[i].ToString());
            }
            ReadKey();
        }
    }
}
