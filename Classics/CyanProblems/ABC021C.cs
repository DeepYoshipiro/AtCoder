using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ABC021C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var fromTo = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = fromTo[0];
            var B = fromTo[1];

            var M = int.Parse(ReadLine());

            var road = new List<int>[N + 1]
                .Select(v => new List<int>()).ToArray();
            for (int i = 0; i < M; i++)
            {
                var input = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var X = input[0];
                var Y = input[1];

                road[X].Add(Y);
                road[Y].Add(X);
            }

            var searched = new bool[N + 1];
            var parent = new HashSet<int>[N + 1]
                .Select(v => new HashSet<int>()).ToArray();
            var dist = Enumerable.Repeat<int>(int.MaxValue / 2, N + 1)
                .ToArray();
            dist[A] = 0;

            var que = new Queue<int>();
            que.Enqueue(A);

            while (que.Count() > 0)
            {
                var cur = que.Dequeue();
                if (searched[cur]) continue;
                if (cur == B) break;

                foreach (int next in road[cur])
                {
                    if (searched[next]) continue;
                    switch(dist[next].CompareTo(dist[cur] + 1))
                    {
                        case 1:
                            parent[next].Clear();
                            parent[next].Add(cur);
                            dist[next] = dist[cur] + 1;
                            que.Enqueue(next);
                            break;
                        case 0:
                            parent[next].Add(cur);
                            que.Enqueue(next);
                            break;
                        default:
                            break;
                    };
                    searched[cur] = true;
                }
            }

            long MOD = 1000000000 + 7;

            var dp = new long[N + 1];
            var calculated = new bool[N + 1];
            var dpQue = new Queue<long>();
            dp[B] = 1;
            dpQue.Enqueue(B);
            while (dpQue.Count() > 0)
            {
                var cur = dpQue.Dequeue();
                if (calculated[cur]) continue;

                foreach (int prev in parent[cur])
                {
                    dp[prev] += dp[cur];
                    dp[prev] %= MOD;
                    dpQue.Enqueue(prev);
                }
                calculated[cur] = true;
            }

            var result = dp[A];

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
