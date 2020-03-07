using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class Nikkei2019_qualA
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int A = init[1];
            int B = init[2];

            WriteLine(Min(A, B).ToString() + " "
                 + Max(A + B - N, 0).ToString());
            ReadKey();
        }
    }
}