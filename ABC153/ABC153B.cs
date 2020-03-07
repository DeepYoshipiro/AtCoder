using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC153
{
    class ABC153B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int N = init[1];
            int A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).Sum();

            WriteLine(H - A <= 0 ? "Yes" : "No");
            ReadKey();
        }
    }
}
