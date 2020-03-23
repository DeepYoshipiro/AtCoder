using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC158
{
    class ABC158C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];

            int result = -1;
            for (int i = 1; i <= 2000; i++)
            {
                if (Floor(i * 0.08) == A && Floor(i * 0.1) == B)
                {
                    result = i;
                    break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
