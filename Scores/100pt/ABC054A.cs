using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC054A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];

            if (A == 1) A = 14;
            if (B == 1) B = 14;

            if (A == B)
            {
                WriteLine("Draw");
            }
            else if (A > B)
            {
                WriteLine("Alice");
            }
            else
            {
                WriteLine("Bob");
            }
            ReadKey();
        }
    }
}
            