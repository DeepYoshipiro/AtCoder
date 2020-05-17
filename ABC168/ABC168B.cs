using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC168
{
    class ABC168B
    {
        static void Main(string[] args)
        {
            var K = int.Parse(ReadLine());
            var S = ReadLine();

            if (S.Length > K)
            {
                S = S.Substring(0, K) + "...";
            }

            WriteLine(S);
            ReadKey();
        }
    }
}
