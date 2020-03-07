using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC156
{
    class ABC156A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int R = init[1];

            if (N < 10)
            {
                R += 100 * (10 - N);
            }

            WriteLine(R.ToString());
            ReadKey();
        }
    }
}
