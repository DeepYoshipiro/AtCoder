using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC145
{
    class ABC145E
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var T = init[1];
            int maxT = T + 3000;

            var dpSatisfy = new int[N + 1][]
                .Select(v => new int[maxT + 1]).ToArray();

            var A = new int[N + 1];
            var B = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                var info = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                A[i] = info[0];
                B[i] = info[1];
            }

            // dpSatisfy[1][0] = B[1];
            for (int i = 1; i <= N; i++)
            {                
                dpSatisfy[i] = (int[])dpSatisfy[i - 1].Clone();
                for (int j = 0; j < T; j++)
                {
                    dpSatisfy[i][j + A[i]]
                        = Max(dpSatisfy[i - 1][j + A[i]]
                            , dpSatisfy[i - 1][j] + B[i]
                            );
                }
            }

            WriteLine(dpSatisfy[N].Max().ToString());
            ReadKey();
        }
    }
}
