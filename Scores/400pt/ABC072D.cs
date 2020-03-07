using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC072D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int> p = new List<int>{0}
                .Concat(ReadLine().Split(' ')
                .Select(n => int.Parse(n))).ToList();

            int result = 0;
            int connect = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i == p[i])
                    connect++;
                else
                {
                    result += (connect + 1) / 2;
                    connect = 0;
                }
            }
            if (connect > 0) result += (connect + 1) / 2;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}