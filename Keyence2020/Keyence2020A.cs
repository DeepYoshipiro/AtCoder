using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace Keyence2020
{
    class Keyence2020A
    {
        static void Main(string[] args)
        {
            int H = int.Parse(ReadLine());
            int W = int.Parse(ReadLine());
            int paintOnce = Max(H, W);

            int N = int.Parse(ReadLine());
            int result = (N + paintOnce - 1) / paintOnce; 
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
