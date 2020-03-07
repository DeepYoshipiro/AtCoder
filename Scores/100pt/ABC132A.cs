using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC132A
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();
            Array.Sort(S);

            bool result;
            if (S[0].Equals(S[1]) && S[2].Equals(S[3]) && !S[1].Equals(S[2]))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}