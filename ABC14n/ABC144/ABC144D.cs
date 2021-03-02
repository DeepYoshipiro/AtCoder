using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC144
{
    class ABC144D
    {
        static void Main(string[] args)
        {
            double[] init = ReadLine().Split(' ')
                .Select(n => double.Parse(n)).ToArray();
            double a = init[0];
            double b = init[1];
            double x = init[2];

            double h = x / Pow(a, 2);
            double tan_theta = a / 2 * (b - h);

            double theta = Atan(tan_theta) * 180.0 / PI;

            WriteLine(theta.ToString());
            ReadKey();
        }
    }
}