using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC151
{
    class ABC151A
    {
        static void Main(string[] args)
        {
            char[] C = ReadLine().ToCharArray();

            C[0]++;
            WriteLine(C[0]);
            ReadKey();
        }
    }
}
