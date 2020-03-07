using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC014A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n=> int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];
            int C = init[2];

            int a = A;
            int b = B;
            int c = C;

            int result = 0;
            while (A % 2 == 0 && B % 2 == 0 && C % 2 == 0)
            {
                result++;
                a = (B + C) / 2;
                b = (C + A) / 2;
                c = (A + B) / 2;

                A = a;
                B = b;
                C = c;
                if (A == init[0] && B == init[1] && C == init[2])
                {
                    result = -1;
                    break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}