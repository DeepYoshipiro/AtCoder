using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC196
{
    class ABC196B
    {
        static void Main(string[] args)
        {
            var X = ReadLine();
            var period = X.IndexOf('.');
            if (period < 0)
            {
                WriteLine(X);
            }
            else
            {
                WriteLine(X.Substring(0, period));
            }

            ReadKey();
        }
    }
}
