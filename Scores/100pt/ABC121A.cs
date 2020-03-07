using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC121A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
          	int H = init[0];
          	int W = init[1];

            int[] remove = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
          	int h = remove[0];
          	int w = remove[1];

            int result = (H - h) * (W - w);
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
