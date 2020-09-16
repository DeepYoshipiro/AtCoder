using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC178
{
    class ABC178A
    {
        static void Main(string[] args)
        {
            var x = int.Parse(ReadLine());

            WriteLine((1 - x).ToString());
            ReadKey();
        }
    }
}
