using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC071A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int x = init[0];
            int a = init[1];
            int b = init[2];

            WriteLine(Abs(x - a) < Abs(x - b) ? "A" : "B");
            ReadKey();
        }
    }
}
