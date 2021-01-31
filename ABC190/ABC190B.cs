using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC190
{
    class ABC190B
    {
        static void Main(string[] args)
        { 
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var S = init[1];
            var D = init[2];

            bool result = false;
            for (int i = 0; i < N; i++)
            {
                var spell = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var X = spell[0];
                var Y = spell[1];

                if (X < S && Y > D)
                {
                    result = true;
                }
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
