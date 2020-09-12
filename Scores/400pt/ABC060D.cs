using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC060D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var W = init[1];

            var weight = new int[N + 1];
            var value = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                var item = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                weight[i] = item[0];
                value[i] = item[1];
            }

            var baseWeight = weight[1];
            var ableWeight = new List<int>();
            ableWeight.Add(0);
            for (int i = 1; i < N; i++)
            {
                if (baseWeight * i > W) break;
                for (int j = 0; j <= 3 * i; j++)
                {
                    if (baseWeight * i + j > W) break;
                    ableWeight.Add(baseWeight * i + j);
                }
            }

            var sumWeight = ableWeight.Distinct().OrderBy(n => n).ToArray();
            W = sumWeight.Last();
            var dicWeightNum = new Dictionary<int, int>();
            for (int i = 0; i < sumWeight.Count(); i++)
            {
                dicWeightNum[sumWeight[i]] = i;
            }

            var dpValue = new int[N + 1][];
            dpValue[0] = new int[dicWeightNum.Count()];

            for (int i = 1; i <= N; i++)
            {
                dpValue[i] = new int[dicWeightNum.Count()];
                for (int j = 0; j < dicWeightNum.Count(); j++)
                {
                    dpValue[i][j] = dpValue[i - 1][j];
                }

                for (int j = 0; j < dicWeightNum.Count(); j++)
                {
                    if (sumWeight[j] + weight[i] > W) break;
                    int num = dicWeightNum[sumWeight[j] + weight[i]];
                    dpValue[i][num] = Max(dpValue[i - 1][num], dpValue[i - 1][j] + value[i]);
                }
            }

            WriteLine(dpValue[N].Max().ToString());
            ReadKey();
        }
    }
}
