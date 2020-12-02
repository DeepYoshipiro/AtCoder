using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC109
{
    class ARC109B
    {
        static void Main(string[] args)
        {
            var N = long.Parse(ReadLine());

            long low = 0;
            long tooHigh = (long)Sqrt(N + 1);

            while (tooHigh - low > 1)
            {
                long cur = (low + tooHigh) / 2;
                if (cur * (cur + 1) / 2 <= N + 1)
                {
                    low = cur;
                }
                else
                {
                    tooHigh = cur;
                }
                cur = (low + tooHigh) / 2;
            }

            WriteLine(((N + 1) - low).ToString());
            ReadKey();
        }
    }
}
