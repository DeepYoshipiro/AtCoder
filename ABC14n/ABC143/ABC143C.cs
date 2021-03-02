using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC143
{
    class ABC143C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] S = ReadLine().ToCharArray();

            int result = 1;
            char curColor = S[0];
            for (int i = 1; i < N; i++)
            {
                if (curColor != S[i])
                {
                    result++;
                    curColor = S[i];
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}