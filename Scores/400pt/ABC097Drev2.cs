using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC097Drev2
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            UnionFind uni = new UnionFind(N);

            int[] p = (new int[]{0})
                .Concat(ReadLine().Split()
                        .Select(n => int.Parse(n))
                        ).ToArray();

            for (int j = 0; j < M; j++)
            {
                int[] path = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                int x = path[0];
                int y = path[1];
                uni.Unite(Max(x, y), Min(x, y));
            }

            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                if (uni.Same(p[i], i)) result++;
            }            

            WriteLine(result.ToString());
            ReadKey();
        }

        internal class UnionFind
        {
            internal int[] parent {get;}

            internal UnionFind(int N)
            {
                parent = new int[N + 1];
                for (int i = 0; i <= N; i++)
                {
                    parent[i] = i;
                }
            }

            internal int Root(int x)
            {
                if (parent[x] == x)
                {
                    return x;
                }
                else
                {
                    parent[x] = Root(parent[x]);
                    return parent[x];
                }
            }

            internal bool Same(int x, int y)
            {
                return Root(x) == Root(y);
            }

            internal void Unite(int x, int y)
            {
                x = Root(x);
                y = Root(y);
                if (x == y) return;

                parent[x] = y;
            }   
        }
    }
}

