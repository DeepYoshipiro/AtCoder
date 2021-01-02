using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC187
{
    class ABC187A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];

            var SA = A / 100;
            A -= SA * 100;
            SA += A / 10;
            SA += A % 10;

            var SB = B / 100;
            B -= SB * 100;
            SB += B / 10;
            SB += B % 10;

            WriteLine(Max(SA, SB).ToString());
            ReadKey();
        }
    }
}
