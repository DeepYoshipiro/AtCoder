using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC152
{
    class ABC152C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] P = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            int min = P[0];
            for (int i = 0; i < N; i++)
            {
                if (P[i] <= min)
                {
                    result++;
                    min = P[i];
                } 
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
