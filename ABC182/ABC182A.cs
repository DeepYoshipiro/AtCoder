using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC182
{
    class ABC182A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];

            var limFollow = 2 * A + 100;
            var result = limFollow - B; 

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}