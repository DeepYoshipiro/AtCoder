using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace ABC141
{
    class ABC141D
    {
        static int[] heap;
        static int sz = 0;

        static void push(int x)
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

        static int pop()
        {
            int ret = heap[0];
            int x = heap[--sz];
            heap[sz] = 0;

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
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
               .Select(n => int.Parse(n)).ToArray();

            int N = init[0];    //品物数
            int M = init[1];    //割引券枚数

            int[] price = ReadLine().Split(' ')
               .Select(n => int.Parse(n)).OrderByDescending(n => n).ToArray();

            heap = new int[N];
            for (int i = 0; i < N; i++)
            {
                push(price[i]);
            }

            for (int m = M; m > 0; m--)
            {
                int item = pop();
                item /= 2;
                push(item);
            }

            long total = 0;
            while (sz > 0)
            {
                total += pop();
            }

            WriteLine(total.ToString());
            ReadKey();
        }
    }
}

