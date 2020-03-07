using System;
using static System.Console;

namespace ABC139
{
    class ABC139D
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(ReadLine());

            //calculation
            int result = (N - 1) * N / 2;

            //output
            WriteLine(result.ToString());
        }
    }
}
