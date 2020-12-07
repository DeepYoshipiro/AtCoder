using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC137D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var payDay = new List<long>[M + 1];
            for (int j = 1; j <= M; j++)
            {
                payDay[j] = new List<long>();
            }

            for (int i = 0; i < N; i++)
            {
                var work = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                var A = (int)work[0];
                var B = work[1];

                if (A <= M) payDay[A].Add(B);
            }

            var pq = new PriorityQueue_Desc();
            long result = 0;
            for (int j = 1; j <= M; j++)
            {
                foreach (int earn in payDay[j])
                {
                    pq.Push(earn);
                }

                if (pq.Count() > 0)
                {
                    result += pq.Pop();
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }

    internal class PriorityQueue_Desc
    {
        List<long> data;
        internal PriorityQueue_Desc()
        {
            data = new List<long>();
        }

        internal void Push(long x)
        {
            int cur = data.Count();
            data.Add(x);
            UpHeap(cur);
        }

        internal long Pop()
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

        private void UpHeap(int idx)
        {
            if (idx == 0) return;
            int child = idx;
            int parent = (child % 2 == 0 ? (child - 2) / 2 : (child - 1) / 2);
            if (data[child] > data[parent])
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
            if (parent * 2 + 1 < Count() && data[parent * 2 + 1] > data[parent])
            {
                child = parent * 2 + 1;                
            }

            if (parent * 2 + 2 < Count() && data[parent * 2 + 2] > data[parent])
            {
                if (child != parent * 2 + 1
                    || data[parent * 2 + 1] < data[parent * 2 + 2])
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
