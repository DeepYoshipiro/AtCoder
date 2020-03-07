using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC053A
    {
        static void Main(string[] args)
        {
            int x = int.Parse(ReadLine());

            if (x >= 1200)
                WriteLine("ARC");
            else
                WriteLine("ABC");

            ReadKey();
        }
    }
}