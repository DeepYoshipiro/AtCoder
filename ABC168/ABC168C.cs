using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC168
{
    class ABC168C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => double.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];

            var H = init[2];
            var M = init[3];

            var argH = H * 30 + (M / 60) * 30;
            var argM = 6 * M;

            var theta = (argH - argM) * 2 * PI / 360;             
            var result = Sqrt(A * A + B * B - 2 * A * B * Cos(theta));

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
