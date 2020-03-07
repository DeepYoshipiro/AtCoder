using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC121D
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long A = init[0];
            long B = init[1];

            int digit2 = (int)Floor(Log(B, 2));
            long xor = 0;
            if ((B - (A - 1)) % 4 >= 2) {
                xor = 1;
            }

            for (int i = 1; i <= digit2; i++)
            {
                int xorUntilA;
                int xorUntilB;

                long rB = (long)(B % Pow(2, i + 1));
                if (rB >= Pow(2, i))
                {
                    xorUntilB = (int)((rB - ((long)Pow(2, i) - 1)) % 2);
                }
                else {
                    xorUntilB = 0;
                }

                long rA = (long)((A - 1) % Pow(2, i + 1));
                if (rA >= Pow(2, i))
                {
                    xorUntilA = (int)((rA - ((long)Pow(2, i) - 1)) % 2);
                }
                else
                {
                    xorUntilA = 0;
                }

                xor += (Abs(xorUntilB - xorUntilA) % 2) * (long)Pow(2, i);
            }

            WriteLine(xor.ToString());
            ReadKey();
        }
    }
}
