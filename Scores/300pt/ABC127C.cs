using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC127C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int minMasterID = 1;
            int maxMasterID = N;

            for (int i = 0; i < M; i++)
            {
                int[] ID = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                int L = ID[0];
                int R = ID[1];
                if (minMasterID < L) minMasterID = L;
                if (maxMasterID > R) maxMasterID = R;
            }

            int result = maxMasterID - minMasterID + 1;
            if (result <= 0) result = 0;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}