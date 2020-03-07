using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC1NN
{
    class ABC1NNP
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            long result = 0;
            result %= 1000000007;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}