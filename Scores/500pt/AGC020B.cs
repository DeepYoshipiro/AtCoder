using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class AGC020B
    {
        static void Main(string[] args)
        {
            var K = long.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            Array.Reverse(A);

            var minN = new long[K];
            var maxN = new long[K];
            minN[0] = 2;
            maxN[0] = 3;
            
            for (int i = 1; i < K; i++)
            {
                minN[i] = A[i];
                var group = (minN[i - 1] + (minN[i] - 1)) / minN[i];
                minN[i] *= group;
                maxN[i] = minN[i] + A[i] - 1;
            }

            Array.Reverse(A);
            Array.Reverse(minN);
            Array.Reverse(maxN);
            var winnerMin = minN[0];
            var winnerMax = maxN[0];
            for (int i = 0; i < K; i++)
            {
                winnerMin -= winnerMin % A[i]; 
                winnerMax -= winnerMax % A[i]; 
            }

            if (winnerMin == 2 && winnerMax == 2)
            {
                WriteLine("{0} {1}", minN[0], maxN[0]);
            }
            else
            {
                WriteLine("-1");
            }
            ReadKey();
        }
    }
}
