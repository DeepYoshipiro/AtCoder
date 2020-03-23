﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC159
{
    class ABC159A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            WriteLine((N * (N - 1) + M * (M - 1)) / 2);
            ReadKey();
        }
    }
}
