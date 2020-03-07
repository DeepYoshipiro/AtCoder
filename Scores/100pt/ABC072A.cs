using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC072A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int X = init[0];
            int t = init[1];
            
            int result = X - t;
            if (result < 0) result = 0;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
