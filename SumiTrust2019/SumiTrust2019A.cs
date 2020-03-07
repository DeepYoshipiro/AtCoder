using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace SumiTrust2019
{
    class SumiTrust2019A
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int M1 = first[0];
            int D1 = first[1];

            int[] next = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int M2 = next[0];
            int D2 = next[1];

            WriteLine(M1 == M2 ? "0" : "1");
            ReadKey();
        }
    }
}
