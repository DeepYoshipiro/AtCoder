using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC060B
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];
            int C = init[2];

            bool result = false;
            int r = 0;            
            for (int i = 0; i < B; i++)
            {
                r += A;
                r %= B;
                if (r == C)
                {
                    result = true;
                    break;
                }
            }

            WriteLine(result ? "YES" : "NO");
            ReadKey();
        }
    }
}