using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC160
{
    class ABC160B
    {
        static void Main(string[] args)
        {
            int X = int.Parse(ReadLine());
            int yen500 = X / 500;
            long result = yen500 * 1000;
            X %= 500;

            int yen005 = X / 5;
            result += yen005 * 5;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
