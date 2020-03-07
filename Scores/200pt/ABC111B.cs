using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC111B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int result = (N + 110) / 111;
            result *= 111;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}