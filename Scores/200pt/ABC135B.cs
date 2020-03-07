using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC135B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[] p = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int[] q = p.OrderBy(n => n).ToArray();

            int diff = 0;
            for (int i = 0; i < N; i++)
            {
                if (p[i] != q[i])
                {
                    diff++;
                }
            }

            WriteLine((diff == 0 || diff == 2) ? "YES" : "NO");
            ReadKey();
        }
    }
}