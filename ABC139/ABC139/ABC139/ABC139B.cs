using System;
using static System.Console;
using System.Linq;

namespace ABC139
{
    class ABC139B
    {
        static void Main(string[] args)
        {
            //input
            int[] input = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
            int A = input[0];
            int B = input[1];

            //calculation
            int result = 1;
            int useAbleSocket = A;
            
            while (useAbleSocket < B)
            {
                result += 1;
                useAbleSocket += A - 1;
            }

            //output
            WriteLine(result.ToString());
        }
    }
}
