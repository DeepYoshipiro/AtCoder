using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC144
{
    class ABC144C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(ReadLine());

            long result = N - 1;
            for (long i = 1; i <= (long)Sqrt(N + 1); i++)
            {
                if (N % i == 0)
                {
                    long j = N / i;
                    long nominee = (i - 1) + (j - 1);
                    if (result > nominee) result = nominee;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
