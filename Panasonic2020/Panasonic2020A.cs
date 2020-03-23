using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Panasonic2020
{
    class Panasonic2020A
    {
        static void Main(string[] args)
        {
            int K = int.Parse(ReadLine());
            int[] seq = new int[]{1, 1, 1, 2, 1, 2, 1, 5, 2, 2, 1, 5, 1, 2, 
                    1, 14, 1, 5, 1, 5, 2, 2, 1, 15, 2, 2, 5, 4, 1, 4, 1, 51};

            WriteLine(seq[K - 1].ToString());
            ReadKey();
        }
    }
}
