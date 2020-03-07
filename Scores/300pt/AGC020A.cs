using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC020A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ').Select(n=> int.Parse(n))
                .OrderByDescending(m => m).ToArray();
            //int N = init[0];  //じつは、Nいらなかった。
            int A = init[1];
            int B = init[2];

            int distance = B - A;
            if (distance % 2 == 0)
            {
                WriteLine("Alice");
            }
            else
            {
                WriteLine("Borys");
            }
            
            ReadKey();
        }
    }
}