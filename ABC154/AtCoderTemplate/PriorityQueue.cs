using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC1NN
{
    class Execute
    {
        static void Main(string[] args)
        {
            PriorityQueue pque = new PriorityQueue(5);
            //int[] init = ReadLine().Split()
            //    .Select(n => int.Parse(n)).ToArray();
            //int N = init[0];
            //int K = init[1];

            pque.Push(3);
            pque.Push(5);
            pque.Push(1);

            while (!pque.empty())
            {
                WriteLine(pque.Pop().ToString());
            }
            ReadKey();
        }
    }

    internal class PriorityQueue
    {
        int[] heap;

        int sz = 0;

        public PriorityQueue(int N)
        {
            heap = new int[2 * N];
        }

        public void Push(int x)
        {
            int i = sz++;

            while (i > 0)
            {
                int p = (i - 1) / 2;

                if (heap[p] <= x) break;
                heap[i] = heap[p];
                i = p;
            }

            heap[i] = x;
        }

        public int Pop()
        {
            int ret = heap[0];

            int x = heap[--sz];

            int i = 0;
            while (i * 2 + 1 < sz)
            {
                int a = i * 2 + 1, b = i * 2 + 2;
                if (b < sz && heap[b] < heap[a]) a = b;

                if (heap[a] >= x) break;

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
