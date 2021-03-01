using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC193
{
    class ABC193B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var result = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                var stock = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var A = stock[0];
                var P = stock[1];
                var X = stock[2];

                if (A <= X - 1)
                {
                    result = P < result ? P : result;
                }
            }

            if (result == int.MaxValue) result = -1;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
