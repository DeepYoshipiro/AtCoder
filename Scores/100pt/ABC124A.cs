using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC124A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderByDescending(n => n).ToArray();
          	int A = init[0];
          	int B = init[1];

            int result = A;
            A--;
            if (A >= B)
            {
                result += A;
            }
            else
            {
                result += B;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}