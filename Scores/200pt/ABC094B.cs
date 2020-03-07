using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC094B
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];
            int X = init[2];

            List<int> A = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToList();
            int[] gateSum = new int[N + 1];

            int gateCnt = 0;
            for (int i = 0; i <= N; i++)
            {
                if (A.Count > 0 && A[0] == i)
                {
                    gateCnt++;
                    A.RemoveAt(0);
                }
                gateSum[i] = gateCnt;
            }

            int result = Min(gateSum[X], gateSum[N] - gateSum[X]);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}