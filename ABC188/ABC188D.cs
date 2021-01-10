using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC188
{
    class ABC188D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = (int)init[0];
            var packC = init[1];

            var sumC = new Dictionary<long, long>();
            for (int i = 0; i < N; i++)
            {
                var use = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                var A = use[0];
                var B = use[1];
                var C = use[2];

                if (sumC.ContainsKey(A))
                {
                    sumC[A] += C;
                }
                else
                {
                    sumC.Add(A, C);
                }

                if (sumC.ContainsKey(B + 1))
                {
                    sumC[B + 1] -= C;
                }
                else
                {
                    sumC.Add(B + 1, -C);
                }
            }

            var sortedC = sumC.OrderBy(c => c.Key).ToList();
            long costByDay = 0; 
            long result = 0;
            for (int i = 0; i < sortedC.Count() - 1; i++)
            {
                long term = sortedC[i + 1].Key - sortedC[i].Key;
                costByDay += sortedC[i].Value;
                result += (costByDay > packC ? packC : costByDay)
                             * term;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
