using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC146
{
    class ABC146B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] S = ReadLine().ToCharArray();
            char[] order = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                result.Append(order[(S[i] - 'A' + N) % 26]);
            }

            WriteLine(result);
            ReadKey();
        }
    }
}
