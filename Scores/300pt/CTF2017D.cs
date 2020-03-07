using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class CTF2017D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int result;
            int r = N % M;
            if (r > 0)
            {
                result = M;
                int a = Max(M, N);
                int b = Min(M, N);

                while (b != 0)
                {
                    int q = a / b;
                    r = a - q * b;
                    a = b;
                    b = r;
                }
                r = a;
                result -= r;
            }
            else {
                result = 0;
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}