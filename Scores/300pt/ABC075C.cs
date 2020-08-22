// Solution : Union-Find
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC075C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var edge = new int[M][];
            for (int j = 0; j < M; j++)
            {
                edge[j] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            }

            int result = 0;
            for (int j = 0; j < M; j++)
            {
                var route = new List<int>[N + 1];
                for (int i = 1; i <= N; i++)
                {
                    route[i] = new List<int>();
                }

                var uf = new Union_Find(N);
                for (int k = 0; k < M; k++)
                {
                    if (j == k) continue;
                    var term1 = edge[k][0];
                    var term2 = edge[k][1];

                    uf.Union(term1, term2);                    
                }

                if (uf.GroupCnt() != 1) result++;
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }

    internal class Union_Find
    {
        internal int[] Parent{get;}
        private int N;

        internal Union_Find(int _N)
        {
            N = _N;
            Parent = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                Parent[i] = i;
            }
        }

        internal void Union(int x, int y)
        {
            var p = root(x);
            var q = root(y);

            Parent[q] = p;
            Parent[y] = p;
        }

        private int root(int x)
        {
            if (Parent[x] == x) return x;
            return Parent[x] = root(Parent[x]);
        }

        internal int GroupCnt()
        {
            for (int i = 1; i <= N; i++)
            {
                root(i);
            }

            return Parent.Distinct().Count() - 1;
        }
    }
}
