using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC192
{
    class ABC192A
    {
        static void Main(string[] args)
        {
            var X = int.Parse(ReadLine());

            var result = 100 - (X % 100);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
