using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class ARC024B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var color = new int[2 * N];
            for (int i = 0; i < N; i++)
            {
                color[i] = int.Parse(ReadLine());
                color[i + N] = color[i];
            }

            int curColor = color[0];
            int maxContinuous = 1;
            int curContinuous = 1;
            for (int i = 1; i < 2 * N; i++)
            {
                if (curColor == color[i])
                {
                    curContinuous++;
                    if (curContinuous > maxContinuous)
                    {
                        maxContinuous = curContinuous;
                    }
                }
                else
                {
                    curColor = color[i];
                    curContinuous = 1;
                }
            }

            if (maxContinuous >= N)
            {
                WriteLine("-1");
                ReadKey();
                return;               
            }

            WriteLine(((maxContinuous + 1) / 2).ToString());
            ReadKey();
        }
    }
}
