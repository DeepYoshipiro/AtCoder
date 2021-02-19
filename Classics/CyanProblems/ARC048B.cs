using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ARC048B
    {
        static void Main(string[] args)
        {
            const int MAX_RATE = 100000;
            const int SAME_RATE_SUM = 3;

            var N = int.Parse(ReadLine());
            var competitor = new int[N][];
            var distribution = new int[MAX_RATE + 1][]
                    .Select(v => new int[4]).ToArray();

            for (int i = 0; i < N; i++)
            {
                var init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var R = init[0];
                var H = init[1] % 3;
                competitor[i] = new int[]{R, H}; 
                distribution[R][H]++;
            }

            for (int j = 1; j <= MAX_RATE; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    distribution[j][SAME_RATE_SUM]
                        += distribution[j][k];               
                }
                distribution[j][SAME_RATE_SUM] 
                    += distribution[j - 1][SAME_RATE_SUM];
            }

            for (int i = 0; i < N; i++)
            {
                var curRate = competitor[i][0];
                var win = distribution[curRate - 1][SAME_RATE_SUM];

                var sameRate
                     = distribution[curRate][SAME_RATE_SUM] - win;
                var curHand = competitor[i][1];
                win += distribution[curRate][(curHand + 1) % 3];
                var draw = distribution[curRate][curHand] - 1;

                var lose = (N - 1) - (win + draw);
                WriteLine("{0} {1} {2}", win, lose, draw);
            }
            ReadKey();
        }
    }
}
