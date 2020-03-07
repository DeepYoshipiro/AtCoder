using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC081C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderByDescending(n => n).ToArray();
            
            long sideNominee = 0;
            int edge = 0;

            List<long> madeAbleSide = new List<long>();

            for (int i = 0; i < N; i++)
            {
                if (A[i] == sideNominee)
                {
                    edge++;
                    if (edge % 2 == 0)
                        madeAbleSide.Add(sideNominee);
                }
                else
                {
                    sideNominee = A[i];
                    edge = 1;                    
                }
            }

            long result
                 = (madeAbleSide.Count >= 2
                  ? madeAbleSide[0] * madeAbleSide[1] : 0);

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}