using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class ABC126E
    {
        static int[] par;
        static int[] rank;

        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            par = new int[N + 1];
            rank = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                par[i] = i;
                rank[i] = 0;
            }

            for (int i = 0; i < M; i++)
            {
                int[] relation = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                int X = relation[0];
                int Y = relation[1];

                unite(X, Y);
            }

            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                if (find(i) == i) result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        static int find(int x)
        {
            if (par[x] == x)
            {
                return x;
            } 
            else
            {
                return par[x] = find(par[x]);
            }
        }

        static void unite(int x, int y)
        {
            x = find(x);
            y = find(y);
            if (x == y) return;

            if (rank[x] < rank[y])
            {
                par[x] = y;
            }
            else
            {
                par[y] = x;
                if (rank[x] == rank[y]) rank[y]++;
            }
        }
        
        static bool same(int x, int y)
        {
            return find(x) == find(y);
        }
    }
}