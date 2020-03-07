using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class AGC006B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int x = init[1];

            if (x == 1 || x == 2 * N - 1)
            {
                WriteLine("No");
                ReadKey();
                return;
            }
            
            WriteLine("Yes");
            int[] result = new int[2 * N - 1];
            result[N - 1] = x;
            result[N] = x - 1;
            result[N - 2] = x + 1;

            int cur = 1;
            int restLessXmax = x - 2;
            int restMoreXmin = x + 2;
            for (int i = 0; i < 2 * N - 1; i++)
            {
                if (result[i] == 0)
                {
                    if (cur > restLessXmax)
                    {
                        restLessXmax = int.MaxValue;
                        cur = restMoreXmin;
                    }
                    result[i] = cur;
                    cur++;
                }
                WriteLine(result[i].ToString());
            }
            ReadKey();
        }
    }
}