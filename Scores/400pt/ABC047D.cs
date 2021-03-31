using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC047D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var T = init[1];

            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var buyA = A[0];
            var profit = new List<long>();
            for (int i = 1; i < N; i++)
            {
                switch (A[i].CompareTo(buyA))
                {
                    case -1:
                        buyA = A[i];
                        break;
                    case 0:
                        break;
                    default:
                        profit.Add(A[i] - buyA);
                        break;
                }
            }

            profit.Sort();
            profit.Reverse();

            int result = 0;
            var maxDeal = profit[0];
            for (int i = 0; i < profit.Count(); i++)
            {
                if (maxDeal == profit[i])
                {
                    result++;
                }
                else
                {
                    break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
