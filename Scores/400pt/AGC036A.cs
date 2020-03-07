using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class AGC036A
    {
        static void Main(string[] args)
        {
            long S = long.Parse(ReadLine());

            long X, y;
            long x, Y;

            if (S <= (long)Pow(10, 9))
            {
                X = S;
                y = 0;
                x = 0;
                Y = 1;
            } else {
                X = (long)Pow(10, 9);
                y = 1;
                Y = 1 + S / (long)Pow(10, 9);
                x = S % (long)Pow(10, 9);
            }

            WriteLine("0 0 " + X + " " + y + " " + x + " " + Y);
            ReadKey();
        }
    }
}