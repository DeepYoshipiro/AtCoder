using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC128
{
    class ABC128D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(m => int.Parse(m)).ToArray();
            // 1≤N≤50
            int N = init[0];
            // 1≤K≤100
            int K = init[1]; 
            // −10^7≤Vi≤10^7
            long[] V = ReadLine().Split()
                .Select(m => long.Parse(m)).ToArray();

            long[][] Sum = new long[N][];
            List<long>[][] Detail = new List<long>[N][];
            Sum[0] = new long[N];
            Detail[0] = new List<long>[N];

            Sum[0][0] = 0;
            Detail[0][0] = new List<long>();
            for (int n = 1; n < N; n++)
            {
                Sum[n] = new long[N];
                Detail[n] = new List<long>[N];

                for (int k = 0; k < n; k++)
                {

                }
            }
            /*
            PriorityQueue[][] pque = new PriorityQueue(N)[N];
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
            */
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
