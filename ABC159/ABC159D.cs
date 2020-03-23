using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC159
{
    class ABC159D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine()); 
            int[] A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            long[] CntK = new long[N + 1];
            for (int i = 0; i < N; i++)
            {
                CntK[A[i]]++;
            }

            long Sum = 0;
            long[] SameK = new long[N + 1];
            for (int i = 0; i <= N; i++)
            {
                if (CntK[i] <= 1) continue;
                SameK[i] = (CntK[i] * (CntK[i] - 1)) / 2;
                Sum += SameK[i];
            }

            for (int i = 0; i < N; i++)
            {
                long result = Sum;
                if (CntK[A[i]] >= 1)
                {
                    result -= SameK[A[i]];
                    result += ((CntK[A[i]] - 1) * (CntK[A[i]] - 2)) / 2;
                }
                WriteLine(result.ToString());
            }
            ReadKey();
        }
    }
}