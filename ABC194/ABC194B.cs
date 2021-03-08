using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC194
{
    class ABC194B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = new int[N];
            var B = new int[N];

            const int INF = int.MaxValue / 2;
            var result = INF;
            
            for (int i = 0; i < N; i++)
            {
                var takeMin = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                A[i] = takeMin[0];
                B[i] = takeMin[1];

                result = A[i] + B[i] < result ? A[i] + B[i] : result;
            }

            Array.Sort(A);
            Array.Sort(B);

            if (A[0] + B[0] == result)
            {
                if (A[0] == A[1] || B[0] == B[1])
                {
                    result = Max(A[0], B[0]);
                }
                else
                {
                    result = Min(result, Min(Max(A[1], B[0]), Max(A[0], B[1])));
                }
            } 
            else
            {
                result = Max(A[0], B[0]);
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
