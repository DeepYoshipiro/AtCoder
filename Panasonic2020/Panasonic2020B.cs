using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Panasonic2020
{
    class Panasonic2020B
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long H = init[0];
            long W = init[1];

            long result = (H * W + 1) / 2;
            if (H == 1 || W == 1) result = 1;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
