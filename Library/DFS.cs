using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Library
{
    class DFSTest
    {
        const int M = 2;

        static void Main(string[] args)
        {
            var A = new List<int>();
            DFS(A);
            ReadKey();
        }

        static void DFS(List<int> A)
        {
            if (A.Count() == 10)
            {
                Writer(A.ToList());
                return;
            }

            for (int i = 0; i < M; i++)
            {
                A.Add(i);
                DFS(A);
                A.RemoveAt(A.Count() - 1);
            }
        }

        static void Writer(List<int> A)
        {
            foreach (int a in A)
            {
                Write(a);
            }
            WriteLine();
        }
    }
}