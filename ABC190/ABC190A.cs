using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC190
{
    class ABC190A
    {
        static void Main(string[] args)
        { 
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init[0];
            var B = init[1];
            var C = init[2];

            if (A == B)
            {
                switch (C)
                {
                    case 0:
                        WriteLine("Aoki");
                        ReadKey();
                        return;
                    case 1:
                        WriteLine("Takahashi");
                        ReadKey();
                        return;
                }
            }

            WriteLine(A > B ? "Takahashi" : "Aoki");
            ReadKey();
        }
    }
}
