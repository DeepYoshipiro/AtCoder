using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC125Drev
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            long[] A = ReadLine().Split()
                .Select(m => long.Parse(m))
                .ToArray();

            long[] dp = new long[N];
            for (int i = 0; i < N; i++)
            {
                dp[i] = long.MinValue;
            }

            if (A[0] < -A[0])
            {
                A[1] *= -1;
            }
            dp[0] = Max(A[0], -A[0]);
            
            for (int i = 1; i < N - 1; i++)
            {
                dp[i] = dp[i - 1] + A[i];
                if (dp[i] < dp[i - 1] - A[i])
                {
                    dp[i] = dp[i - 1] - A[i];
                    A[i + 1] *= -1;
                }
            }
 
            dp[N - 1] = dp[N - 2] + A[N - 1];
            WriteLine(dp[N - 1].ToString());
            ReadKey();
        }
    }
}
