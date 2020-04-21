using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC163
{
    class ABC163B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int[] A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            int result = (N - A.Sum() >= 0 ? N - A.Sum() : -1);
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
