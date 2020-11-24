using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC172
{
    class ABC172C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = (int)init[0];
            var M = (int)init[1];
            var K = init[2];

            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var B = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();

            Array.Reverse(A);

            var time = new long[N + M + 1];
            for (int i = 1; i <= N; i++)
            {
                time[i] = time[i - 1] + A[i - 1];    
            }
            for (int j = 0; j < M; j++)
            {
                time[N + j + 1] = time[N + j] + B[j];
            }

            int result = 0;
            int r = 1;
            for (int l = 0; l <= N; l++)
            {
                while (r <= N + M && time[r] - time[l] <= K)
                {
                    if (r >= N) result = Max(r - l, result);
                    r++;
                }
                if (r > N + M) break;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
