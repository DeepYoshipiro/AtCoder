using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC157
{
    class ABC157D
    {
        static void Main(string[] args)
        {
            // var init = ReadLine().Split()
            //         .Select(n => int.Parse(n)).ToArray();
            // var N = init[0];
            int N = 10;
            // var M = init[1];
            // //int K = init[2];
            
            // var friend = new List<int>[N + 1];
            // for (int j = 1; j <= N; j++)
            // {
            //     friend[j] = new List<int>();
            // } 

            var uf = new Union_Find(N);
            WriteLine(uf.root(5));
            ReadKey();
            // for (int i = 0; i < M; i++)
            // {
            //     var like = ReadLine().Split()
            //         .Select(n => int.Parse(n)).ToArray();
            //     var x = like[0];
            //     var y = like[1];
                
            //     friend[x].Add(y);
            //     friend[y].Add(x);

            //     uf.Union(x, y);
            // }
        }

    }
    internal class Union_Find
    {
        int[] parent;
        internal Union_Find(int N)
        {
            parent = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                parent[i] = i - 1;  // for test
                // parent[i] = i;
            }
            parent[1] = 1;
        }

        internal void Union(int x, int y)
        {
            int p = root(x);
            int q = root(y);

            if (p == q) return;

                    
        }

        internal int root(int x)
        {
            if (x == parent[x]) return x;
            return parent[x] = root(parent[x]);
        }
    }
}


