using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC104
{
    class ARC104A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];

            var X = (A + B) / 2;
            var Y = (A - B) / 2;

            WriteLine("{0} {1}", X, Y);
            ReadKey();
        }
    }
}
