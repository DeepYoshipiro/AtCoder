using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC130C
    {
        static void Main(string[] args)
        {
            double[] init = ReadLine().Split(' ')
                .Select(n => double.Parse(n)).ToArray();
            double W = init[0];
            double H = init[1];
            double x = init[2];
            double y = init[3];

            double S = W * H / 2;

            bool result = false;
            if (x == W / 2 && y == H / 2) result = true;

            WriteLine(S.ToString() + " " + (result ? "1" : "0"));
            ReadKey();
        }
    }
}