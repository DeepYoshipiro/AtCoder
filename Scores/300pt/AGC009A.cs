using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC009A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            long[] A = new long[N];
            int[] B = new int[N];

            for (int i = 0; i < N; i++)
            {
                int[] init = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                A[i] = init[0];
                B[i] = init[1];
            }

            long addNum = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                A[i] += addNum;
                if (A[i] % B[i] != 0) addNum += B[i] - (A[i] % B[i]);
            }

            WriteLine(addNum.ToString());
            ReadKey();
        }
    }
}        
