using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC049Drev2
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

            for (int i = 1; i <= N; i++)
            {
                RoadGrpIdx[i] = Road.Root(i);
                RailwayGrpIdx[i] = Railway.Root(i);
            }

            Tuple<int, int>[] tpl = new Tuple<int, int>[N + 1];
            for (int i = 1; i <= N; i++)
            {
                tpl[i] = new Tuple<int, int>(RoadGrpIdx[i], RailwayGrpIdx[i]);                
            } 

            Dictionary<Tuple<int, int>, int> dic
                 = new Dictionary<Tuple<int, int>, int>();
            for (int i = 1; i <= N; i++)
            {
                if (dic.ContainsKey(tpl[i]))
                {
                    dic[tpl[i]]++;
                }
                else
                {
                    dic.Add(tpl[i], 1);
                }
            }

            for (int i = 1; i <= N; i++)
            {
                Write("{0} ", dic[tpl[i]]);
            }
            WriteLine();
            ReadKey();
        }

        private class UnionFind
        {
            internal int[] Parent {get;}

            internal UnionFind(int N)
            {
                Parent = new int[N + 1];
                for (int i = 0; i <= N; i++)
                {
                    Parent[i] = i;
                }
            }

            internal int Root(int x)
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

            internal void Unite(int x, int y)
            {
                x = Root(x);
                y = Root(y);
                if (x == y) return;

                Parent[x] = y;
            }
        }
    }
}
