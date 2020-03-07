using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC094A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];
            int X = init[2];

            string result =  (A <= X && A + B >= X) ? "YES" : "NO";

            WriteLine(result);
            ReadKey();
        }
    }
}
            