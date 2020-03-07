using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC043A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            WriteLine((N * (N + 1) / 2).ToString());
            ReadKey();
        }
    }
}
