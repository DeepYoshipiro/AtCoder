using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC154
{
    class ABC154D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            decimal[] p = ReadLine().Split(' ')
                .Select(n => decimal.Parse(n)).ToArray();

            decimal curSum = 0;
            for (int i = 0; i < K; i++)
            {
                curSum += p[i];
            }

            decimal maxSum = curSum;
            for (int i = 0; i < N - K; i++)
            {
                curSum -= p[i];
                curSum += p[i + K];
                if (curSum > maxSum) maxSum = curSum;
            }

            decimal result = (K + maxSum) / 2; 

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
