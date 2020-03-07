using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class Codefestival_2016_qualC_B
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int K = init[0];
            int T = init[1];

            int A = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray().Max();

            int result = 2 * A - K - 1;
            if (result < 0) result = 0;
            
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}