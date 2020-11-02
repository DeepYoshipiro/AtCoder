using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC181
{
    class ABC181B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            long result = 0;

            for (int i = 0; i < N; i++)
            {
                var board = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                var A = board[0];
                var B = board[1];

                result += (B - A + 1) * (A + B) / 2;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
