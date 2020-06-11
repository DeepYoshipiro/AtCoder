using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC120D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var A = new int[M];
            var B = new int[M];
            for (int i = 0; i < M; i++)
            {
                var path = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                A[i] = path[0];
                B[i] = path[1];
            }

            var uf = new UnionFind(N + 1);

            var result = new long[M + 1];
            long connectedWay = 0;
            long allWay = ((long)N * (long)(N - 1)) / 2;
            result[M] = allWay;
            for (int i = M - 1; i >= 0; i--)
            {
                connectedWay += uf.Union(A[i], B[i]);
                result[i] = allWay - connectedWay;
            }

            for (int i = 1; i <= M; i++)
            {
                WriteLine(result[i].ToString());
            }
            ReadKey();
        }
    }

    class UnionFind
    {
        int[] Parent;
        int[] Rank;
        long[] Connected {get;}

        internal UnionFind(int N)
        {
            Parent = new int[N];
            Rank = new int[N];
            Connected = new long[N];
            for (int i = 0; i < N; i++)
            {
                Parent[i] = i;
                Connected[i] = 1;
            }
        }

        internal long Union(int X, int Y)
        {
            int rootX = Root(X);
            int rootY = Root(Y);
            if (rootX > rootY)
            {
                Swap(ref rootX, ref rootY);
            }
            else if (rootX == rootY)
            {
                return 0;
            }

            int rank = Max(Rank[rootX], Rank[rootY]);

            var sizeX = Connected[rootX];
            var sizeY = Connected[rootY];
            
            long result = (sizeX + sizeY) * (sizeX + sizeY - 1);
            result -= sizeX * (sizeX - 1);
            result -= sizeY * (sizeY - 1);
            result /= 2;

            Connected[rootX] += Connected[rootY];

            Parent[X] = Parent[rootX];
            Parent[rootY] = Parent[rootX];
            Parent[Y] = Parent[rootX];
            Rank[rootX] = ++rank;

            return result;
        }

        private int Root(int N)
        {
            if (Parent[N] != N)
            {
                N = Parent[N] = Parent[Parent[N]];
            }
            return N;
        }

        public void Swap(ref int A, ref int B)
        {
            int tmp = A;
            A = B;
            B = tmp;
        }

    }
}