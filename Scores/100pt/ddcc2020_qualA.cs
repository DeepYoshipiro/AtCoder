using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ddcc2020_qualA
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
          	int X = init[0];
          	int Y = init[1];

            int result = 0;
            switch (X)
            {
                case 1:
                    result += 300000;
                    break;
                case 2:
                    result += 200000;
                    break;
                case 3:
                    result += 100000;
                    break;
            }

            switch (Y)
            {
                case 1:
                    result += 300000;
                    break;
                case 2:
                    result += 200000;
                    break;
                case 3:
                    result += 100000;
                    break;
            }

            if (X == 1 && Y == 1)
            {
                result += 400000;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}