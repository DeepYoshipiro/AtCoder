using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC171
{
    class ABC171D
    {
        static void Main(string[] args)
        {
            var maxA = (int)Pow(10, 5);
            var N = int.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();

            var S = A.Sum();
            var cntA = new long[maxA + 1];
            for (int i = 0; i < N; i++)
            {
                cntA[A[i]]++;
            }

            var Q = int.Parse(ReadLine());

            var result = new List<long>();
            for (int j = 0; j < Q; j++)
            {
                var change = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                var B = change[0];
                var C = change[1];

                S -= B * cntA[B];
                S += C * cntA[B];
                result.Add(S);

                cntA[C] += cntA[B];
                cntA[B] = 0;
            }

            foreach (long sum in result)
            {
                WriteLine(sum.ToString());
            }

            ReadKey();
        }
    }
}
