using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC163
{
    class ABC163A
    {
        static void Main(string[] args)
        {
            double R = double.Parse(ReadLine());

            WriteLine(2 * PI * R);
            ReadKey();
        }
    }
}
