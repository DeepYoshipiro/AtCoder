using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC194
{
    class ABC194D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var arrived = new decimal[N + 1];
            arrived[1] = 0;
            for (int i = 2; i <= N; i++)
            {
                arrived[i] = arrived[i - 1] + (decimal)N / ((decimal)N - ((decimal)i - 1));
            }

            WriteLine(arrived[N].ToString());
            ReadKey();
        }
    }
}
