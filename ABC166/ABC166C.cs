using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC166
{
    class ABC166C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int[] H = (new int[]{0})
                .Concat(ReadLine().Split()
                    .Select(n => int.Parse(n))).ToArray();

            bool[] goodObs = new bool[N + 1];
            for (int n = 1; n <= N; n++)
            {
                goodObs[n] = true;
            }

            for (int i = 0; i < M; i++)
            {
                int[] path = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                switch (Sign(H[path[0]] - H[path[1]]))
                {
                    case 1: // Obs[path[0]] is higher
                        goodObs[path[1]] = false;
                        break;
                    case -1: // Obs[path[1]] is higher
                        goodObs[path[0]] = false;
                        break;
                    default: // Obs[path[0]] == Obs[path[1]]
                        goodObs[path[0]] = false;    
                        goodObs[path[1]] = false;
                        break;
                }
            }

            int result = 0;
            for (int n = 1; n <= N; n++)
            {
                result += goodObs[n] ? 1 : 0;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
