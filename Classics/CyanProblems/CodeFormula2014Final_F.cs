using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class CodeFormula2014Final_F
    {
        static void Main(string[] args)
        {
            int X = 0;
            int curY = 100;
            int maxY = 200;
            
            var centerX = new int[101];
            var centerY = new int[101];
            for (int i = 100; i >= 1; i--)
            {
                X += i;
                if (X + i > 1500)
                {
                    X = i;
                    curY = maxY + i;
                    maxY += 2 * i;
                }
                centerX[i] = X;
                centerY[i] = curY;
                X += i;
            }

            for (int i = 1; i <= 100; i++)
            {
                WriteLine("{0} {1}", centerX[i], centerY[i]);
            }
            ReadKey();
        }
    }
}
