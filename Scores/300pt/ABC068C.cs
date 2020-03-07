using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC068C
    {
        static void Main(string[] args)
        {
            long x = long.Parse(ReadLine());

            long q = x / 11;
            long r = x % 11;

            long result = 2 * q;
            if (r > 6)
                result += 2;
            else if (r > 0)
                result++;
            
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}