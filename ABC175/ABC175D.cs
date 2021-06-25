using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC175
{
    class ABC175D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = (int)init[0];
            var K = init[1];

            var P = new int[]{0}
                .Concat(ReadLine().Split()
                .Select(n => int.Parse(n))).ToArray();
 
            var C = new long[]{0}
                .Concat(ReadLine().Split()
                .Select(n => long.Parse(n)))
                .ToArray();

            var uf = new Union_Find(N);
            for (int i = 1; i <= N; i++)
            {
                uf.Union(i, P[i]);
            }

            var P_Length = new Dictionary<int, long>();
            for (int i = 1; i <= N; i++)
            {
                var start = uf.Root(i);
                if (P_Length.ContainsKey(start)) continue;
                var cur = start;
                P_Length.Add(start, 1);
                var length = 1;
                while (P[cur] != start)
                {
                    P_Length[start] = ++length;
                    cur = P[cur];
                }
            }

            long result = long.MinValue / 2;
            // for (int K = 1; K <= 100; K++)
            // {
            // Write(K + " ");

            foreach (int grp in P_Length.Keys)
            {
                var count = P_Length[grp];
                var sum = new long[count * 2 + 1];
                var cur = grp;
                for (int i = 1; i <= count * 2; i++)
                {
                    sum[i] = sum[i - 1];
                    var next = P[cur];
                    sum[i] += C[next];
                    cur = next;
                }

                long groupScore = 0;
                if (sum[count] > 0)
                {
                    groupScore = K / count * sum[count];
                }

                var curK = K % count;
                if (groupScore == 0) curK = Min(K, count);
                long plusScore = (curK == 0) ? 0 : long.MinValue / 2;
                for (int l = 1; l <= count; l++)
                {
                    for (int r = l; r < l + curK; r++)
                    {
                        plusScore = Max(plusScore, sum[r] - sum[l - 1]);
                    }
                }
                groupScore += plusScore;
                // Write(groupScore.ToString() + " ");
                result = Max(result, groupScore);
            }

            // WriteLine();
            // }
            WriteLine(result.ToString());
            ReadKey();
        }

        internal class Union_Find
        {
            internal int[] Parent;
            internal Union_Find(int N)
            {
                Parent = Enumerable.Range(0, N + 1).ToArray();
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
