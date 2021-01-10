using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC188
{
    class ABC188A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var X = init[0];
            var Y = init[1];

            WriteLine(Min(X, Y) + 3 > Max(X, Y) ? "Yes" : "No"); 
            ReadKey();
        }
    }
}
