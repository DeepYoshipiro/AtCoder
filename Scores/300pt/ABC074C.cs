using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC074C
    {
        static int A;
        static int B;
        static int C;
        static int D;
        static int E;
        static int F;
        static int resultSugar;
        static int resultWater;

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];
            int C = init[2];
            int D = init[3];
            int E = init[4];
            int F = init[5];

            var water = new bool[(F / 100) + 1];
            for (int a = 0; a < F / 100; a++)
            {
                for (int b = 0; b < F / 100; b++)
                {
                    var w = A * a + B * b;
                    if (w > F / 100) break;
                    water[w] = true;
                }
            }
            water[0] = false;

            var sugar = new bool[F + 1];
            for (int c = 0; c < F; c++)
            {
                for (int d = 0; d < F; d++)
                {
                    var s = C * c + D * d;
                    if (s > F) break;
                    sugar[s] = true;
                }
            }

            WriteLine("{0} {1}", resultSugar + resultWater, resultSugar);
            ReadKey();
        }

        static double DFS(int sugar, int water)
        {
            int sugarWater = sugar + water;
            if (sugarWater > F)
            {
                return 0;
            }

            double density = 0;
            if (sugarWater > 0)
            {
                density = (double)sugar / (double)sugarWater;
            }

            if (water > 0 && density > (double)E / 100d)
            {
                return 0;
            }

            if (sugarWater > F - Min(C, D))
            {
                return (double)sugar / (double)sugarWater;
            }

            if (sugar == 0)
            {
                DFS(sugar, water + A);
                DFS(sugar, water + B);
            }

            if (water > 0)
            {
                if (DFS(sugar + C, water) > density)
                {
                    density = (double)(sugar + C) / (double)(sugarWater + C);
                    resultSugar = sugar + C;
                    resultWater = water;
                }

                if (DFS(sugar + D, water) > density)
                {
                    density = (double)(sugar + D)/ (double)(sugarWater + D);
                    resultSugar = sugar + D;
                    resultWater = water;
                }
            }

            return density;
        }
    }
}
        // class SugarWater
        // {
        //     internal int SugarWeight {get;}
        //     internal int WaterWeight {get;}
        //     internal double Density {get;}

        //     internal SugarWater(int sugar, int water)
        //     {
        //         SugarWeight = sugar;
        //         WaterWeight = water;
        //         if (sugar + water == 0)
        //         {
        //             Density = 0;
        //         }
        //         else
        //         {
        //             Density = (double)(sugar / (sugar + water));
        //         }
        //     }
        // }
