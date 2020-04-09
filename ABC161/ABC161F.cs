using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC161
{
    class ABC161F
    {
        static void Main(string[] args)
        {
            long N = long.Parse(ReadLine());

            long result = 0;
            for (int K = 2; K <= N; K++)
            {
                if ((N - 1) % K == 0) result++;
            } 

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
