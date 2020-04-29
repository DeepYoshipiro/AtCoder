using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class IndeedNow_qualB_C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            bool[] visited = new bool[N + 1];

            PriorityQueue_Asc[] to = new PriorityQueue_Asc[N + 1];
            for (int i = 1; i <= N; i++)
            {
                to[i] = new PriorityQueue_Asc();
            }

            for (int i = 0; i < N - 1; i++)
            {
                int[] way = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                to[way[0]].Push(way[1]);
                to[way[1]].Push(way[0]);
            }

            PriorityQueue_Asc nextVisit = new PriorityQueue_Asc();
            nextVisit.Push(1);

            StringBuilder result = new StringBuilder();
            while (nextVisit.Count() > 0)
            {
                int cur = nextVisit.Pop();
                if (visited[cur]) continue;
                result.Append(cur.ToString() + " ");
                visited[cur] = true;

                while (to[cur].Count() > 0)
                {
                    int next = to[cur].Pop();
                    if (visited[next]) continue;
                    nextVisit.Push(next);                    
                }
            }

            WriteLine(result.ToString().TrimEnd(' '));
            ReadKey();
        }
    }

    internal class PriorityQueue_Asc
    {
        List<int> data;
        internal PriorityQueue_Asc()
        {
            data = new List<int>();
        }

        internal void Push(int x)
        {
            int cur = data.Count();
            data.Add(x);
            UpHeap(cur);
        }

        internal int Pop()
        {
            int ret = data.First();
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
            if (data[child] < data[parent])
            {
                int A = data[child];
                int B = data[parent];
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
            if (parent * 2 + 1 < Count() && data[parent * 2 + 1] < data[parent])
            {
                child = parent * 2 + 1;                
            }

            if (parent * 2 + 2 < Count() && data[parent * 2 + 2] < data[parent])
            {
                if (child != parent * 2 + 1
                    || data[parent * 2 + 1] > data[parent * 2 + 2])
                {
                    child = parent * 2 + 2;
                }                
            }

            if (child > parent)
            {
                int A = data[child];
                int B = data[parent];
                data[child] = B;
                data[parent] = A;
                DownHeap(child);
            }
        }
    }
}