// Solution: bit-search
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC104C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            var D = init[0];
            var G = init[1];

            var p = new int[D + 1];
            var c = new int[D + 1];

            for (int i = 1; i <= D; i++)
            {
                var prob = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                p[i] = prob[0];
                c[i] = prob[1];
            }

            int result = p.Sum();
            for (int i = 0; i < 1<<D; i++)
            {
                int curPoint = 0;
                int solvedProblem = 0;
                var getComp = new bool[D + 1];
                int pbLvl;
                for (int bit = 0; bit < D; bit++)
                {
                    if ((i & 1<<bit) > 0)
                    {
                        pbLvl = bit + 1;
                        getComp[pbLvl] = true;
                        curPoint += p[pbLvl] * pbLvl * 100 + c[pbLvl];
                        solvedProblem += p[pbLvl];
                    }
                }
                if (curPoint >= G)
                {
                    if (solvedProblem < result)
                    {
                        result = solvedProblem;
                    }
                    continue;
                }

                for (pbLvl = D; pbLvl >= 1; pbLvl--)
                {
                    var shotage = G - curPoint;
                    if (!getComp[pbLvl])
                    {
                        if (shotage <= (p[pbLvl] - 1) * pbLvl * 100)
                        {
                            int solve = ((shotage + (pbLvl - 1) * 100)) / (pbLvl * 100);
                            solvedProblem += solve;
                            curPoint += solve * pbLvl * 100;
                            break;
                        }
                        else
                        {
                            curPoint += (p[pbLvl] - 1) * pbLvl * 100;
                            solvedProblem += p[pbLvl] - 1;
                        }
                    }
                }
                if (curPoint >= G)
                {
                    if (solvedProblem < result)
                    {
                        result = solvedProblem;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
