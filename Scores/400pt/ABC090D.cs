using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC090D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            long result = 0;

            for (int b = 1; b <= N; b++)
            {
                if (b <= K) continue;
                if (K == 0)
                {
                    result += N;
                    continue;
                }
                int q = N / b;
                int r = N % b;

                result += q * (b - K);
                if (r >= K) result += r - K + 1;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
