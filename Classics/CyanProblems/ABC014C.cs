using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ABC014C
    {
        static void Main(string[] args)
        {
            int color = 1000001;
            int n = int.Parse(ReadLine());

            int[] needs = new int[color + 1];
            for (int i = 0; i < n; i++)
            {
                int[] range = ReadLine().Split()
                    .Select(m => int.Parse(m)).ToArray();
                needs[range[0]]++;
                needs[++range[1]]--;
            }

            for (int j = 1; j <= color; j++)
            {
                needs[j] += needs[j - 1];
            }

            WriteLine(needs.Max().ToString());
            ReadKey();
        }
    }
}
