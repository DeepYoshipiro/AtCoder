using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC159
{
    class ABC159B
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();
            int N = S.Length;
            bool result = true;
            for (int i = 0; i < (N - 1) / 2; i++)
            {
                if (S[i] != S[i + (N + 1) / 2])
                {
                    result = false;
                    break;
                }
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
