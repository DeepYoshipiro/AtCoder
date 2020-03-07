using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC145
{
    class ABC145C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[] x = new int[N];
            int[] y = new int[N];
            for (int i = 0; i < N; i++)
            {
                int[] info = ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
                x[i] = info[0];
                y[i] = info[1];
            }

            int[][] distX_square = new int[N][];
            int[][] distY_square = new int[N][];

            for (int i = 0; i < N; i++)
            {
                distX_square[i] = new int[N];
                distY_square[i] = new int[N];
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    distX_square[i][j] = (x[j] - x[i]) * (x[j] - x[i]);
                    distY_square[i][j] = (y[j] - y[i]) * (y[j] - y[i]);
                }
            }

            double result = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    result += Sqrt(distX_square[i][j] + distY_square[i][j]);
                }
            }

            result /= N;
            result *= 2;
                
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
