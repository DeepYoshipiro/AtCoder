using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC080D
    {
        static void Main(string[] args)
        {
            int END_BROADCAST_TIME = 2 * 100000;
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var C = init[1];

            var reserve = new int[C + 1][];
            for (int j = 0; j <= C; j++)
            {
                reserve[j] = new int[END_BROADCAST_TIME + 1];
            }

            for (int i = 0; i < N; i++)
            {
                var que = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var s = que[0] * 2 - 1;
                var t = que[1] * 2;
                var ch = que[2];

                reserve[ch][s]++;
                reserve[ch][t]--;
            }

            for (int ch = 1; ch <= C; ch++)
            {
                for (int i = 2; i <= END_BROADCAST_TIME; i++)
                {
                    reserve[ch][i] += reserve[ch][i - 1];
                }
            }

            int result = 0;
            for (int i = 1; i <= END_BROADCAST_TIME; i++)
            {
                for (int ch = 1; ch <= C; ch++)
                {
                    reserve[0][i] += Sign(reserve[ch][i]);
                }
                if (reserve[0][i] > result) result = reserve[0][i];
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
