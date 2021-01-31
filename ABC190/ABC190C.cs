using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC190
{
    class ABC190C
    {
        static void Main(string[] args)
        { 
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var pairDishes = new int[M][];
            for (int i = 0; i < M; i++)
            {
                pairDishes[i] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            }

            var K = int.Parse(ReadLine());
            var choice = new int[K][];
            for (int j = 0; j < K; j++)
            {
                choice[j] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            }

            int result = 0;
            for (int bit = 0; bit < (1<<K); bit++)
            {
                var existBall = new bool[N + 1];

                for (int j = 0; j < K; j++)
                {
                    if ((bit & (1<<j)) == 0)
                    {
                        existBall[choice[j][0]] = true;
                    }
                    else
                    {
                        existBall[choice[j][1]] = true;
                    }
                }

                int satisfy = 0;
                for (int i = 0; i < M; i++)
                {
                    if (existBall[pairDishes[i][0]] && existBall[pairDishes[i][1]])
                    {
                        satisfy++;
                    }
                }

                if (satisfy > result) result = satisfy;
            } 

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
