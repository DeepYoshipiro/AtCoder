// Solution: Union-Find
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ARC032B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];  
            var M = init[1];

            var uf = new Union_Find(N);
            for (int i = 0; i < M; i++)
            {
                var route = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var x = route[0];  
                var y = route[1];
                
                uf.Union(x, y);
            }

            WriteLine(uf.NeedRouteCnt().ToString());
            ReadKey();
        }
    }

    internal class Union_Find
    {
        internal int[] Parent{get;}
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
            var p = Root(x);
            var q = Root(y);

            Parent[q] = p;
            Parent[y] = p;
        }

        private int Root(int x)
        {
            if (x == Parent[x]) return x;
            return Parent[x] = Root(Parent[x]);
        }

        internal int NeedRouteCnt()
        {
            for (int i = 1; i < Parent.Count(); i++)
            {
                Parent[i] = Root(i);
            }

            var grp = new List<int>();
            for (int i = 1; i < Parent.Count(); i++)
            {
                grp.Add(Parent[i]);
            }
            return grp.Distinct().Count() - 1;
        }
    }
}