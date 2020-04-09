using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace JudgeUpdate202004
{
    class JudgeUpdate202004_A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int S = init[0];
            int L = init[1];
            int R = init[2];

            if (S < L)
            {
                WriteLine(L.ToString());
            }
            else if (R < S)
            {
                WriteLine(R.ToString());
            }
            else
            {
                WriteLine(S.ToString());
            }
            ReadKey();
        }
    }
}
