using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC161
{
    class ABC161A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int X = init[0];
            int Y = init[1];
            int Z = init[2];

            WriteLine("{0} {1} {2}", Z, X, Y);
            ReadKey();
        }
    }
}
