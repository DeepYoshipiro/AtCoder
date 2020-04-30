using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ARC074C
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long H = init[0];
            long W = init[1];

            if (H % 3 == 0 || W % 3 == 0)
            {
                WriteLine(0.ToString());
                ReadKey();
                return;
            }

            BaseAlgorithm ba = new BaseAlgorithm();

            List<long> result = new List<long>();
            for (int m = 0; m <= 1; m++)
            {
                for (int h = 1; h < H; h++)
                {
                    // First Cut
                    long firstMeasure = W * h;
                    long curH = H - h;

                    // Second Cut
                    // Horizonal Cut
                    List<long> horizonalCutMeasure = new List<long>(3);
                    horizonalCutMeasure.Add(firstMeasure);
                    horizonalCutMeasure.Add(W * (curH / 2));
                    horizonalCutMeasure.Add(W * (curH - (curH / 2)));
                    horizonalCutMeasure.Sort();

                    result.Add(horizonalCutMeasure.Last() - horizonalCutMeasure.First());

                    // Vertical Cut                    
                    List<long> crossCutMeasure = new List<long>(3);
                    crossCutMeasure.Add(firstMeasure);
                    crossCutMeasure.Add((W / 2) * curH);
                    crossCutMeasure.Add((W - (W / 2)) * curH);
                    crossCutMeasure.Sort();

                    result.Add(crossCutMeasure.Last() - crossCutMeasure.First());
                }
                ba.Swap(ref W, ref H);
            }

            WriteLine(result.Min().ToString());
            ReadKey();
        }
    }

    class BaseAlgorithm
    {
        internal void Swap(ref long A, ref long B)
        {
            long tmp = A;
            A = B;
            B = tmp;
        }
    }
}

