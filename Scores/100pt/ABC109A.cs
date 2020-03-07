using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC109A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
          	int A = init[0];
          	int B = init[1];

            if (A % 2 == 1 && B % 2 ==1)
            {
                WriteLine("Yes");
            }
            else
            {
                WriteLine("No");
            }

            ReadKey();
        }
    }
}