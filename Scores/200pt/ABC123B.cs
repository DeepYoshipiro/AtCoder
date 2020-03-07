using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC123B
    {
        static void Main(string[] args)
        {
            const int DISHES = 5;
            int[] waitDish = new int[DISHES];

            int minRest = 10;
            int minRestDish = -1;
            for (int i = 0; i < DISHES; i++)
            {
                waitDish[i] = int.Parse(ReadLine());
                int rest = waitDish[i] % 10;
                if (rest == 0) rest = 10;
                if (rest < minRest)
                {
                    minRest = rest;
                    minRestDish = i;
                }
            }

            int result = 0;
            for (int i = 0; i < DISHES; i++)
            {
                if (i != minRestDish)
                {
                    waitDish[i] += 9;
                    waitDish[i] /= 10;
                    waitDish[i] *= 10;
                }
                result += waitDish[i];
            }
 
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}