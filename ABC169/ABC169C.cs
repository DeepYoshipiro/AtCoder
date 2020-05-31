using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC169
{
    class ABC169C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => decimal.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];

            var result = Floor(A * B);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
