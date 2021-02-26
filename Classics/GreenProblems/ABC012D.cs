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
            internal int Time{get; set;}

            internal RouteInfo(int to, int time)
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

            const int INF = int.MaxValue / 2;
            for (int i = 0; i < M; i++)
            {
                var way = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var A = way[0];
                var B = way[1];
                var T = way[2];

                Route[A].Add(new RouteInfo(B, T));
                Route[B].Add(new RouteInfo(A, T));
            }

            int result = INF;
            for (int j = 1; j <= N; j++)
            {
                var reachedTime = Enumerable.Repeat<int>(INF, N + 1).ToArray();
                var searched = new bool[N + 1];

                int finalStop = 0;
                var pq = new PriorityQueue_Dijkstra();
                pq.Push(new TakeTime(j, 0));

                reachedTime[j] = 0;

                while (pq.Count() > 0)
                {
                    var cur = pq.Pop();
                    if (searched[cur.BusStop]) continue;
                    searched[cur.BusStop] = true;
                    finalStop = cur.BusStop;
                    // if (reachedTime[cur.BusStop] > result) continue;

                    foreach (RouteInfo next in Route[cur.BusStop])
                    {
                        if (searched[next.To]) continue;

                        var nomineeTime = cur.ArrivedTime + next.Time;
                        if (reachedTime[next.To] > nomineeTime)
                        {
                            reachedTime[next.To] = nomineeTime;
                        }

                        pq.Push(new TakeTime(next.To, reachedTime[next.To]));
                    }
                }

                result = reachedTime[finalStop] < result 
                    ? reachedTime[finalStop] : result;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        internal class TakeTime
        {
            internal int BusStop{get; set;}
            internal int ArrivedTime{get; set;}

            internal TakeTime(int busStop, int arrivedTime)
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
