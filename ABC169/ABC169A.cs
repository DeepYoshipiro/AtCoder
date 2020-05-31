using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC169
{
    class ABC169A
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];

            int result = A * B;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
