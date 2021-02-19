using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC191
{
    class ABC191A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var V = init[0];
            var T = init[1];
            var S = init[2];
            var D = init[3];

            if (V * T <= D && D <= V * S)
            {
                WriteLine("No");
                ReadKey();
                return;
            }

            WriteLine("Yes");
            ReadKey();
        }
    }
}
