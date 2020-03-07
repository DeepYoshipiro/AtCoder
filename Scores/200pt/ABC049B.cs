using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC049B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];

            string[] C = new string[2 * H];
            for (int i = 0; i < H; i++)
            {
                C[2 * i] = ReadLine();
                C[2 * i + 1] = C[2 * i];
            }

            for (int i = 0; i < 2 * H; i++)
            {
                WriteLine(C[i]);
            }
            ReadKey();
        }
    }
}