using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC189
{
    class ABC189B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => decimal.Parse(n)).ToArray();
            var N = (int)init[0];
            var X = init[1];

            var V = new decimal[N];
            var P = new decimal[N];
            for (int i = 0; i < N; i++)
            {
                var drank = ReadLine().Split()
                    .Select(n => decimal.Parse(n)).ToArray();
                V[i] = drank[0];
                P[i] = drank[1];
            }

            decimal sumAlcohol = 0;
            for (int i = 0; i < N; i++)
            {
                var intake = V[i] * P[i] / 100;

                sumAlcohol += intake;
                if (sumAlcohol > X)
                {
                    WriteLine((i + 1).ToString());
                    ReadKey();
                    return;
                }
            }

            WriteLine("-1");
            ReadKey();
        }
    }
}
