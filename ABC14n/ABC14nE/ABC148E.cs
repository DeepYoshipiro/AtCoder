using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC148
{
    class ABC148E
    {
        static void Main(string[] args)
        {
            long N = long.Parse(ReadLine());

            if (N % 2 != 0)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            long result = 0;
            long n = N;
            while (n / 10 > 0)
            {
                result += n / 10;
                n /= 10;
            }

            for (long j = 1; j <= Log10(N); j++)
            {
                result += (N / (5 * (long)Pow(10, j))) * j;
                if (N / (long)Pow(10, j + 1) >= 1)
                    result -= (N / (long)Pow(10, j + 1)) * j;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}