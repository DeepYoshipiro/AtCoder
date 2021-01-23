// Solution : String Operation
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC049C
    {
        static void Main(string[] args)
        {
            StringBuilder S = new StringBuilder();
            S.Append(ReadLine());

            S.Replace("eraser", "").Replace("erase", "")
                .Replace("dreamer", "").Replace("dream", "");

            WriteLine(S.Length == 0 ? "YES" : "NO");
            ReadKey();
        }
    }
}