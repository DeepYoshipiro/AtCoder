using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC194
{
    class ABC194C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var squareA = N * A.Select(n => n * n).Sum();
            var result = squareA - A.Sum() * A.Sum();

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
