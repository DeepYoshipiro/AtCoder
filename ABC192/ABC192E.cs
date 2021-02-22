// Solition : Dijkstra
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC192
{
    class ABC192E
    {
        internal class WayInfo
        {
            internal int City{get; set;}
            internal long Time{get; set;}
            internal long Depart{get; set;}

            internal WayInfo(int city, long time, long depart)
            {
                City = city;
                Time = time;
                Depart = depart;
            }
        }

        internal class TakeTime
        {
            internal int City{get; set;}
            internal long Time{get; set;}

            internal TakeTime(int city, long time)
            {
                City = city;
                Time = time;
            }
        }

        internal class PriorityQueue_Dijkstra
        {
            List<TakeTime> data;
            internal PriorityQueue_Dijkstra()
            {
                data = new List<TakeTime>();
            }

            internal void Push(TakeTime x)
            {
                int cur = data.Count();
                data.Add(x);
                UpHeap(cur);
            }

            internal TakeTime Pop()
            {
                TakeTime ret = data.First();
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
                if (data[child].Time < data[parent].Time)
                {
                    TakeTime A = data[child];
                    TakeTime B = data[parent];
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
                if (parent * 2 + 1 < Count() 
                    && data[parent * 2 + 1].Time < data[parent].Time)
                {
                    child = parent * 2 + 1;                
                }

                if (parent * 2 + 2 < Count() 
                    && data[parent * 2 + 2].Time < data[parent].Time)
                {
                    if (child != parent * 2 + 1
                        || data[parent * 2 + 1].Time > data[parent * 2 + 2].Time)
                    {
                        child = parent * 2 + 2;
                    }                
                }

                if (child > parent)
                {
                    TakeTime A = data[child];
                    TakeTime B = data[parent];
                    data[child] = B;
                    data[parent] = A;
                    DownHeap(child);
                }
            }
        }

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];
            var X = init[2];
            var Y = init[3];

            var way = new List<WayInfo>[N + 1]
                .Select(v => new List<WayInfo>()).ToArray();
            for (int j = 0; j < M; j++)
            {
                var W = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var A = W[0];
                var B = W[1];
                var T = (long)W[2];
                var K = (long)W[3];

                way[A].Add(new WayInfo(B, T, K));
                way[B].Add(new WayInfo(A, T, K));
            }

            const long INF = long.MaxValue / 2;

            var pq = new PriorityQueue_Dijkstra();
            pq.Push(new TakeTime(X, 0));

            var ElapsedTime = Enumerable.Repeat<long>(INF, N + 1)
                .ToArray();
            ElapsedTime[X] = 0;

            var confirmed = new bool[N + 1];

            while (pq.Count() > 0)
            {
                var cur = pq.Pop();
                if (confirmed[cur.City]) continue;

                foreach (WayInfo next in way[cur.City])
                {
                    if (confirmed[next.City]) continue;

                    long transferTime = 0;
                    if (cur.City != Y)
                    {
                        transferTime = (next.Depart - (cur.Time % next.Depart)) % next.Depart;
                    }

                    var arrivedTime = ElapsedTime[cur.City] + transferTime + next.Time;

                    ElapsedTime[next.City]
                        = arrivedTime < ElapsedTime[next.City]
                        ? arrivedTime : ElapsedTime[next.City];
                    pq.Push(new TakeTime(next.City, ElapsedTime[next.City]));
                }

                confirmed[cur.City] = true;
            }

            WriteLine(ElapsedTime[Y] < INF ? ElapsedTime[Y].ToString() : "-1");
            ReadKey();
        }
    }
}
