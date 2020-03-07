using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class AGC011A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int C = init[1];
            int K = init[2];

            List<int> T = new List<int>();
            for (int i = 0; i < N; i++)
            {
                T.Add(int.Parse(ReadLine()));
            }

            T.Sort();

            int bus = 0;
            int passenger = 0;
            int busDepartLimit = K;
            for (int i = 0; i < N; i++)
            {
                if (passenger == 0)
                {
                    bus++;
                    busDepartLimit = T[i] + K;
                }
                if (T[i] <= busDepartLimit && passenger < C)
                {
                    passenger++;
                }
                else
                {
                    passenger = 0;
                    i--;
                }
            }

            WriteLine(bus.ToString());
            ReadKey();
        }
    }
}