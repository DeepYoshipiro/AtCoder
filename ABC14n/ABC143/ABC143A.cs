using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC143
{
    class ABC143A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];

            int result = A - 2 * B;
            if (result < 0) result = 0;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
