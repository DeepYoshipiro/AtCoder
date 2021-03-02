using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC144
{
    class ABC144Drev
    {
        static void Main(string[] args)
        {
            double[] init = ReadLine().Split(' ')
                .Select(n => double.Parse(n)).ToArray();
            double a = init[0];
            double b = init[1];
            double x = init[2];

            double boundDegree = Atan(b / a);
            double lowerDegree;
            double upperDegree;
            double currentDegree;
            double keepVolume;

            if (x >= a * a * b / 2)
            {
                lowerDegree = 0;
                upperDegree = boundDegree;
                while (upperDegree - lowerDegree > Pow(10, -8))
                {
                    currentDegree = (upperDegree + lowerDegree) / 2;
                    keepVolume = b - (1/2) * a * Tan(currentDegree);
                    keepVolume = a * a * (b - (1/2) * a * Tan(currentDegree));
                    if (keepVolume >= x)
                    {
                        lowerDegree = currentDegree;
                    }
                    else
                    {
                        upperDegree = currentDegree;
                    }
                }
            }
            else
            {
                lowerDegree = boundDegree;
                upperDegree = PI / 2;
                while (upperDegree - lowerDegree > Pow(10, -8))
                {
                    currentDegree = (upperDegree + lowerDegree) / 2;
                    keepVolume = a * (1 / 2) * b * b * Tan(PI / 2 - currentDegree);
                    if (keepVolume >= x)
                    {
                        lowerDegree = currentDegree;
                    }
                    else
                    {
                        upperDegree = currentDegree;
                    }
                }
            }

            double result =  upperDegree * 180 / PI;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}