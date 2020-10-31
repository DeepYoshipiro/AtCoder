using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC106
{
    class ARC106B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var A = (new long[]{0})
                .Concat(ReadLine().Split()
                    .Select(n => long.Parse(n))).ToArray();
            var B = (new long[]{0})
                .Concat(ReadLine().Split()
                    .Select(n => long.Parse(n))).ToArray();

            var uf = new Union_Find(N);
            for (int j = 0; j < M; j++)
            {
                var to = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var x = to[0];
                var y = to[1];
                
                uf.Union(x, y);
            }

            for (int i = 1; i <= N; i++)
            {
                uf.Root(i);
            } 

            var diffGroup = new long[N + 1];
            for (int i = 1; i <= N; i++)
            {
                diffGroup[uf.Root(i)] += B[i] - A[i];
            }

            for (int j = 1; j <= N; j++)
            {
                if (diffGroup[j] != 0)
                {
                    WriteLine("No");
                    ReadKey();
                    return;
                }
            }
            WriteLine("Yes");
            ReadKey();
        }

        internal class Union_Find
        {
            internal int[] Parent;
            internal Union_Find(int N)
            {
                // Parent = new int[N];     // for 0-indexed
                // for (int i = 0; i < N; i++)
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
