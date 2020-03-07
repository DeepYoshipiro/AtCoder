using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC151
{
    class ABC151B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];
            int M = init[2];

            int[] A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            int result = N * M;
            for (int i = 0; i < N - 1; i++)
            {
                result -= A[i];
            }

            if (result < 0)
            {
                result = 0;
            }
            else if (result > K)
            {
                result = -1;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
