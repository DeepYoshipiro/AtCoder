using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC162
{
    class ABC162C
    {
        static void Main(string[] args)
        {
            int K = int.Parse(ReadLine());

            int result = 0;
            for (int a = 1; a <= K; a++)
            {
                for (int b = 1; b <= K; b++)
                {
                    int gcd_ab = gcd(a, b);
                    for (int c = 1; c <= K; c++)
                    {
                        result += gcd(gcd_ab, c);
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        static int gcd(int m, int n)
        {
            int a = Max(m, n);
            int b = Min(m, n);

            int r = b;
            while (r > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
