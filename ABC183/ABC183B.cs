using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC183
{
    class ABC183B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => double.Parse(n)).ToArray();
            var Sx = init[0];
            var Sy = init[1];
            var Gx = init[2];
            var Gy = -init[3];

            var diffX = (Gx - Sx);
            var diffY = (Gy - Sy);

            var x = Sx - diffX / diffY * Sy;

            WriteLine(x.ToString());
            ReadKey();
        }
    }
}
