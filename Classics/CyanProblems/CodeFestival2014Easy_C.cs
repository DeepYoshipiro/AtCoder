using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class CodeFestival2014Easy_C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var moving = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var S = moving[0];
            var T = moving[1];

            var way = new List<int>[M + 1][]
                .Select(v => new List<KeyValuePair<int, int>>()).ToArray();
            for (int j = 0; j < M; j++)
            {
                var W = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                way[W[0]].Add(new KeyValuePair<int, int>(W[1], W[2]));
                way[W[1]].Add(new KeyValuePair<int, int>(W[0], W[2]));
            }

            var dist = new int[2][].Select(v => Enumerable.Repeat(int.MaxValue / 2, N + 1).ToArray())
                .ToArray();

            for (int i = 0; i <= 1; i++)
            {
                var pq = new PriorityQueue_Asc();
                var start = (i == 0 ? S : T);
                dist[i][start] = 0;

                pq.Push(start);
                var searched = new bool[N + 1];

                while (pq.Count() > 0)
                {
                    var cur = pq.Pop();
                    searched[cur] = true;
                    if (cur == (i == 0 ? T : S))
                    {
                        continue;
                    }

                    foreach (KeyValuePair<int, int> next in way[cur])
                    {
                        var nextTown = next.Key;
                        var time = next.Value;

                        if (searched[nextTown]) continue;

                        dist[i][nextTown]
                            = (dist[i][cur] + time < dist[i][nextTown]
                                ? dist[i][cur] + time : dist[i][nextTown]);
                        
                        pq.Push(nextTown);
                    }
                }
            }

            for (int u = 1; u <= N; u++)
            {
                if (dist[0][u] == dist[1][u])
                {
                    WriteLine(u.ToString());
                    ReadKey();
                    return;
                }
            }
            WriteLine("-1");
            ReadKey();
        }

        class PriorityQueue_Asc
        {
            List<int> data;
            internal PriorityQueue_Asc()
            {
                data = new List<int>();
            }

            internal void Push(int x)
            {
                int cur = data.Count();
                data.Add(x);
                UpHeap(cur);
            }

            internal int Pop()
            {
                int ret = data.First();
                data[0] = data.Last();
                data.RemoveAt(Count() - 1);
                DownHeap(0);
                return ret;
            }

            internal int Count()
            {
                return data.Count();
            }

            private void UpHeap(int idx)
            {
                if (idx == 0) return;
                int child = idx;
                int parent = (child % 2 == 0 ? (child - 2) / 2 : (child - 1) / 2);
                if (data[child] < data[parent])
                {
                    // var ba = new BaseAlgorithm();
                    // ba.Swap(data[child], data[parent]);
                    int A = data[child];
                    int B = data[parent];
                    data[child] = B;
                    data[parent] = A;
                    UpHeap(parent);
                }
            }

            private void DownHeap(int idx)
            {
                if (idx >= Count()) return;
                int parent = idx;
                int child = idx;
                if (parent * 2 + 1 < Count() && data[parent * 2 + 1] < data[parent])
                {
                    child = parent * 2 + 1;                
                }

                if (parent * 2 + 2 < Count() && data[parent * 2 + 2] < data[parent])
                {
                    if (child != parent * 2 + 1
                        || data[parent * 2 + 1] > data[parent * 2 + 2])
                    {
                        child = parent * 2 + 2;
                    }                
                }

                if (child > parent)
                {
                    // var ba = new BaseAlgorithm();
                    // ba.Swap(data[child], data[parent]);
                    int A = data[child];
                    int B = data[parent];
                    data[child] = B;
                    data[parent] = A;
                    DownHeap(child);
                }
            }
        }
    }
}
