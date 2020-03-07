using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC098A
    {
        static void Main(string[] args)
        {
            int[] init =  ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];

            int result = A + B;
            int sub = A - B;
            int mul = A * B;
            if (sub > result) result = sub;
            if (mul > result) result = mul;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
