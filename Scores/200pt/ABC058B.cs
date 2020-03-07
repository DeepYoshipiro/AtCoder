using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC058B
    {
        static void Main(string[] args)
        {
            char[] O = Console.ReadLine().ToCharArray();
            char[] E = Console.ReadLine().ToCharArray();

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < Min(O.Length, E.Length); i++)
            {
                result.Append(O[i]);
                result.Append(E[i]);
            }

            if (O.Length > E.Length)
                result.Append(O.Last());

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}