using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC200
{
    class ABC200A
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            WriteLine((N + 99) / 100);
            ReadKey();
        }
    }
}
