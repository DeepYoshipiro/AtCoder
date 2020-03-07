using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC142
{
    class ABC142A
    {
        static void Main(string[] args)
        {
            decimal N = decimal.Parse(ReadLine());

            decimal result = 0;
            if (N % 2 == 0)
            {
                result = 0.5M;
            }
            else
            {
                result = (N + 1) / 2 / N;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
