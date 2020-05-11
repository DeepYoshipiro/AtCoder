using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC167
{
    class ABC167A
    {
        static void Main(string[] args)
        {
            string S = ReadLine();
            string T = ReadLine();

            bool result = false;
            if (S.Length + 1 == T.Length
                && S.Equals(T.Substring(0, S.Length)))
                result = true;

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
