using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Library
{
    class LibraryTest
    {
        static void Main(string[] args)
        {
            // // Swap, GCD
            // int A = 38;
            // int B = 16;
            // BaseAlgorithm ba = new BaseAlgorithm();
            // ba.Swap(ref A, ref B);            
            // // WriteLine("{0} {1}", A, B);
            // NumberTheory nt = new NumberTheory();
            // int result = nt.GCD(A, B);
            // WriteLine(result.ToString());

            // // Priority Queue
            // int[] input = {6, 9, 5, 7, 5, 0, 4, 2, 2, 7};
            // var pq = new PriorityQueue_Asc();

            // for (int i = 0; i < input.Length; i++)
            // {
            //     pq.Push(input[i]);
            // }

            // while (pq.Count() > 0)
            // {
            //     WriteLine(pq.Pop());
            // }

            // BinaryTree
            
            ReadKey();
        }
    }

    public class BaseAlgorithm
    {
        public void Swap(ref int A, ref int B)
        {
            int tmp = A;
            A = B;
            B = tmp;
        }

        public void Swap(int A, int B)
        {
            int tmp = A;
            A = B;
            B = tmp;
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
                // var ba = new BaseAlgorithm();
                // ba.Swap(data[child], data[parent]);
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
                // var ba = new BaseAlgorithm();
                // ba.Swap(data[child], data[parent]);
                int A = data[child];
                int B = data[parent];
                data[child] = B;
                data[parent] = A;
                DownHeap(child);
            }
        }
    }
}
