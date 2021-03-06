using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ABC016D
    {
        static void Main(string[] args)
        {
            var cut = ReadLine().Split()
                .Select(n => decimal.Parse(n)).ToArray();
            var Ax = cut[0];
            var Ay = cut[1];
            var Bx = cut[2];
            var By = cut[3];

            var a = By - Ay;
            var b = -(Bx - Ax);

            var N = int.Parse(ReadLine());
            var X = new decimal[N + 1];
            var Y = new decimal[N + 1];

            for (int i = 0; i < N; i++)
            {
                var vertex = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                X[i] = vertex[0];
                Y[i] = vertex[1];
            }
            X[N] = X[0];
            Y[N] = Y[0];

            int intersection = 0;
            for (int i = 0; i < N; i++)
            {
                var c = Y[i + 1] - Y[i];
                var d = -(X[i + 1] - X[i]);

                var det = a * d - b * c;
                if (det == 0) continue;

                var p = a * Ax + b * Ay;
                var q = c * X[i] + d * Y[i];

                var x = (-q * b + p * d) / det;
                var y = (a * q - c * p) / det;
                
                if (x < Min(X[i], X[i + 1]) || Max(X[i], X[i + 1]) < x) continue;
                if (y < Min(Y[i], Y[i + 1]) || Max(Y[i], Y[i + 1]) < y) continue;

                intersection++;
            }

            var result = intersection / 2 + 1;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
