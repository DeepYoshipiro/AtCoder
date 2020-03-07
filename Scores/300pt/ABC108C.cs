using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC108C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            long result = 0;
            for (int a = 1; a <= N; a++)
            {
                int b = (K - a);
                if (b <= 0)
                {
                    b += N * K;
                    b %= K;
                }
                long satisfyB = N / K;
                if ((a - b) % K != 0) continue;
                if (N % K + a % K >= K) satisfyB++;
                
                long satisfyC = N / K;
                if (N % K + b % K >= K) satisfyC++;
                result += satisfyB * satisfyC;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
