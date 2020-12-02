using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC173
{
    class ABC173D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var A = ReadLine().Split()
                .Select(n => long.Parse(n))
                .OrderByDescending(n => n).ToArray();

            long result = A[0];

            for (int i = 2; i < N; i++)
            {
                result += A[i / 2];
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
