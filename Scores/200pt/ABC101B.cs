using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC101B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int n = N;

            int S = 0;
            while (n > 0)
            {
                S += n % 10;
                n /= 10;
            }

            WriteLine(N % S == 0 ? "Yes" : "No");
            ReadKey();
        }
    }
}