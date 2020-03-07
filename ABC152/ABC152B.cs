using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC152
{
    class ABC152B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int a = init[0];
            int b = init[1];

            if (a < b)
            {
                for (int i = 0; i < b; i++)
                {
                    Write(a.ToString());
                }
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    Write(b.ToString());
                }
            }

            WriteLine();
            ReadKey();
        }
    }
}
