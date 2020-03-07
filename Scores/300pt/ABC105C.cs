using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC105C
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(ReadLine());

            //calculate
            int digit = (int)Log(Abs(N), 2) + 2;

            string result = "";

            int a = N;
            do
            {
                int b = -2;
                int q = (int)Floor((double)(a / b));

                int r = a - b * q;
                if (r < 0) { q++; r -= b; }
                a -= r;
                a /= -2;

                if (r == 0)
                {
                    result = "0" + result;
                }
                else
                {
                    result = "1" + result;
                }
            } while (a != 0);

            //output;
            WriteLine(result);
            ReadKey();
        }
    }
}
