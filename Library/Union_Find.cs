using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Library
{
    class Union_Find_Test
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var Q = init[1];

            var uf = new Union_Find(N);
            var result = new List<string>();
            for (int j = 0; j < Q; j++)
            {
                var que = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var t = que[0];
                var u = que[1];
                var v = que[2];

                switch (t)
                {
                    case 0:
                        uf.Union(u, v);
                        break;
                    case 1:
                        result.Add(
                            uf.Root(u) == uf.Root(v) ?
                            "1" : "0");
                        break;
                }
            }

            foreach (string r in result)
            {
                WriteLine(r);
            }
            ReadKey();
        }

        internal class Union_Find
        {
            internal int[] Parent;
            internal Union_Find(int N)
            {
                // Parent = new int[N + 1];
                // for (int i = 1; i <= N; i++)
                Parent = new int[N];    // for 0-indexed
                for (int i = 0; i < N; i++)
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