using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC124B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] H = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            int highest = H[0];
            for (int i = 0; i < N; i++)
            {
                if (H[i] >= highest)
                {
                    result++;
                    highest = H[i];
                } 
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
