using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class AGC021A
    {
        static void Main(string[] args)
        {
            long N = long.Parse(ReadLine());

            int digitN = (int)Log10(N) + 1; // ex.245678
            int result = (digitN - 1) * 9;  // ex.99999

            for (long i = 2 * (long)Pow(10, digitN - 1) - 1
                ; i <= N; i += (long)Pow(10, digitN - 1))
            {
                result++;
            } 

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}