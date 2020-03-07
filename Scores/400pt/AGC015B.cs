using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class AGC015B
    {
        static void Main(string[] args)
        {
            char[] S = new char[]{' '}
                .Concat(ReadLine().ToCharArray()).ToArray();

            int floors = S.Length - 1;
            int result = 0;
            for (int i = 1; i <= floors; i++)
            {
                int toUp = S[i].Equals('U') ? 1 : 2;
                int toDown = S[i].Equals('D') ? 1 : 2;
                result += (floors - i) * toUp + (i - 1) * toDown;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}