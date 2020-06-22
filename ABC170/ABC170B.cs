using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC170
{
    class ABC170B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            var X = init[0];
            var Y = init[1];

            var t = Y - 2 * X;
            if (t % 2 != 0 || 2 * t > Y || t < 0)
            {
                WriteLine("No");
            }
            else
            {
                WriteLine("Yes");
            }

            ReadKey();
        }
    }
}
