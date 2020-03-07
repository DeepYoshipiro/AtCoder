using System;
using static System.Console;
using System.Linq;

namespace ABC139
{
    class ABC139C
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(ReadLine());
            int[] H = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

            //calculation
            int result = 0;
            int moveAble = 0;
            for (int i = 0; i < N - 1; i++) {
                if (H[i] >= H[i + 1])
                {
                    moveAble++;
                    if (moveAble > result) result = moveAble;
                }
                else moveAble = 0;
            }

            //output
            WriteLine(result.ToString());
        }
    }
}
