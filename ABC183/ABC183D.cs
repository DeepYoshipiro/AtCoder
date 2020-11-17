using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC183
{
    class ABC183D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = (int)init[0];
            var W = init[1];

            int maxTime = 200000;            
            var demand = new long[maxTime + 1];
            for (int i = 0; i < N; i++)
            {
                var info = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                var S = (int)info[0];
                var T = (int)info[1];
                var P = info[2];
                demand[S] += P;
                demand[T] -= P;
            }

            if (demand[0] > W)
            {
                WriteLine("No");
                ReadKey();
                return;
            }

            for (int j = 1; j < maxTime; j++)
            {
                demand[j] += demand[j - 1];
                if (demand[j] > W)
                {
                    WriteLine("No");
                    ReadKey();
                    return;
                }
            }

            WriteLine("Yes");
            ReadKey();
        }
    }
}
