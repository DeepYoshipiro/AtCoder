using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC147
{
    class ABC147A
    {
        static void Main(string[] args)
        {
            int[] A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            if (A.Sum() <= 21)
            {
                WriteLine("win");
            }
            else
            {
                WriteLine("bust");
            }


            ReadKey();
        }
    }
}
