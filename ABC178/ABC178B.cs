using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC178
{
    class ABC178B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var a = init[0];
            var b = init[1];
            var c = init[2];
            var d = init[3];

            var result = a * c;
            result = (a * d > result ? a * d : result);
            result = (b * c > result ? b * c : result);
            result = (b * d > result ? b * d : result);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
