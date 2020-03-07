using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class AGC004A
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long A = init[0];
            long B = init[1];
            long C = init[2];

            long result;
            if (A % 2 == 0 || B % 2 == 0 || C % 2 == 0)
            {
                result = 0;
            }
            else
            {
                result = A * B;
                result = (result > B * C ? B * C : result);
                result = (result > C * A ? C * A : result);
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}            

