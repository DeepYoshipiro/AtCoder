using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC196
{
    class ABC196C
    {
        static void Main(string[] args)
        {
            var N = long.Parse(ReadLine());
            int digit = 0;
            long m = 1;
            while (m < N)
            {
                digit++;
                m *= 10;
            }
            if (digit == 0) digit = 1;

            int result = 0;
            for (int i = 1; i <= (int)Pow(10, digit / 2); i++)
            {
                string curI = i.ToString();
                curI = curI + curI;
                if (long.Parse(curI) > N) break;
                result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
