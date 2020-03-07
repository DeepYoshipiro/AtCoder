using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC070A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            WriteLine(N / 100 == N % 10 ? "Yes" : "No");
            ReadKey();
        }
    }
}
