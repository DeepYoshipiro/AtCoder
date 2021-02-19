using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC191
{
    class ABC191B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var X = init[1];

            var A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            var result = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                if (A[i] == X) continue;
                result.Append(A[i].ToString() + " ");
            }

            WriteLine(result);
            ReadKey();
        }
    }
}
