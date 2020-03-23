using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC158
{
    class ABC158A
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();
            bool result = !(S[0] == S[1] && S[1] == S[2]);

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
