using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC088C
    {
        static void Main(string[] args)
        {
            int[][] c = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                c[i] = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
            }

            int[] a = new int[3];
            int[] b = new int[3];
            bool result = false;
            for (a[0] = 0; a[0] <= c[0][0]; a[0]++)
            {
                b[0] = c[0][0] - a[0];

                a[1] = a[0] + c[1][0] - c[0][0];
                a[2] = a[0] + c[2][0] - c[0][0];

                b[1] = b[0] + c[0][1] - c[0][0];
                b[2] = b[0] + c[0][2] - c[0][0];

                if (a[0] + b[0] == c[0][0] && a[0] + b[1] == c[0][1] && a[0] + b[2] == c[0][2]
                    && a[1] + b[0] == c[1][0] && a[1] + b[1] == c[1][1] && a[1] + b[2] == c[1][2]
                    && a[2] + b[0] == c[2][0] && a[2] + b[1] == c[2][1] && a[2] + b[2] == c[2][2])
                {
                    if (a[0] >= 0 && a[0] <= 100
                        && a[1] >= 0 && a[1] <= 100
                        && a[2] >= 0 && a[2] <= 100
                        && b[0] >= 0 && b[0] <= 100
                        && b[1] >= 0 && b[1] <= 100
                        && b[2] >= 0 && b[2] <= 100
                        )
                    {
                        result = true;
                        break;
                    }
                }
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}