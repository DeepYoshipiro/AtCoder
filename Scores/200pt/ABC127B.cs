using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC127B
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int r = init[0];
            int D = init[1];
            int x = init[2];

            for (int i = 1; i <= 10; i++)
            {
                x = r * x - D;
                WriteLine(x.ToString());
            }

            ReadKey();
        }
    }
}