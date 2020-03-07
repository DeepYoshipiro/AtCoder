using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ARC043A
    {
        static void Main(string[] args)
        {
            double[] init = ReadLine().Split(' ')
                .Select(n => double.Parse(n)).ToArray();
            int N = (int)init[0];
            double A = init[1];
            double B = init[2];

            double[] S = new double[N];

            for (int i = 0; i < N; i++)
            {
                S[i] = double.Parse(ReadLine());
            }

            double diff = S.Max() - S.Min();
            double avg = S.Average();
            if (diff == 0)
            {
                WriteLine("-1");
                ReadKey();
                return;
            }

            double P = B / diff;
            double Q = A - P * avg;

            WriteLine(P + " " + Q);
            ReadKey();
        }
    }
}