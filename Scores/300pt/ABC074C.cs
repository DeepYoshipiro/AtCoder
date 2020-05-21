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

            var waterPoorAble = new bool[(F / 100) + 1];
            for (int a = 0; a <= F / 100; a++)
            {
                for (int b = 0; b <= F / 100; b++)
                {
                    var w = A * a + B * b;
                    if (w > F / 100) break;
                    waterPoorAble[w] = true;
                }
            }
            waterPoorAble[0] = false;

            var sugarAddAble = new bool[F + 1];
            for (int c = 0; c < F; c++)
            {
                for (int d = 0; d < F; d++)
                {
                    var s = C * c + D * d;
                    if (s > F) break;
                    sugarAddAble[s] = true;
                }
            }

            int resultSugarWater = 100 * A;
            int resultSugar = 0;

            double maxDensity = 0;
            for (int w = 1; w <= F / 100; w++)
            {
                if (!waterPoorAble[w]) continue;
                int maxSugar = E * w;
                for (int s = maxSugar; s >= 0; s--)
                {
                    if (!sugarAddAble[s]) continue;
                    if (w * 100 + s > F) continue;
                    double density = (double)s / (double)(w * 100 + s);
                    if (density > maxDensity)
                    {
                        maxDensity = density;
                        resultSugarWater = w * 100 + s;
                        resultSugar = s;
                    } 
                    break;
                }
            }

            WriteLine("{0} {1}", resultSugarWater, resultSugar);
            ReadKey();
        }
    }
}
