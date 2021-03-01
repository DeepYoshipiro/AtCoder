using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC193
{
    class ABC193D
    {
        static void Main(string[] args)
        {
            var K = long.Parse(ReadLine());

            var S = ReadLine().ToCharArray();
            var T = ReadLine().ToCharArray();

            var leftCard = Enumerable.Repeat(K, 10).ToArray();
            leftCard[0] = 0;

            var curSscore = Enumerable.Range(0, 10).ToArray();
            var curTscore = Enumerable.Range(0, 10).ToArray();

            for (int i = 0; i < 4; i++)
            {
                var Scard = S[i] - '0';
                var Tcard = T[i] - '0';

                leftCard[Scard]--;
                leftCard[Tcard]--;

                curSscore[Scard] *= 10;
                curTscore[Tcard] *= 10;
            }

            long sumLeftCard = leftCard.Sum();
            decimal univarseCases = 0;
            decimal winSCases = 0;
            for (int lastS = 1; lastS <= 9; lastS++)
            {
                var lastLeftCard = (long[])leftCard.Clone();
                if (lastLeftCard[lastS] == 0) continue;
                univarseCases += lastLeftCard[lastS] * (sumLeftCard - 1);
                lastLeftCard[lastS]--;

                for (int lastT = 1; lastT <= 9; lastT++)
                {
                    if (lastLeftCard[lastT] == 0) continue;
                    var decideSscore = (int[])curSscore.Clone();
                    var decideTscore = (int[])curTscore.Clone();

                    decideSscore[lastS] *= 10;
                    decideTscore[lastT] *= 10;

                    if (decideSscore.Sum() > decideTscore.Sum())
                    {
                        if (lastS == lastT)
                        {
                            winSCases += leftCard[lastS] * (leftCard[lastS] - 1);
                        }
                        else
                        {
                            winSCases += leftCard[lastS] * leftCard[lastT]; 
                        }
                    }
                } 
            }

            decimal result = winSCases / univarseCases;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
