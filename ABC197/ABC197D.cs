using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC197
{
    class ABC197D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var p0 = ReadLine().Split()
                .Select(n => double.Parse(n)).ToArray();
            var x0 = p0[0];
            var y0 = p0[1];

            var oppositeP = ReadLine().Split()
                .Select(n => double.Parse(n)).ToArray();
            var oppositeX = oppositeP[0];
            var oppositeY = oppositeP[1];

            var adjustX = (x0 + oppositeX) / 2;
            var adjustY = (y0 + oppositeY) / 2;

            x0 -= adjustX;
            y0 -= adjustY;

            oppositeX -= adjustX;
            oppositeY -= adjustY;

            var theta = PI / (N / 2);
            var x1 = x0 * Cos(theta) - y0 * Sin(theta);
            var y1 = x0 * Sin(theta) + y0 * Cos(theta);

            x1 += adjustX;
            y1 += adjustY;

            WriteLine("{0} {1}", x1, y1);
            ReadKey();
        }
    }
}
