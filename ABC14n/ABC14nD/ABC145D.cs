using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC145
{
    class ABC145D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
            int X = init[0];
            int Y = init[1];

            if ((X + Y) % 3 != 0)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            int trialCnt = (X + Y) / 3;
            X -= trialCnt;
            Y -= trialCnt;

            if (X < 0 || Y < 0)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            double result = 1;
            for (int i = 0; i <= Min(X, Y); i++)
            {
                result *= trialCnt - i;
                result /= Min(X, Y) + 1;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}