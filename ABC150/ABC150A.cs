using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC150
{
    class ABC150A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int K = init[0];
            int X = init[1];

            if (K * 500 >= X)
            {
                WriteLine("Yes");
            }
            else
            {
                WriteLine("No");
            }
            ReadKey();
        }
    }
}
