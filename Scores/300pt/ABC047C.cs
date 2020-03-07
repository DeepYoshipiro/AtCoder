using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC047C
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();

            int result = 0;
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (!S[i].Equals(S[i + 1])) result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}