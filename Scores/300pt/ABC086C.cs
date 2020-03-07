using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC086C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] t = new int[N + 1];
            int[] x = new int[N + 1];
            int[] y = new int[N + 1];

            t[0] = 0;
            x[0] = 0;
            y[0] = 0;

            for (int i = 1; i <= N; i++)
            {
                int[] plan = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

                t[i] = plan[0];
                x[i] = plan[1];
                y[i] = plan[2];
            }

            bool result = true;
            for (int i = 0; i < N; i++)
            {
                int moveTime = t[i + 1] - t[i];
                int moveDistance = Abs(x[i + 1] - x[i]) + Abs(y[i + 1] - y[i]);

                if (moveDistance > moveTime
                     || (moveTime - moveDistance) % 2 != 0)
                {
                    result = false;
                    break;
                }
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}