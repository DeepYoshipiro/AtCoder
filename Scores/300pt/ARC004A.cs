using System;
using System.Linq;
using static System.Console;
using static System.Math;

namespace _300pt
{

    class ARC004A
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(ReadLine());

            int[] x = new int[N];
            int[] y = new int[N];
            for (int i = 0; i < N; i++)
            {
                int[] input = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                x[i] = input[0];
                y[i] = input[1];
            }

            //calculate
            double maxLengthSquare = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    double lengthSquare = Pow(x[j] - x[i], 2) + Pow(y[j] - y[i], 2);
                    if (lengthSquare > maxLengthSquare) maxLengthSquare = lengthSquare;
                }
            }

            //output
            double maxLength = Sqrt(maxLengthSquare);
            WriteLine(maxLength.ToString());
            ReadKey();
        }
    }
}
