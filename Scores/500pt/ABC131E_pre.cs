using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class ABC131E_pre
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var M = (N * (N - 1)) / 2;
            var edgeNomineeX = new int[M];
            var edgeNomineeY = new int[M];

            int k = -1;
            for (int i = 1; i < N; i++)
            {
                for (int j = i + 1; j <= N; j++)
                {
                    k++;
                    edgeNomineeX[k] = i;
                    edgeNomineeY[k] = j;
                }

            }

            for (int bit = 1; bit <= 1 << M; bit++)
            {
                var edge = new List<int>[N + 1];
                for (int i = 1; i <= N; i++)
                {
                    edge[i] = new List<int>(); 
                }

                for (int j = 0; j < M; j++)
                {
                    if ((bit & (1 << j)) > 0)
                    {
                        edge[edgeNomineeX[j]].Add(edgeNomineeY[j]);
                        edge[edgeNomineeY[j]].Add(edgeNomineeX[j]);
                    }
                }

                var visited = new bool[N + 1];
                var que = new Queue<int>();
                que.Enqueue(1);

                int visitedCity = 1;
                while (que.Count() > 0)
                {
                    var cur = que.Dequeue();

                    foreach (int next in edge[1])
                    {
                        if (visited[next]) continue;
                        visited[next] = true;
                        visitedCity++;
                        que.Enqueue(next);
                    }
                }

                if (visitedCity < N) continue;

                int road = 0;
                for (int i = 1; i <= N; i++)
                {
                    var dist = new int[N + 1];
                    for (int j = 1; j <= N; j++)
                    {
                        dist[j] = -1;
                    }

                    var que2 = new Queue<int>();
                    que2.Enqueue(i);
                    dist[i] = 0;

                    while (que2.Count() > 0)
                    {
                        var cur = que2.Dequeue();

                        foreach (int next in edge[cur])
                        {
                            if (dist[next] >= 0) continue;
                            dist[next] = dist[cur] + 1;
                            if (dist[next] == 2)
                            {
                                if (i < next)
                                {
                                    road++;
                                    continue;
                                }
                            }
                            que2.Enqueue(next);
                        }
                    }
                }

                WriteLine();
                WriteLine("{0} {1}", N, road);
                for (int i = 1; i <= N; i++)
                {
                    foreach (int j in edge[i])
                    {
                        if (i < j)
                        {
                            WriteLine("{0} {1}", i, j);
                        }
                    }
                }
                ReadKey();
            }
            ReadKey();
        }
    }
}
