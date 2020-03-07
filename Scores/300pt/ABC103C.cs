using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC103C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result += a[i] - 1;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}