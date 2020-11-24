using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC184
{
    class ABC184A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];

            init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var C = init[0];
            var D = init[1];

            WriteLine((A * D - B * C).ToString());
            ReadKey();
        }
    }
}
