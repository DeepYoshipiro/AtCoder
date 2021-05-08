using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC200
{
    class ABC200B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = init[0];
            var K = (int)init[1];

            for (int i = 0; i < K; i++)
            {
                if (N % 200 == 0)
                {
                    N /= 200;
                }
                else
                {
                    N *= 1000;
                    N += 200;
                }
            }

            WriteLine(N.ToString());
            ReadKey();
        }
    }
}
