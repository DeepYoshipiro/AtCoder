using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace TDPC
{
    class TDPC_D
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long N = init[0];
            long D = init[1];


//            decimal[][] dpCases = new decimal[N + 1][];
            Dictionary<long, decimal>[] dpProba
                = new Dictionary<long, decimal>[N + 1];

            HashSet<long> appeared = new HashSet<long>();
            dpProba[1] = new Dictionary<long, decimal>();
            for (int i = 1; i <= 6 ; i++)
            {
                long m = (i % D);
                if (dpProba[1].ContainsKey(m))
                {
                    dpProba[1][m] += 1M / 6M;
                }
                else
                {
                    dpProba[1].Add(m, (1M /6M));
                }
                appeared.Add(m);
            }

            for (int n = 2; n <= N; n++)
            {
                dpProba[n] = new Dictionary<long, decimal>();
                HashSet<long> new_appear = new HashSet<long>();
                foreach (long l in appeared)
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        long m = (l * i) % D;
                        if (dpProba[n].ContainsKey(m))
                        {
                            dpProba[n][m] += dpProba[n - 1][l] / 6M;
                        }
                        else
                        {
                            dpProba[n].Add(m, dpProba[n - 1][l] / 6M);
                        }

                        new_appear.Add(m);
                    }
                }
                appeared.UnionWith(new_appear);
            }

            decimal result
             = (dpProba[N].ContainsKey(0) ? dpProba[N][0] : 0);
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}