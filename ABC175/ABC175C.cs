using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC175
{
    class ABC175C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var X = Abs(init[0]);
            var K = init[1];
            var D = init[2];

            var result = X - (X / D <= K ? X / D : K) * D;
            if (result - D < 0)
            {
                K -= X / D;
                if (K % 2 == 1)
                {
                    result -= D;
                    result = Abs(result);
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

