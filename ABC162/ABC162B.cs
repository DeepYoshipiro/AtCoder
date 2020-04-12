using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC162
{
    class ABC162B
    {
        static void Main(string[] args)
        {
            long N = int.Parse(ReadLine());

            long result = 0;
            for (long i = 1; i <= N; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    result += i;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
