using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

using System.Collections;

namespace ABC144
{
    class ABC144E
    {
        public class Member
        {
            public long A{get; set;}
            public long F{get; set;}
            public long Time{get; set;}

            public Member(long _A, long _F, long time)
            {
                A = _A;
                F = _F;
                Time = time;
            }
        }

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = (int)init[0];
            var K = init[1];

            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).OrderBy(n => n).ToArray();
            var F = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToArray();

            var time = new long[N];
            var pq = new PriorityQueue();
            for (int i = 0; i < N; i++)
            {
                time[i] = A[i] * F[i];
                pq.Push(new Member(A[i], F[i], time[i]));
            }            

            for (int j = 0; j < K; j++)
            {
                if (pq.Count() == 0) break;

                var cur = pq.Pop();
                if (cur.Time == 0)
                {
                    j--;
                    continue;
                }

                cur.Time = --cur.A * cur.F;
                pq.Push(cur);
            }

            var result = (pq.Count() == 0)
                ? 0 : pq.Pop().Time;

            WriteLine(result.ToString());
            ReadKey();
        }

        internal class PriorityQueue
        {
            List<Member> data;
            internal PriorityQueue()
            {
                data = new List<Member>();
            }

            internal void Push(Member x)
            {
                int cur = data.Count();
                data.Add(x);
                UpHeap(cur);
            }

            internal Member Pop()
            {
                var ret = data.First();
                data[0] = data.Last();
                data.RemoveAt(Count() - 1);
                DownHeap(0);
                return ret;
            }

            internal int Count()
            {
                return data.Count();
            }

            private int CompareTo(Member C1, Member C2)
            {
                var timeCompare = (C1.Time).CompareTo(C2.Time);
                if (timeCompare != 0) return timeCompare;

                return (-(C1.A).CompareTo(C2.A));  
            }

            private void UpHeap(int idx)
            {
                if (idx == 0) return;
                int child = idx;
                int parent = (child % 2 == 0 ? (child - 2) / 2 : (child - 1) / 2);
                if (CompareTo(data[child], data[parent]) > 0)
                {
                    var A = data[child];
                    var B = data[parent];
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
                    && CompareTo(data[parent * 2 + 1], data[parent]) > 0)
                {
                    child = parent * 2 + 1;                
                }

                if (parent * 2 + 2 < Count()
                    && CompareTo(data[parent * 2 + 2], data[parent]) > 0)
                {
                    if (child != parent * 2 + 1
                        || CompareTo(data[parent * 2 + 1], data[parent * 2 + 2]) < 0)
                    {
                        child = parent * 2 + 2;
                    }                
                }

                if (child > parent)
                {
                    var A = data[child];
                    var B = data[parent];
                    data[child] = B;
                    data[parent] = A;
                    DownHeap(child);
                }
            }
        }
    }
}
