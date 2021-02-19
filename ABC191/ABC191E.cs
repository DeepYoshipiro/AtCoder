// Solution : Dijkstra
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC191
{
    class ABC191E
    {
        internal class WayInfo
        {
            // public int WayNum{get; set;}
            internal int Town{get; set;}
            internal int Time{get; set;}

            // internal wayInfo(int wayNum, int to, int time)
            internal WayInfo(int town, int time)
            {
                // WayNum = wayNum;
                Town = town;
                Time = time;
            }
        }

        internal class TakeTime
        {
            internal int Town{get; set;}
            internal int Time{get; set;}

            internal TakeTime(int town, int time)
            {
                Town = town;
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

            var way = new List<WayInfo>[N + 1]
                .Select(v => new List<WayInfo>()).ToArray();
            for (int j = 0; j < M; j++)
            {
                var W = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var A = W[0];
                var B = W[1];
                var C = W[2];

                // way[A].Add(new wayInfo(j, B, C));
                way[A].Add(new WayInfo(B, C));
            }

            const int INF = int.MaxValue / 2;
            for (int i = 1; i <= N; i++)
            {
                // var passed = new bool[M];
                var ElapsedTime = Enumerable.Repeat<int>(INF, N + 1)
                    .ToArray();

                // var curTakeTime = Enumerable.Repeat<int>(INF, N + 1)
                    // .ToArray();

                var pq = new PriorityQueue_Dijkstra();
                foreach (WayInfo begin in way[i])
                {
                    pq.Push(new TakeTime(begin.Town, begin.Time));

                    ElapsedTime[begin.Town] = 
                        begin.Time < ElapsedTime[begin.Town]
                        ? begin.Time : ElapsedTime[begin.Town];
                }

                var confirmed = new bool[N + 1];
                while (pq.Count() > 0)
                {
                    var cur = pq.Pop();
                    if (confirmed[cur.Town]) continue;

                    foreach (WayInfo next in way[cur.Town])
                    {
                        if (confirmed[next.Town]) continue;
                        
                        ElapsedTime[next.Town]
                            = ElapsedTime[cur.Town] + next.Time < ElapsedTime[next.Town]
                            ? ElapsedTime[cur.Town] + next.Time
                            : ElapsedTime[next.Town];
                        pq.Push(new TakeTime(next.Town, next.Time));
                    }

                    confirmed[cur.Town] = true;
                    if (confirmed[i]) break;
                }

                WriteLine(ElapsedTime[i] < INF ? ElapsedTime[i].ToString() : "-1");
            }
            ReadKey();
        }
    }
}
