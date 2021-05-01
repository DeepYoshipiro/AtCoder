using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ZONe2021
{
    class ZONe2021B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => decimal.Parse(n)).ToArray();
            var N = (int)init[0];
            var D = init[1];
            var H = init[2];

            decimal Y = 0;
            for (int i = 0; i < N; i++)
            {
                var t = ReadLine().Split()
                    .Select(n => decimal.Parse(n)).ToArray();
                var d = t[0];
                var h = t[1];

                if ((H - Y) * d / D + Y < h)
                {
                    Y = (H - h) * (-d) / (D - d) + h;
                }             
            }

            WriteLine(Y.ToString());
            ReadKey();
        }
    }
}
