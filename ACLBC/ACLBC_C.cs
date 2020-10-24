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

            var uf = new Union_Find(N);
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

        internal class Union_Find
        {
            internal int[] Parent;
            internal Union_Find(int N)
            {
                Parent = new int[N + 1];
                for (int i = 1; i <= N; i++)
                {
                    Parent[i] = i;
                }
            }

            internal void Union(int x, int y)
            {
                int p = Root(x);
                int q = Root(y);

                if (p == q) return;
                Parent[q] = p;
                Parent[y] = p;

                return;  
            }

            internal int Root(int x)
            {
                if (x == Parent[x]) return x;
                return Parent[x] = Root(Parent[x]);
            }
        }
    }
}
