using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace GreenProblems
{
    class ABC012D
    {
        internal class RouteInfo
        {
            internal int To{get; set;}
            internal long Time{get; set;}

            internal RouteInfo(int to, long time)
            {
                To = to;
                Time = time;
            }
        }

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var Route = new List<RouteInfo>[N + 1]
                .Select(v => new List<RouteInfo>()).ToArray();

            const long INF = long.MaxValue / 2;
            for (int i = 0; i < M; i++)
            {
                var way = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var A = way[0];
                var B = way[1];
                var T = (long)way[2];

                Route[A].Add(new RouteInfo(B, T));
                Route[B].Add(new RouteInfo(A, T));
            }

            int startStop = 0;
            int minDeg = N;
            for (int j = 1; j <= N; j++)
            {
                var deg = Route[j].Count();
                if (deg < minDeg)
                {
                    startStop = j;
                    minDeg = deg;
                } 
            }

            var parent = new int[N + 1];
            var reachedTime = new long[2][];
            reachedTime[0] = Enumerable.Repeat<long>(INF, N + 1).ToArray();
            reachedTime[1] = Enumerable.Repeat<long>(INF, N + 1).ToArray();

            for (int k = 0; k < 2; k++)
            {
                var searched = new bool[N + 1];

                int finalStop = 0;
                var pq = new PriorityQueue_Dijkstra();
                pq.Push(new TakeTime(startStop, 0));

                reachedTime[k][startStop] = 0;

                while (pq.Count() > 0)
                {
                    var cur = pq.Pop();
                    if (searched[cur.BusStop]) continue;
                    searched[cur.BusStop] = true;
                    finalStop = cur.BusStop;

                    foreach (RouteInfo next in Route[cur.BusStop])
                    {
                        if (searched[next.To]) continue;

                        var nomineeTime = cur.ArrivedTime + next.Time;
                        if (reachedTime[k][next.To] > nomineeTime)
                        {
                            parent[next.To] = cur.BusStop;
                            reachedTime[k][next.To] = nomineeTime;
                        }

                        pq.Push(new TakeTime(next.To, reachedTime[k][next.To]));
                    }
                }
                startStop = finalStop;
            }

            long minReachedTimeDiff = INF;
            long maxRideTime = 0;
            for (int j = 1; j <= N; j++)
            {
                if (Abs(reachedTime[1][j] - reachedTime[0][j]) < minReachedTimeDiff)
                {
                    minReachedTimeDiff = Abs(reachedTime[1][j] - reachedTime[0][j]);
                    maxRideTime = Max(reachedTime[0][j], reachedTime[1][j]);
                }
            }
            WriteLine(maxRideTime.ToString());
            ReadKey();
        }

        internal class TakeTime
        {
            internal int BusStop{get; set;}
            internal long ArrivedTime{get; set;}

            internal TakeTime(int busStop, long arrivedTime)
            {
                BusStop = busStop;
                ArrivedTime = arrivedTime;
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
                if (data[child].ArrivedTime < data[parent].ArrivedTime)
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
                    && data[parent * 2 + 1].ArrivedTime < data[parent].ArrivedTime)
                {
                    child = parent * 2 + 1;                
                }

                if (parent * 2 + 2 < Count() 
                    && data[parent * 2 + 2].ArrivedTime < data[parent].ArrivedTime)
                {
                    if (child != parent * 2 + 1
                        || data[parent * 2 + 1].ArrivedTime > data[parent * 2 + 2].ArrivedTime)
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
    }
}
