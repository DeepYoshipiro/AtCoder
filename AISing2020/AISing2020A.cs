using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace AISing2020
{
    class AISing2020A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var L = init[0];
            var R = init[1];
            var d = init[2];

            var result = (R / d) - ((L - 1) / d);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
