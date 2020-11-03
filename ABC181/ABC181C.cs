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
            
            var x = new int[N];
            var y = new int[N];
            for (int i = 0; i < N; i++)
            {
                var point = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                x[i] = point[0];
                y[i] = point[1];
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    var x1 = x[j] - x[i];
                    var y1 = y[j] - y[i];
                    for (int k = j + 1; k < N; k++)
                    {
                        var x2 = x[k] - x[i];
                        var y2 = y[k] - y[i];
                        var det = x1 * y2 - y1 * x2;
                        if (det == 0)
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
