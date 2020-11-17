using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC183
{
    class ABC183A
    {
        static void Main(string[] args)
        {
            var x = int.Parse(ReadLine());
            if (x < 0) x = 0;

            WriteLine(x.ToString());
            ReadKey();
        }
    }
}
