using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Panasonic2020
{
    class Panasonic2020C
    {
        static void Main(string[] args)
        {
            double[] init = ReadLine().Split(' ')
                .Select(n => double.Parse(n)).ToArray();
            double a = init[0];
            double b = init[1];
            double c = init[2];

            bool result;
            if (Sqrt(c) - (Sqrt(a) + Sqrt(b)) > Pow(10, -6) )
            {
                result = true;
            }
            else
            {
                result = false;
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
