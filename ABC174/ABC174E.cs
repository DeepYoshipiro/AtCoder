// Solution : Binary Search
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC174
{
    class ABC174E
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = (int)init[0];
            var K = init[1];

            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();

            long longestPiece = A.Max();

            if (K == 0)
            {
                WriteLine(longestPiece.ToString());
                ReadKey();
                return;
            }
            else if (K >= A.Sum())
            {
                WriteLine("1");
                ReadKey();
                return;
            }

            long shortestPiece = 1;

            long result = longestPiece;
            while (longestPiece != shortestPiece)
            {
                var trialLength = (longestPiece + shortestPiece) / 2;
                long totalCut = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    totalCut += (A[i] - 1) / trialLength; 
                }

                if (K < totalCut)
                {
                    shortestPiece = trialLength + 1;
                    continue;
                }

                if (trialLength < result) result = trialLength;
                longestPiece = trialLength;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
