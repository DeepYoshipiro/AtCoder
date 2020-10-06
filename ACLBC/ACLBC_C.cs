using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ACLBC
{
    class ACLBC_C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var uf = new UnionFind(N + 1);
            for (int j = 1; j <= M; j++)
            {
                var way = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var A = way[0];
                var B = way[1];

                uf.Union(A, B);
            }

            var grouped = new bool[N + 1];
            for (int i = 1; i <= N; i++)
            {
                var dummy = uf.Root(i);
            }
            for (int i = 1; i <= N; i++)
            {
                grouped[uf.Parent[i]] = true;
            }

            int nonConnected = -1;
            for (int i = 1; i <= N; i++)
            {
                if (grouped[i]) nonConnected++;
            }

            WriteLine(nonConnected.ToString());
            ReadKey();
        }
    }

    class UnionFind
    {
        internal int[] Parent{get;}
        int[] Rank;

        internal UnionFind(int N)
        {
            Parent = new int[N];
            Rank = new int[N];
            for (int i = 0; i < N; i++)
            {
                Parent[i] = i;
            }
        }

        internal void Union(int X, int Y)
        {
            int rootX = Root(X);
            int rootY = Root(Y);
            int rank = Max(Rank[rootX], Rank[rootY]);
            Parent[X] = Parent[rootX];
            Parent[Y] = Parent[rootX];
            Rank[rootX] = rank++;
        }

        internal int Root(int N)
        {
            if (Parent[N] == N)
            {
                return N;
            }
            int root = Root(Parent[N]);
            return root;
        }
    }
}
