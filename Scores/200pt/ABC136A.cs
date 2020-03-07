using System;
using System.Linq;
using static System.Console;

namespace _100pt
{
    class ABC136A
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];
            int C = init[2];

            int result = B + C - A;
            if (result < 0) result = 0;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}