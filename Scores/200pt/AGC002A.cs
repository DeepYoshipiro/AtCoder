using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class AGC002A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int a = init[0];
            int b = init[1];

            string result = "";
            if (a > 0)
                result = "Positive";
            else if (a <= 0 && b >= 0)
                result = "Zero";
            else    // b < 0
            {
                int cnt = b - a + 1;
                if (cnt % 2 == 0)
                    result = "Positive";
                else
                    result = "Negative";
            }

            WriteLine(result);
            ReadKey();
        }
    }
}