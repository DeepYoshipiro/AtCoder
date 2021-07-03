using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC207
{
    class ABC207B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];
            var C = init[2];
            var D = init[3];

            if (C * D - B == 0)
            {
                WriteLine("-1");
                ReadKey();
                return;
            }
            
            var result = (A + (C * D - B - 1)) / (C * D - B);
            if (result <= 0) result = -1;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
