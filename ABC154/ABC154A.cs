using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC154
{
    class ABC154A
    {
        static void Main(string[] args)
        {
            string[] init = ReadLine().Split(' ').ToArray();
            string S = init[0];
            string T = init[1];

            int[] ball = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int A = ball[0];
            int B = ball[1];

            string U = ReadLine();

            if (U == S)
            {
                A--;
            }
            else
            {
                B--;
            }

            WriteLine(A.ToString() + " " + B.ToString());
            ReadKey();
        }
    }
}
