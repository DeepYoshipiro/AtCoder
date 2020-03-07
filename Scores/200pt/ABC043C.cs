using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC043C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] a = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            
            int result = int.MaxValue;
            for (int y = a.Min(); y <= a.Max(); y++)
            {
                int sumSquare = 0;
                for (int i = 0; i < N; i++)
                {
                    sumSquare += (int)Pow(y - a[i], 2);
                }
                if (result > sumSquare)
                {
                    result = sumSquare;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}