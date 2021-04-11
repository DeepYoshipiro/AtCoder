using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC198
{
    class ABC198C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => double.Parse(n)).ToArray();
            var R = init[0];
            var X = init[1];
            var Y = init[2];

            var dist = Sqrt(X * X + Y * Y);
            var result = (int)Ceiling(dist / R);
            if (result == 1 && (int)dist != (int)R)
            {
                result++;
            } 

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
