using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace ABC141
{
    class ABC141Drev
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
               .Select(n => int.Parse(n)).ToArray();

            int N = init[0];    //品物数
            int M = init[1];    //割引券枚数

            PriorityQueue_Desc pque = new PriorityQueue_Desc();
            long[] A = ReadLine().Split(' ')
               .Select(n => long.Parse(n)).ToArray();
            
            for (int i = 0; i < N; i++)
            {
                pque.Push(A[i]);
            }

            for (int j = 0; j < M; j++)
            {
                long curPrice = pque.Pop() / 2;
                pque.Push(curPrice);
            }

            long result = 0;
            for (int i = 0; i < N; i++)
            {
                result += pque.Pop();
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