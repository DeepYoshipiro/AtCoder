using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC090A
    {
        static void Main(string[] args)
        {
            char[] c0 = ReadLine().ToCharArray();
            char[] c1 = ReadLine().ToCharArray();
            char[] c2 = ReadLine().ToCharArray();

            StringBuilder result = new StringBuilder();
            result.Append(c0[0]);
            result.Append(c1[1]);
            result.Append(c2[2]);

            WriteLine(result);
            ReadKey();
        }
    }
}