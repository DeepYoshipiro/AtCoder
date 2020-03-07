using System;
using static System.Console;
using System.Linq;
using static System.Math;

namespace _300pt
{
    class AGC008A
    {
        static void Main(string[] args)
        {
            //input
            int[] input = ReadLine().Split(' ').Select(n=> int.Parse(n)).ToArray();
            int x = input[0];
            int y = input[1];

            int MinOperation;

            //calculate
            int AbsXY = Abs(Abs(y) - Abs(x));

            if (x >= 0)
            {
                if (x <= y) MinOperation = AbsXY;
                else if (y > 0) MinOperation = AbsXY + 2;
                else MinOperation = AbsXY + 1;
            }
            else {
                if (x > y) MinOperation = AbsXY + 2;
                else if (y <= 0) MinOperation = AbsXY;
                else MinOperation = AbsXY + 1;
            }

            //output;
            WriteLine(MinOperation.ToString());
            ReadKey();
        }
    }
}
