using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace AISing2020
{
    class AISing2020B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = (new int[]{0}) 
                .Concat(ReadLine().Split()
                    .Select(n => int.Parse(n)))
                .ToArray();

            int result = 0;
            for (int i = 1; i <= N; i += 2)
            {
                if (A[i] % 2 != 0) result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
