using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC109
{
    class ARC109A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];
            var X = init[2];
            var Y = init[3];

            var diff = Abs(B - A);
            
            int result = 0;
            int nominee = 0;
            if (A > B)
            {
                result = X * (diff * 2 - 1);
                nominee = X + (diff - 1) * Y;
            }
            else
            {
                result = X * (diff * 2 + 1);
                nominee = X + diff * Y;
            }
            result = (nominee < result ? nominee : result);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
