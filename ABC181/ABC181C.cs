using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC181
{
    class ABC181C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            
            var x = new double[N];
            var y = new double[N];
            for (int i = 0; i < N; i++)
            {
                var point = ReadLine().Split()
                    .Select(n => double.Parse(n)).ToArray();
                x[i] = point[0];
                y[i] = point[1];
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    double m1 = (x[j] - x[i] == 0
                         ? 0 : (y[j] - y[i]) / (x[j] - x[i]));
                    for (int k = j + 1; k < N; k++)
                    {
                        if (x[j] - x[i] == 0 && x[k] - x[i] == 0)
                        {
                            WriteLine("Yes");
                            ReadKey();
                            return;
                        }     
                        double m2 = (x[k] - x[i] == 0
                            ? 0
                            : (y[k] - y[i]) / (x[k] - x[i]));
                        if (m1 != m2) continue;
                        var m = m1;
                        if (m == 0)
                        {
                            WriteLine("Yes");
                            ReadKey();
                            return;
                        }

                        var b1 = -m * x[k] + y[k];
                        var b2 = -m * x[i] + y[i];
                        if (b1 == b2)
                        {
                            WriteLine("Yes");
                            ReadKey();
                            return;
                        }
                    }
                }
            }

            WriteLine("No");
            ReadKey();
        }
    }
}
