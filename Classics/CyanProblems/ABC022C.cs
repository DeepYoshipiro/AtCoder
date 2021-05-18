using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ABC022C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var way = new List<WayInfo>[N + 1]
                .Select(v => new List<WayInfo>()).ToArray();

            for (int i = 1; i <= M; i++)
            {
                var W = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var U = W[0];
                var V = W[1];
                var L = (long)W[2];

                way[U].Add(new WayInfo(i, V, L));
                way[V].Add(new WayInfo(i, U, L));
            }

            long INF = long.MaxValue / 2;

            long result = INF;
            foreach (WayInfo first in way[1])
            {
                var usedRoad = new bool[M + 1];

                // var pq = new PriorityQueue_Dijkstra();
                var que = new Queue<TakeTime>();
                usedRoad[first.RouteNo] = true;
                // que.Push(new TakeTime(first.Town, first.Time));
                que.Enqueue(new TakeTime(first.Town, first.Time));

                while (que.Count() > 0)
                {
                    // var cur = que.Pop();
                    var cur = que.Dequeue();
                    if (cur.Town == 1)
                    {
                        result = Min(result, cur.Time);
                        continue;
                    }

                    foreach (WayInfo next in way[cur.Town])
                    {
                        if (usedRoad[next.RouteNo]) continue;
                        usedRoad[next.RouteNo] = true;
                        // que.Push(new TakeTime(next.Town, cur.Time + next.Time));
                        que.Enqueue(new TakeTime(next.Town, cur.Time + next.Time));
                    }
                }                
            }
            if (result == INF) result = -1;

            WriteLine(result.ToString());
            ReadKey();
        }

        internal class WayInfo
        {
            internal int RouteNo{get; set;}
            internal int Town{get; set;}
            internal long Time{get; set;}

            internal WayInfo(int route_no, int town, long time)
            {
                RouteNo = route_no;
                Town = town;
                Time = time;
            }
        }

        internal class TakeTime
        {
            internal int Town{get; set;}
            internal long Time{get; set;}

            internal TakeTime(int town, long time)
            {
                Town = town;
                Time = time;
            }
        }

        // internal class PriorityQueue_Dijkstra
        // {
        //     List<TakeTime> data;
        //     internal PriorityQueue_Dijkstra()
        //     {
        //         data = new List<TakeTime>();
        //     }

        //     internal void Push(TakeTime x)
        //     {
        //         int cur = data.Count();
        //         data.Add(x);
        //         UpHeap(cur);
        //     }

        //     internal TakeTime Pop()
        //     {
        //         TakeTime ret = data.First();
        //         data[0] = data.Last();
        //         data.RemoveAt(Count() - 1);
        //         DownHeap(0);
        //         return ret;
        //     }

        //     internal int Count()
        //     {
        //         return data.Count();
        //     }

        //     private void UpHeap(int idx)
        //     {
        //         if (idx == 0) return;
        //         int child = idx;
        //         int parent = (child % 2 == 0 ? (child - 2) / 2 : (child - 1) / 2);
        //         if (data[child].Time < data[parent].Time)
        //         {
        //             TakeTime A = data[child];
        //             TakeTime B = data[parent];
        //             data[child] = B;
        //             data[parent] = A;
        //             UpHeap(parent);
        //         }
        //     }

        //     private void DownHeap(int idx)
        //     {
        //         if (idx >= Count()) return;
        //         int parent = idx;
        //         int child = idx;
        //         if (parent * 2 + 1 < Count() 
        //             && data[parent * 2 + 1].Time < data[parent].Time)
        //         {
        //             child = parent * 2 + 1;                
        //         }

        //         if (parent * 2 + 2 < Count() 
        //             && data[parent * 2 + 2].Time < data[parent].Time)
        //         {
        //             if (child != parent * 2 + 1
        //                 || data[parent * 2 + 1].Time > data[parent * 2 + 2].Time)
        //             {
        //                 child = parent * 2 + 2;
        //             }                
        //         }

        //         if (child > parent)
        //         {
        //             TakeTime A = data[child];
        //             TakeTime B = data[parent];
        //             data[child] = B;
        //             data[parent] = A;
        //             DownHeap(child);
        //         }
        //     }
        // }
    }
}
