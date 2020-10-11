using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC105
{
    class ARC105A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];
            var C = init[2];
            var D = init[3];

            bool result = false;
            if (A == B + C + D) result = true;
            if (B == A + C + D) result = true;
            if (C == A + B + D) result = true;
            if (D == A + B + C) result = true;

            if (A + B == C + D) result = true;
            if (A + C == B + D) result = true;
            if (A + D == B + C) result = true;

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
