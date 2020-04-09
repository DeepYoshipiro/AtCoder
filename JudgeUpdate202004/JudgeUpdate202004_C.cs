using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace JudgeUpdate202004
{
    class JudgeUpdate202004_C
    {
        static int[] A;
        static bool[][] stacked;

        static void Main(string[] args)
        {
            A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            stacked = new bool[4][];    //よこ、たての順番
            for (int i = 1; i <= 3; i++)
            {
                stacked[i] = new bool[4]{true, true, true, true};
                for (int j = 1; j <= A.Where(n => n >= i).Max(); j++)
                {
                    stacked[i][j] = false;                 
                }
            }

            stacked[1][1] = false;
            int curY = 1;
            int curX = 1;
            for (int i = 1; i <= A.Sum(); i++)
            {
                Calc(1, curX, curY, stacked);
            }
        }

        static int Calc(int result, int curW, int curH, bool[][] stacked)
        {
            bool[][] newStacked = (bool[][])stacked.Clone();

            // Move X
            if (curW + 1 <= 3)
            {
                newStacked[curW + 1][curH] = true;
                Calc(result + 1, curW + 1, curH, newStacked);
            }
            return -1;
        }
    }
}