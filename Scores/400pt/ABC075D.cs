using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC075D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            var X = new long[N];
            var Y = new long[N];
            for (int i = 0; i < N; i++)
            {
                var p = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                
                X[i] = p[0];
                Y[i] = p[1];
            }

            long result = (X.Max() - X.Min()) * (Y.Max() - Y.Min());

            Array.Sort(X, Y);
            for (int j = K; j <= N; j++)
            {
                for (int i = 0; i < N - j; i++)
                {
                    var cutX = X[i + j - 1] - X[i];
                    var searchY = new long[j];
                    Array.Copy(Y, i, searchY, 0, j);
                    var cutY = searchY.Max() - searchY.Min();
                    if (cutX * cutY < result)
                    {
                        result = cutX * cutY;
                    }
                }
            }

            Array.Sort(Y, X);
            for (int j = K; j <= N; j++)
            {
                for (int i = 0; i < N - j; i++)
                {
                    var cutY = Y[i + j - 1] - Y[i];
                    var searchX = new long[j];
                    Array.Copy(X, i, searchX, 0, j);
                    var cutX = searchX.Max() - searchX.Min();
                    if (cutX * cutY < result)
                    {
                        result = cutX * cutY;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
