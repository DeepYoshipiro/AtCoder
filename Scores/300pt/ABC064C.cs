using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC064C
    {
        static void Main(string[] args)
        {
            const int COLOR_CNT = 8;
            const int RANK_RANGE = 400;
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int[] rank = new int[COLOR_CNT];

            int over3200 = 0;
            for (int i = 0; i < N; i++)
            {
                if (a[i] >= COLOR_CNT * RANK_RANGE)
                {
                    over3200++;
                }
                else
                {
                    rank[a[i] / RANK_RANGE] = 1;
                }
            }

            int tmpResult = rank.Sum();
            int minResult = (tmpResult == 0 ? 1 : tmpResult);
            int maxResult = tmpResult + over3200;

            WriteLine(minResult.ToString() + " " + maxResult.ToString());
            ReadKey();
        }
    }
}