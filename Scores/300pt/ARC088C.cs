using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC088C
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long X = init[0];
            long Y = init[1];

            int result = 1;
            while (X * 2 <= Y)
            {
                X *= 2;
                result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
