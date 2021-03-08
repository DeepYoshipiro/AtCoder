using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC194
{
    class ABC194A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];

            int result = 0;
            if (A + B >= 15 && B >= 8)
            {
                result = 1;
            }
            else if (A + B >= 10 && B >= 3)
            {
                result = 2;
            }
            else if (A + B >= 3)
            {
                result = 3;
            }
            else
            {
                result = 4;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
