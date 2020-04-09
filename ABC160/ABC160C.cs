using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC160
{
    class ABC160C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int K = init[0];
            int N = init[1];

            int[] A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int result = A.Last() - A.First();
            for (int i = 0; i < N - 1; i++)
            {
                if (result > A[i] + K - A[i + 1])
                    result = A[i] + K - A[i + 1];
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
