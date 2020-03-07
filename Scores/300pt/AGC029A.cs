using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC029A
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();

            long result = 0;
            int whitePos = 0;
            for (int pos = 0; pos < S.Length; pos++)
            {
                if (S[pos].Equals('W'))
                {
                    result += pos - whitePos;
                    whitePos++;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}