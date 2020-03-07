using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC040C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int> a = new List<int>{0}
                .Concat(ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToList()
                ).ToList();
            a.Add(int.MaxValue);
        
            List<int> dpCost
             = Enumerable.Repeat<int>(int.MaxValue, N + 2).ToList();

            dpCost[1] = 0;
            for (int i = 1; i <= N - 1; i++)
            {
                dpCost[i + 1]
                 = Min(dpCost[i] + Abs(a[i + 1] - a[i])
                     , dpCost[i + 1]);

                dpCost[i + 2]
                    = Min(dpCost[i] + Abs(a[i + 2] - a[i])
                    , dpCost[i + 2]);
            }

            WriteLine(dpCost[N].ToString());
            ReadKey();
        }
    }
}