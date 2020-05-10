using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC166
{
    class ABC166B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            bool[] haveSweet = new bool[N + 1];
            for (int i = 0; i < K; i++)
            {
                int d = int.Parse(ReadLine());
                int[] sweet = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                for (int j = 0; j < d; j++)
                {
                    haveSweet[sweet[j]] = true; 
                }
            }

            int result = 0;
            for (int k = 1; k <= N; k++)
            {
                result += haveSweet[k] ? 0 : 1;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
