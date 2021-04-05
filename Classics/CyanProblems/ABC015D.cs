using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ABC015D
    {
        static void Main(string[] args)
        {
            var W = int.Parse(ReadLine());
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            var dpImportance = new int[W + 1][]
                .Select(v => new int[K + 1]).ToArray();

            var result = 0;

            for (int i = 1; i <= N; i++)
            {
                var evidence = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var A = evidence[0];
                var B = evidence[1];

                for (int j = W; j >= 0; j--)
                {
                    for (int k = 0; k < K; k++)
                    {
                        if (k == 0 && j > 0) continue;
                        if (k >= 1 && dpImportance[j][k] == 0) continue;
                        if (j + A > W) continue;

                        var oldValue = dpImportance[j + A][k + 1];
                        var newValue = dpImportance[j][k] + B;
                        dpImportance[j + A][k + 1]
                            = (newValue > oldValue)
                                ? newValue : oldValue;
                        result = Max(result, dpImportance[j + A][k + 1]);
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
