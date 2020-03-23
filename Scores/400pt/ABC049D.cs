using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC049D
    {
        static void Main(string[] args)
        {
            const int Road = 0;
            const int Railway = 1;
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int[] RouteCnt = {init[1], init[2]};

            List<int>[][] Route = new List<int>[2][];
            Route[Road] = new List<int>[N + 1];
            Route[Railway] = new List<int>[N + 1];

            for (int city = 0; city <= N; city++)
            {
                Route[Road][city] = new List<int>();
                Route[Railway][city] = new List<int>();
            }

            int[][] RouteGrp = new int[2][];
            RouteGrp[Road] = new int[N + 1];
            RouteGrp[Railway] = new int[N + 1];

            List<int>[][] TransportationNet = new List<int>[2][];

            for (int Transportation = Road;
                 Transportation <= Railway; Transportation++)
            {
                int t = Transportation;
                for (int i = 0; i < RouteCnt[t]; i++)
                {
                    int[] path = ReadLine().Split()
                        .Select(n => int.Parse(n)).ToArray();
                    int from = path[0];
                    int to = path[1];

                    Route[Transportation][from].Add(to);
                    Route[Transportation][to].Add(from);
                }

                int grpCnt = 0;
                for (int j = 1; j <= N; j++)
                {
                    if (RouteGrp[t][j] > 0) continue;
                    Queue<int> route = new Queue<int>();
                    route.Enqueue(j);
                    grpCnt++;

                    while (route.Count > 0)
                    {
                        int from = route.Dequeue();
                        if (RouteGrp[t][from] > 0) continue;
                        RouteGrp[t][from] = grpCnt;
                        foreach (int to in Route[t][from])
                        {
                            route.Enqueue(to);
                        }
                    }
                }

                TransportationNet[t] = new List<int>[grpCnt + 1];
                for (int k = 1; k <= grpCnt; k++)
                {
                    TransportationNet[t][k] = new List<int>();
                }
                
                for (int j = 1; j <= N; j++)
                {
                    TransportationNet[t][RouteGrp[t][j]].Add(j);
                }
            }

            for (int i = 1; i <= N; i++)
            {
                Write("{0} ", TransportationNet[Road][RouteGrp[Road][i]]
                    .Intersect(TransportationNet[Railway][RouteGrp[Railway][i]])
                    .Count().ToString());
            }
            WriteLine();
            ReadKey();
        }
    }
}