using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ETC
{
    class AOJ0168
    {
        static void Main(string[] args)
        {
            int N = 30;
            int[] dpCases
             = Enumerable.Repeat<int>(0, N + 3).ToArray();
            dpCases[0] = 1;
            for (int n = 0; n < N; n++)
            {
                for (int u = 1; u <= 3; u++)
                {
                    dpCases[n + u] += dpCases[n];
                }
            }

            int[] requiredDays = new int[N + 1];
            int[] result = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                requiredDays[i] = (dpCases[i] + 9) / 10;
                result[i] = (requiredDays[i] + 364) / 365;
            }

            while(true)
            {
                int n = int.Parse(ReadLine());

                if (n == 0) break;
                WriteLine(result[n].ToString());
            };

            ReadKey();
        }
    }
}