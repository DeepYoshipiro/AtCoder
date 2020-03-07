using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC127A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];
        
            int result;
            if (A >= 13)
            {
                result = B;
            }
            else if (A >= 6 && A <= 12)
            {
                result = B / 2;
            }
            else
            {
                result = 0;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}