using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC120C
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();

            int red = 0;
            int blue = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i].Equals('0'))
                    red++;
                else
                    blue++;
            }

            int result = Min(red, blue) * 2;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}