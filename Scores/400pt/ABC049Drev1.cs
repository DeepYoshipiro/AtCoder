using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC049Drev1
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];
            int L = init[2];

            UnionFind Road = new UnionFind(N);
            for (int i = 0; i < K; i++)
            {
                int[] path = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                int from = path[0];
                int to = path[1];

                Road.Unite(from, to);
            }

            UnionFind Railway = new UnionFind(N);
            for (int j = 0; j < L; j++)
            {
                int[] path = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                int from = path[0];
                int to = path[1];

                Railway.Unite(from, to);                
            }

            int[] RoadGrpIdx = new int[N + 1];
            int[] RailwayGrpIdx = new int[N + 1];

            List<int>[] RoadGrp = new List<int>[N + 1];
            List<int>[] RailwayGrp = new List<int>[N + 1];
            for (int i = 1; i <= N; i++)
            {
                RoadGrpIdx[i] = Road.Root(i);
                RailwayGrpIdx[i] = Railway.Root(i);

                RoadGrp[i] = new List<int>();
                RailwayGrp[i] = new List<int>();
            }

            for (int i = 1; i <= N; i++)
            {
                RoadGrp[RoadGrpIdx[i]].Add(i);
                RailwayGrp[RailwayGrpIdx[i]].Add(i);
            }

            for (int i = 1; i <= N; i++)
            {
                if (RoadGrp[RoadGrpIdx[i]].Count > 1
                    && RailwayGrp[RailwayGrpIdx[i]].Count > 1)
                {
                    Write(RoadGrp[RoadGrpIdx[i]]
                        .Intersect(RailwayGrp[RailwayGrpIdx[i]]).Count());
                    Write(" ");
                }
                else
                {
                    Write("1 ");
                }
            }

            WriteLine();
            ReadKey();
        }

        private class UnionFind
        {
            public int[] Parent {get;}

            public UnionFind(int N)
            {
                Parent = new int[N + 1];
                for (int i = 0; i <= N; i++)
                {
                    Parent[i] = i;
                }
            }

            public int Root(int x)
            {
                if (Parent[x] == x)
                {
                    return x;
                }
                else
                {
                    return Parent[x] = Root(Parent[x]);
                }
            }

            public void Unite(int x, int y)
            {
                x = Root(x);
                y = Root(y);
                if (x == y) return;

                Parent[x] = y;
            }
        }
    }
}
