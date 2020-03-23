using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC159
{
    class ABC159C
    {
        static void Main(string[] args)
        {
            decimal L = decimal.Parse(ReadLine());
            decimal result = (L / 3) * (L / 3) * (L / 3);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
