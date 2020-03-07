using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC150
{
    class ABC150B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            string S = ReadLine();

            S = S.Replace("ABC", "");
            int result = (N - S.Length) / 3;

            WriteLine(result);
            ReadKey();
        }
    }
}
