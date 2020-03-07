using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;


namespace _300pt
{
    class AGC037A
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();

            int result = 1;
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i].Equals(S[i + 1]))
                {
                    i++;
                }
                result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}