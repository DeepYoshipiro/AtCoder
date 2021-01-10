using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC188
{
    class ABC188C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToList();
            
            int competitor = 1;
            for (int j = 0; j < N; j++)
            {
                competitor *= 2;
            }

            int westWinnerID = 0;
            int westMax = 0;
            for (int i = 0; i < competitor / 2; i++)
            {
                if (A[i] > westMax)
                {
                    westWinnerID = i + 1;
                    westMax = A[i];
                }
            }

            int eastMax = 0;
            int eastWinnerID = 0;
            for (int i = competitor / 2; i < competitor; i++)
            {
                if (A[i] > eastMax)
                {
                    eastWinnerID = i + 1;
                    eastMax = A[i];
                }
            }

            WriteLine(westMax < eastMax ? westWinnerID : eastWinnerID);
            ReadKey();
        }
    }
}
