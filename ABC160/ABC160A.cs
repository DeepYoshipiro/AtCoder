using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC160
{
    class ABC160A
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();
            WriteLine((S[2] == S[3] && S[4] == S[5]) ? "Yes" : "No");
            ReadKey();
        }
    }
}
