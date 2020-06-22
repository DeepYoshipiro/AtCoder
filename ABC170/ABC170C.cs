using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC170
{
    class ABC170C
    {
        static void Main(string[] args)
        {
            int Max_P = 101;
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var X = init[0];
            var N = init[1];

            var diff = new int[Max_P + 1];

            for (int i = 0; i <= Max_P; i++)
            {
                diff[i] = Abs(X - i);
            }

            var contain = new bool[Max_P + 1];
            if (N != 0)
            {
                var P = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                
                for (int i = 0; i < N; i++)
                {
                    contain[P[i]] = true;
                }
            }
            else
            {
                var P = ReadLine();
            }

            int minDiff = Max_P * 2;
            int result = -1;
            for (int i = 0; i <= Max_P; i++)
            {
                if (!contain[i] && diff[i] < minDiff)
                {
                    result = i;
                    minDiff = diff[i];
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
