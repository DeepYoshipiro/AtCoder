using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC196
{
    class ABC196A
    {
        static void Main(string[] args)
        {
            var init1 = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var A = init1[0];
            var B = init1[1];

            var init2 = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var C = init2[0];
            var D = init2[1];
            
            var result = Max(A - C, A - D);
            result = Max(result, B - C);
            result = Max(result, B - D);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
