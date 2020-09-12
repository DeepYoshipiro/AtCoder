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

            var sortX = X.OrderBy(n => n).ToArray();
            var sortY = Y.OrderBy(n => n).ToArray();

            for (int i1 = 0; i1 < N; i1++)
            {
                for (int i2 = i1 + 1; i2 < N; i2++)
                {
                    for (int j1 = 0; j1 < N; j1++)
                    {
                        for (int j2 = j1 + 1; j2 < N; j2++)
                        {
                            long minX = Min(sortX[i1], sortX[i2]);
                            long maxX = Max(sortX[i1], sortX[i2]);

                            long minY = Min(sortY[j1], sortY[j2]);
                            long maxY = Max(sortY[j1], sortY[j2]);

                            long measure = (maxX - minX) * (maxY - minY);
                            if (measure > result) continue;

                            int include = 0;
                            for (int k = 0; k < N; k++)
                            {
                                if (X[k] < minX || X[k] > maxX) continue;
                                if (Y[k] < minY || Y[k] > maxY) continue;
                                include++;
                            }
                            if (include >= K)
                            {
                                result = measure;
                            }
                        }                    
                    }
                }
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
