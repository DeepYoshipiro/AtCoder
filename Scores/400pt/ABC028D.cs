using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC028D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int n = N;

            int one = 0;
            int rest = 0;
            for (int d = 0; d <= (int)Log10(N); d++)
            {
                rest = n % (int)Pow(10, d + 1);
                one += n / (int)Pow(10, d + 1) * (int)Pow(10, d);
                if (rest >= (int)Pow(10, d) && rest < 2 * (int)Pow(10, d))
                {
                    one += rest - (int)Pow(10, d) + 1;
                }
                else if (rest >= 2 * (int)Pow(10, d))
                {
                    one += (int)Pow(10, d);
                }
            }

            WriteLine(one.ToString());
            ReadKey();
        }
    }
}