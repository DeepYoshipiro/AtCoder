using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC064A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int num = init[0] * 100 + init[1] * 10 + init[2];

            if (num % 4 == 0)
            {
                WriteLine("YES");
            }
            else
            {
                WriteLine("NO");
            }
            ReadKey();
        }
    }
}