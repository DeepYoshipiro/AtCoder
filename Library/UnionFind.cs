using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Library
{
    class UnionFindTest
    {
        static void Main(string[] args)
        {
            int[] parent = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var uf = new UnionFind(10);
            
            uf.Union(6, 2);
            uf.Union(4, 8);
            uf.Union(9, 2);
            
        }
    }

    class UnionFind
    {
        int[] Parent;
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
            if (rootX > rootY)
            {
                (new BaseAlgorithm()).Swap(ref rootX, ref rootY);
            }
            int rank = Max(Rank[rootX], Rank[rootY]);
            Parent[X] = Parent[rootX];
            Parent[Y] = Parent[rootX];
            Rank[rootX] = rank++;
        }

        private int Root(int N)
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