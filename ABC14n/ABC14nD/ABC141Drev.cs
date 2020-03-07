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

            PriorityQueue pque = new PriorityQueue(N);
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

    internal class PriorityQueue
    {
        long[] heap;

        int sz = 0;

        public PriorityQueue(int N)
        {
            heap = new long[2 * N];
        }

        public void Push(long x)
        {
            int i = sz++;

            while (i > 0)
            {
                int p = (i - 1) / 2;

                if (heap[p] >= x) break;
                heap[i] = heap[p];
                i = p;
            }

            heap[i] = x;
        }

        public long Pop()
        {
            long ret = heap[0];

            long x = heap[--sz];

            int i = 0;
            while (i * 2 + 1 < sz)
            {
                int a = i * 2 + 1, b = i * 2 + 2;
                if (b < sz && heap[b] > heap[a]) a = b;

                if (heap[a] <= x) break;

                heap[i] = heap[a];
                i = a;
            }

            heap[i] = x;
            return ret;
        }

        public bool empty()
        {
            if (sz > 0) return false;
            return true;
        }
    }
}