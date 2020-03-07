using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC153
{
    class ABC153A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int A = init[1];

            int result = (H + A - 1) / A;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
