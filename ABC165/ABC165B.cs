using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC165
{
    class ABC165B
    {
        static void Main(string[] args)
        {
            long deposit = 100;
            long X = long.Parse(ReadLine());

            int result = 0;
            while (deposit < X)
            {
                deposit = (long)(deposit * 1.01);
                result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
