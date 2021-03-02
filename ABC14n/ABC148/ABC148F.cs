// Solution : BFS * 3
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC148
{
    class ABC148F
    {
        static int N;
        static List<int>[] edge;

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            N = init[0];
            var beginT = init[1];
            var beginA = init[2];

            edge = new List<int>[N + 1];
            for (int i = 1; i <= N; i++)
            {
                edge[i] = new List<int>();
            }

            for (int i = 1; i < N; i++)
            {
                var way = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var x = way[0];
                var y = way[1];

                edge[x].Add(y);
                edge[y].Add(x);
            }

            var distFromT = new int[N + 1];
            SearchDistance(beginT, distFromT);
            
            var distFromA = new int[N + 1];
            SearchDistance(beginA, distFromA);

            var dist = BFS(beginT, distFromT, distFromA);

            WriteLine(dist.ToString());
            ReadKey();
        }

        static void SearchDistance(int begin, int[] distFrom)
        {
            for (int i = 1; i <= N; i++)
            {
                distFrom[i] = -1;
            }
            distFrom[begin] = 0;

            var que = new Queue<int>();
            que.Enqueue(begin);

            while (que.Count() > 0)
            {
                var cur = que.Dequeue();
                foreach (int next in edge[cur])
                {
                    if (distFrom[next] >= 0) continue;
                    que.Enqueue(next);
                    distFrom[next] = distFrom[cur] + 1;
                }
            }
        }

        static int BFS(int beginT, int[] distFromT, int[] distFromA)
        {
            int result = 0;
            var queT = new Queue<int>();
            var visited = new bool[N + 1];

            queT.Enqueue(beginT);
            
            while (queT.Count() > 0)
            {
                var curT = queT.Dequeue();
                visited[curT] = true;
                if (distFromT[curT] > distFromA[curT]) continue;

                if (edge[curT].Count() == 1)
                {
                    int dist = distFromA[curT];
                    // int go = distFromT[curT];
                    // if ((dist - go) % 2 != 0) dist--;
                    dist--;
                    if (dist > result) result = dist;
                }

                foreach (int nextT in edge[curT])
                {
                    if (!visited[nextT])
                    {
                        queT.Enqueue(nextT);
                    }
                }
            }
            return result;
        }
    }
}
