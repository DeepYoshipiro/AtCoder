using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC148
{
    class ABC148D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            int satisfy = 0;
            for (int i = 0; i < N; i++)
            {
                if (a[i] == satisfy + 1)
                {
                    satisfy++;
                }
            }

            int result = (satisfy < 1 ? -1 : N - satisfy);
            
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}