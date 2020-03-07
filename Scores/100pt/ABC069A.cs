using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC069A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(k => int.Parse(k)).ToArray();
            int n = init[0];
            int m = init[1];

            int result = (n - 1) * (m - 1);
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}